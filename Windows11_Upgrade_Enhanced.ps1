<#  Windows 11 Upgrade Assistant — Hardened Redux (PS 5.1 compatible, Oct 2025)
    Activation check is WARNING-ONLY by default (bypass). Set WUA_IgnoreActivation=false to enforce.
    Exit codes:
      0   Success (handoff/staged)
      1   Fatal preflight/signature error
      10  Remnants present and not cleaned (blocked start)
      20  No activity (idle timeout)
      21  Assistant exited too quickly / failed to initialize
      22  Global max wait exceeded
      30  Configuration.ini missing (Assistant footprint corrupt)
      90  Fallback reboot scheduled
#>

#=========================
# REGION: Globals/Params
#=========================
$ErrorActionPreference = 'Stop'
$PSDefaultParameterValues['*:ErrorAction'] = 'Stop'

# --- Helpers for PS 5.1 defaults & bool parsing
function Get-EnvOrDefault {
    param([string]$Name,[string]$Default)
    $v = [Environment]::GetEnvironmentVariable($Name)
    if ($null -eq $v -or $v -eq '') { return $Default } else { return $v }
}
function To-Bool {
    param($Value)
    if ($Value -is [bool]) { return $Value }
    $s = "$Value".Trim().ToLowerInvariant()
    return @('1','true','yes','y','on') -contains $s
}

# --- Robust working directory (inline-safe)
try {
    if ($PSVersionTable.PSVersion.Major -ge 3 -and $PSScriptRoot) {
        $scriptDir = $PSScriptRoot
    } elseif ($MyInvocation.MyCommand.Path) {
        $scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
    } else {
        $scriptDir = Join-Path $env:ProgramData 'W11Assistant'
    }
} catch {
    $scriptDir = Join-Path $env:ProgramData 'W11Assistant'
}
New-Item -ItemType Directory -Path $scriptDir -Force | Out-Null

# --- TLS for downloads
[Net.ServicePointManager]::SecurityProtocol = [Enum]::ToObject([Net.SecurityProtocolType], 3072)

# --- Tunables (env overrides) — PS5.1-safe
[bool]$IgnoreActivation     = (To-Bool (Get-EnvOrDefault 'WUA_IgnoreActivation'     'true'))   # <— BYPASS ACTIVATION BY DEFAULT
[int] $MaxWaitMinutes       = [int](Get-EnvOrDefault 'WUA_MaxWaitMinutes'           '240')
[int] $IdleMinutes          = [int](Get-EnvOrDefault 'WUA_IdleMinutes'              '20')
[bool]$CleanupRemnants      = (To-Bool (Get-EnvOrDefault 'WUA_CleanupRemnants'      'false'))
[bool]$ForceReboot          = (To-Bool (Get-EnvOrDefault 'WUA_ForceReboot'          'false'))
[int] $RebootDeadlineMinutes= [int](Get-EnvOrDefault 'WUA_RebootDeadlineMinutes'    '30')

# --- Paths / constants
$tsRoot         = "$env:ProgramData\W11Assistant"
New-Item -ItemType Directory -Path $tsRoot -Force | Out-Null
$Transcript     = Join-Path $tsRoot ("W11A_{0:yyyyMMdd_HHmmss}.log" -f (Get-Date))
Start-Transcript -Path $Transcript -Force | Out-Null

$AssistantUrlShort   = 'https://go.microsoft.com/fwlink/?linkid=2171764'
$AssistantExpectedCA = 'Microsoft Windows Code Signing PCA 2024'
$AssistantCAThumb    = 'D30F05F637E605239C0070D1EA9860D434AC2A94'
$AssistantPath       = Join-Path $scriptDir 'installAssistant.exe'
$ConfigIni           = "${env:ProgramFiles(x86)}\WindowsInstallationAssistant\Configuration.ini"
$WindowsWS           = "$env:SystemDrive\`$WINDOWS.~WS"
$WindowsBT           = "$env:SystemDrive\`$Windows.~BT\Sources"

#=========================
# REGION: Utility helpers
#=========================
function Write-Info($m){ Write-Host "- $m" }
function Write-Note($m){ Write-Host ": $m" }
function Write-Warn($m){ Write-Host "! $m" }
function New-EventLogEntry([string]$msg,[int]$id=2001,[string]$entryType='Information'){
    try{
        $src='Datto-W11A'
        if(-not [System.Diagnostics.EventLog]::SourceExists($src)){
            New-EventLog -LogName Application -Source $src | Out-Null
        }
        Write-EventLog -LogName Application -Source $src -EventId $id -EntryType $entryType -Message $msg
    }catch{}
}

function quitOr {
    if ($env:usrOverrideChecks -match 'true') {
        Write-Warn "Blocking error overridden by usrOverrideChecks=true (unsupported path)."
    } else {
        Write-Warn "Blocking error; aborting."
        Stop-Process -Name setupHost        -ErrorAction SilentlyContinue
        Stop-Process -Name mediaTool        -ErrorAction SilentlyContinue
        Stop-Process -Name installAssistant -ErrorAction SilentlyContinue
        Stop-Transcript | Out-Null
        exit 1
    }
}

function Get-ResolvedUrl([string]$url){
    $req = [System.Net.HttpWebRequest]::Create($url); $req.Method='HEAD'; $req.Timeout=15000
    $resp = $req.GetResponse(); $final = $resp.ResponseURI.AbsoluteURI; $resp.Close(); return $final
}

function downloadShortlink ($url, $whitelist, $filename) {
    Write-Info "Downloading Windows Installation Assistant..."
    try {
        $long = Get-ResolvedUrl $url
        $wc = New-Object System.Net.WebClient
        $wc.DownloadFile($long, $filename)
        if (!(Test-Path $filename) -or (Get-Item $filename).Length -lt 102400) { throw "Download incomplete." } # ~100KB
        Write-Note "Resolved URL: $long"
        Write-Info "Downloaded: $([IO.Path]::GetFileName($filename))"
    } catch {
        Write-Warn "File could not be downloaded. Ensure $whitelist is allowed."
        quitOr
    }
}

function verifyPackage ($file, $certificate, $thumbprint, $name, $url) {
    Write-Info "Verifying digital signature for $name..."
    try {
        $sig = Get-AuthenticodeSignature -FilePath $file
        if ($sig.Status -ne 'Valid') { throw "Signature status: $($sig.Status)" }
        $chain = New-Object System.Security.Cryptography.X509Certificates.X509Chain
        $null  = $chain.Build($sig.SignerCertificate)
        $intermediate = ($chain.ChainElements | ForEach-Object {$_.Certificate} |
                         Where-Object { $_.Subject -match [regex]::Escape($certificate) }).Thumbprint
        if ($intermediate -ne $thumbprint) {
            throw "Chain thumbprint mismatch. Got $intermediate, expected $thumbprint"
        }
        Write-Info "Digital Signature verification passed."
    } catch {
        Write-Warn "$name did not pass verification: $($_.Exception.Message)"
        Write-Note "Verify $url is reachable and not SSL-inspected."
        quitOr
    }
}

function Test-PendingReboot {
    $paths = @(
        'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Component Based Servicing\RebootPending',
        'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update\RebootRequired',
        'HKLM:\SYSTEM\CurrentControlSet\Control\Session Manager' # PendingFileRenameOperations
    )
    foreach($p in $paths){
        if(Test-Path $p){
            if($p -like '*Session Manager*'){
                $val = (Get-ItemProperty $p -Name PendingFileRenameOperations -ErrorAction SilentlyContinue).PendingFileRenameOperations
                if($val){ return $true }
            } else { return $true }
        }
    }
    return $false
}

function Get-ESDContext {
    if (!(Test-Path $ConfigIni)) { return [pscustomobject]@{ Exists=$false } }
    $line = Select-String -Path $ConfigIni -Pattern 'DownloadESDFolder' -ErrorAction SilentlyContinue | Select-Object -First 1 -ExpandProperty Line
    if (-not $line) { return [pscustomobject]@{ Exists=$true; EsdPath=$null } }
    $folder = $line.Split('=')[1].Trim()
    $esd = Get-ChildItem -Path (Join-Path $folder '*.esd') -ErrorAction SilentlyContinue | Sort-Object LastWriteTime -Descending | Select-Object -First 1
    [pscustomobject]@{ Exists=$true; EsdPath=$folder; EsdFile=$esd }
}

function Get-SetupLogActivity {
    $log = Join-Path $WindowsBT 'setupact.log'
    if(Test-Path $log){ (Get-Item $log).LastWriteTime } else { $null }
}

function Invoke-Watchdog {
    param([int]$MaxMinutes,[int]$IdleMins)
    Write-Info "Watchdog started (Max: $MaxMinutes mins | Idle: $IdleMins mins)..."
    $start = Get-Date
    $lastActivity = Get-Date
    $lastEsdSize = -1
    $lastLogTime = Get-SetupLogActivity

    while ($true) {
        Start-Sleep -Seconds 30

        if ((Get-Date) -gt $start.AddMinutes($MaxMinutes)) {
            Write-Warn "Global timeout exceeded."
            New-EventLogEntry "W11A watchdog: max wait exceeded" 2022 'Warning'
            return 22
        }

        $proc = Get-Process -Name 'installAssistant','Windows10UpgraderApp','Windows11UpgraderApp','setupHost' -ErrorAction SilentlyContinue
        Write-Note ("Observed processes: {0}" -f (($proc | Select-Object -Expand Name) -join ', '))

        $ctx = Get-ESDContext
        if (-not $ctx.Exists) {
            Write-Warn "Configuration.ini not found; Assistant likely failed."
            return 30
        }

        if ($ctx.EsdFile) {
            $sz = $ctx.EsdFile.Length
            $lts = $ctx.EsdFile.LastWriteTime
            Write-Note ("ESD: {0} ({1:N1} MB) LWT:{2:HH:mm:ss}" -f $ctx.EsdFile.Name, ($sz/1MB), $lts)
            if ($sz -ne $lastEsdSize) { $lastEsdSize = $sz; $lastActivity = Get-Date }
            elseif ($lts -gt $lastActivity) { $lastActivity = $lts }
        }

        $logTime = Get-SetupLogActivity
        if ($logTime -and $lastLogTime -and ($logTime -gt $lastLogTime)) { $lastLogTime = $logTime; $lastActivity = Get-Date }
        elseif ($logTime -and -not $lastLogTime) { $lastLogTime = $logTime; $lastActivity = Get-Date }

        if ((Get-Date) -gt $lastActivity.AddMinutes($IdleMins)) {
            Write-Warn "No progress for $IdleMins minutes."
            if ($proc | Where-Object { $_.Name -eq 'installAssistant' }) { return 20 } else { return 21 }
        }

        if ($proc | Where-Object { $_.Name -eq 'setupHost' }) { Write-Info "SetupHost active; hand-off underway."; return 0 }
        if ($ctx.EsdFile -and -not ($proc) -and (Test-PendingReboot)) {
            Write-Info "Installation staged; pending reboot detected."
            return 0
        }
    }
}

function Start-AssistantWithRetry {
    param([string]$Exe,[string]$Args,[int]$Retry=1)

    Write-Info "Launching Windows Installation Assistant..."
    $p = Start-Process -FilePath $Exe -ArgumentList $Args -PassThru -ErrorAction Stop

    # Quick-exit detection; allow 10s to initialize & create Configuration.ini
    $stillRunning = -not (Wait-Process -Id $p.Id -Timeout 10 -ErrorAction SilentlyContinue)
    if ($stillRunning) { return @{ Started=$true; Retried=$false; ExitCode=$null } }

    $code = $p.ExitCode
    Write-Warn "Assistant exited too quickly (code $code)."
    # Purge stale footprint and retry once
    if ($Retry -gt 0) {
        $wuaDir="${env:ProgramFiles(x86)}\WindowsInstallationAssistant"
        if (Test-Path $wuaDir) {
            Write-Note "Purging stale InstallationAssistant folder then retrying..."
            try {
                takeown /F "$wuaDir" /R /D Y | Out-Null
                icacls "$wuaDir" /grant "*S-1-5-32-544":(OI)(CI)F /T /C | Out-Null
                Remove-Item $wuaDir -Recurse -Force
            } catch { Write-Note "Purge failed: $($_.Exception.Message)" }
        }
        $p2 = Start-Process -FilePath $Exe -ArgumentList $Args -PassThru -ErrorAction Stop
        $stillRunning2 = -not (Wait-Process -Id $p2.Id -Timeout 10 -ErrorAction SilentlyContinue)
        if ($stillRunning2) { return @{ Started=$true; Retried=$true; ExitCode=$null } }
        else { return @{ Started=$false; Retried=$true; ExitCode=$p2.ExitCode } }
    }

    return @{ Started=$false; Retried=$false; ExitCode=$code }
}

#=========================
# REGION: Device info + eligibility
#=========================
[int]$varWinver=(Get-ItemProperty "HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion" -Name CurrentBuildNumber).CurrentBuildNumber
[int]$varLangCode=cmd /c set /a 0x$((Get-ItemProperty hklm:\system\controlset001\control\nls\language -name InstallLanguage).InstallLanguage)
[int]$varSKU=(Get-WmiObject -Class win32_operatingsystem -Property OperatingSystemSKU).OperatingSystemSKU

Write-Host "Windows 11 Updater — Hardened Redux"
Write-Host "==================================="
Write-Note  "Hostname:        $env:COMPUTERNAME"
Write-Note  "Windows Build:   $varWinver"
Write-Note  "Windows Edition: $((Get-WmiObject -Class win32_operatingSystem).caption)"
Write-Note  "System Language: $(([system.globalization.cultureinfo]::GetCultures("AllCultures") | ? {$_.LCID -eq $varLangCode}).DisplayName)"
if ($env:usrOverrideChecks -match 'true') { Write-Warn "usrOverrideChecks=true — blocking errors will be ignored." }
else { Write-Note "Blocking errors will abort execution unless otherwise stated." }
Write-Note  "IgnoreActivation (bypass) = $IgnoreActivation"
Write-Host "==================================="

# SKU allow list
if ((4,27,48,49,98,99,100,101,161,162) -contains $varSKU) { Write-Info "Device Windows SKU ($varSKU) is supported." }
else { Write-Warn "Device Windows SKU ($varSKU) not supported."; quitOr }

# ServicesPipeTimeout
REG ADD "HKLM\SYSTEM\CurrentControlSet\Control" /v ServicesPipeTimeout /t REG_DWORD /d "300000" /f 2>&1>$null
Write-Info "Service timeout set to 5 minutes."

# Architecture
if ((Get-WMIObject -Class Win32_Processor).Architecture -ne 9) { Write-Warn "Non-AMD64 CPU. Cannot continue."; exit 1 }
if ([IntPtr]::Size -eq 4) { Write-Note "32-bit OS on 64-bit CPU; WOW64 note." } else { Write-Info "64-bit architecture check passed." }

# Min version
if ($varWinver -lt 19041) { Write-Warn "Windows 10 2004+ required."; exit 1 } else { Write-Info "Windows version check passed." }

# License (NOW WARN-ONLY by default)
$licenseStatus = (Get-WmiObject SoftwareLicensingProduct | Where-Object { $_.PartialProductKey -and $_.Name -like '*Windows(R)*' } | Select-Object -First 1).LicenseStatus
if ($licenseStatus -ne 1) {
    if ($IgnoreActivation) {
        Write-Warn "Windows license not active. Proceeding due to WUA_IgnoreActivation=true."
    } else {
        Write-Warn "Windows license not active. Enforce by setting WUA_IgnoreActivation=false (or set usrOverrideChecks=true to bypass)."
        quitOr
    }
} else { Write-Info "Windows license is valid." }

# Disk space
$varSysFree = [Math]::Round((Get-WMIObject -Class Win32_Volume |Where-Object {$_.DriveLetter -eq $env:SystemDrive} | Select-Object -ExpandProperty FreeSpace) / 1GB)
if ($varSysFree -lt 20) { Write-Warn "System drive needs >=20GB free."; quitOr } else { Write-Info "Disk space check passed ($varSysFree GB free)." }

# RAM
if (((Get-WmiObject -Class "cim_physicalmemory" | Measure-Object -Property Capacity -Sum).Sum / 1GB) -lt 4) { Write-Warn "RAM below 4GB."; quitOr }
else { Write-Info "RAM check passed." }

# TPM checks (conservative)
$varTPM=@(0,0,0)
try{
    $tpm = Get-WmiObject -Class Win32_TPM -Namespace "root\CIMV2\Security\MicrosoftTpm" -ErrorAction Stop
    if($tpm){ $varTPM[0]=1; if($tpm.IsEnabled().IsEnabled){ $varTPM[1]=1; if($tpm.IsActivated().IsActivated){ $varTPM[2]=1 } } }
}catch{}
switch -Regex ($varTPM -as [string]) {
    '^0'     { Write-Warn "No TPM present."; quitOr }
    '0 0$'   { Write-Warn "TPM detected but disabled."; quitOr }
    '1$'     { Write-Info "TPM installed and active." }
    default  { Write-Warn "TPM present but not fully active."; quitOr }
}

# Remnants check & optional cleanup
if (Test-Path $WindowsWS) {
    Write-Warn "Remnants detected: $WindowsWS"
    if ($CleanupRemnants -or $env:usrOverrideChecks -match 'true') {
        Write-Info "Attempting safe cleanup of remnants..."
        try {
            takeown /F "$WindowsWS" /R /D Y | Out-Null
            icacls "$WindowsWS" /grant "*S-1-5-32-544":(OI)(CI)F /T /C | Out-Null
            Remove-Item -LiteralPath $WindowsWS -Recurse -Force -ErrorAction Stop
            Write-Info "Remnants removed."
        } catch {
            Write-Warn "Could not remove remnants; aborting to avoid hang."
            if ($env:usrOverrideChecks -ne 'true') { Stop-Transcript | Out-Null; exit 10 }
        }
    } else {
        Write-Warn "Will not remove remnants by default. Set WUA_CleanupRemnants=true to auto-clean."
        quitOr
    }
}

#=========================
# REGION: Download/Verify/Launch
#=========================
if (!(Test-Path $AssistantPath) -or (Get-Item $AssistantPath).Length -lt 102400) {
    downloadShortlink $AssistantUrlShort 'https://download.microsoft.com' $AssistantPath
}
verifyPackage $AssistantPath $AssistantExpectedCA $AssistantCAThumb 'Microsoft Update Assistant' 'https://download.microsoft.com'

# Start with quick-exit guard + one remediation retry
$launch = Start-AssistantWithRetry -Exe $AssistantPath -Args '/quietinstall /skipeula /auto upgrade' -Retry 1
if (-not $launch.Started) {
    Write-Warn "Assistant failed to initialize. ExitCode: $($launch.ExitCode)."
    Stop-Transcript | Out-Null
    exit 21
}

#=========================
# REGION: Watchdog
#=========================
$rc = Invoke-Watchdog -MaxMinutes $MaxWaitMinutes -IdleMins $IdleMinutes
switch ($rc) {
    0  { Write-Info "Installation progressing or staged. Handing off." }
    20 { Write-Warn "No activity for $IdleMinutes mins (idle timeout)."; New-EventLogEntry "W11A idle timeout" 2020 'Warning'; Stop-Transcript | Out-Null; exit 20 }
    21 { Write-Warn "Assistant gone; considered failed."; New-EventLogEntry "W11A process missing" 2021 'Warning'; Stop-Transcript | Out-Null; exit 21 }
    22 { Write-Warn "Max wait exceeded ($MaxWaitMinutes mins)."; New-EventLogEntry "W11A max wait exceeded" 2022 'Warning'; Stop-Transcript | Out-Null; exit 22 }
    30 { Write-Warn "Configuration.ini missing; footprint corrupt."; New-EventLogEntry "W11A missing config.ini" 2030 'Error'; Stop-Transcript | Out-Null; exit 30 }
    default { Write-Note "Watchdog return code: $rc" }
}

#=========================
# REGION: Optional reboot fallback
#=========================
if ($ForceReboot) {
    if (Test-PendingReboot) {
        Write-Info "Pending reboot detected. Scheduling controlled reboot."
        New-EventLogEntry "W11A scheduling fallback reboot in $RebootDeadlineMinutes min" 2090 'Information'
        try{
            shutdown.exe /r /t ($RebootDeadlineMinutes*60) /c "Windows 11 upgrade staged; reboot scheduled by Component fallback." /f
            Write-Info "Reboot scheduled in $RebootDeadlineMinutes minutes."
            Stop-Transcript | Out-Null
            exit 90
        }catch{
            Write-Warn "Failed to schedule reboot: $($_.Exception.Message)"
        }
    } else {
        Write-Note "ForceReboot requested but no pending reboot detected yet."
    }
}

#=========================
# REGION: Final
#=========================
Write-Info  "Windows 11 Setup instructed to begin installation."
Write-Note  "Logs: $WindowsBT"
Write-Note  "Transcript: $Transcript"
Write-Host  "==================================="
Stop-Transcript | Out-Null
exit 0
