Param(
    [string]$HuntressAccountKey,
    [string]$SentinelOneSiteToken
)

$LogPath = "$env:TEMP\InstallLog.txt"
Start-Transcript -Path $LogPath -Append

function PromptIfMissing {
    param (
        [string]$paramName,
        [string]$currentValue
    )
    if (-not $currentValue) {
        Write-Host "$paramName is missing. Please enter a value:"
        return Read-Host "$paramName"
    }
    return $currentValue
}

function Ensure-Admin {
    if (-not ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
        Write-Error "Script must be run as Administrator. Exiting."
        Stop-Transcript
        exit 1
    }
}

function Download-With-Retry {
    param (
        [string]$url,
        [string]$destination,
        [int]$maxAttempts = 3
    )
    $attempt = 0
    while ($attempt -lt $maxAttempts) {
        try {
            Invoke-WebRequest -Uri $url -OutFile $destination -UseBasicParsing
            Write-Host "Downloaded: $url"
            return $true
        } catch {
            Write-Warning "Attempt $($attempt + 1) failed: $($_.Exception.Message)"
            Start-Sleep -Seconds 5
            $attempt++
        }
    }
    Write-Error "Failed to download after $maxAttempts attempts: $url"
    return $false
}

Ensure-Admin

Write-Host "Starting installer bundle..."

$HuntressAccountKey = PromptIfMissing -paramName "HuntressAccountKey" -currentValue $HuntressAccountKey
$SentinelOneSiteToken = PromptIfMissing -paramName "SentinelOneSiteToken" -currentValue $SentinelOneSiteToken

# Datto RMM
$DattoPath = "$env:TEMP\AgentInstall.exe"
if (Download-With-Retry -url "https://concord.rmm.datto.com/download-agent/windows/34124687-895c-46c9-85d0-a276a08082fe" -destination $DattoPath) {
    try {
        $process = Start-Process -FilePath $DattoPath -Wait -NoNewWindow -PassThru
        if ($process.ExitCode -eq 0) {
            Write-Host "Datto RMM Agent installed successfully."
            $dattoService = Get-Service | Where-Object { $_.DisplayName -like "*Datto*" }
            if ($dattoService) {
                Write-Host "Datto RMM service '$($dattoService.Name)' is running."
            } else {
                Write-Warning "Datto RMM service not found."
            }
        } else {
            Write-Error "Datto RMM installation failed with exit code $($process.ExitCode)."
        }
    } catch {
        Write-Error "Datto RMM installation failed: $($_.Exception.Message)"
    }
}

# Huntress
$HuntressPath = "$env:TEMP\HuntressInstaller.exe"
$HuntressURL = "https://huntress.io/download/$HuntressAccountKey"
if (Download-With-Retry -url $HuntressURL -destination $HuntressPath) {
    try {
        $process = Start-Process -FilePath $HuntressPath -ArgumentList "/S /ACCT_KEY=$HuntressAccountKey" -Wait -NoNewWindow -PassThru
        if ($process.ExitCode -eq 0) {
            Write-Host "Huntress installed successfully."
            if (Test-Path "HKLM:\Software\Huntress Labs") {
                Write-Host "Huntress registry key found."
            } else {
                Write-Warning "Huntress registry key not found."
            }
        } else {
            Write-Error "Huntress installation failed with exit code $($process.ExitCode)."
        }
    } catch {
        Write-Error "Huntress installation failed: $($_.Exception.Message)"
    }
}

# SentinelOne
$S1Path = "$env:TEMP\SentinelInstaller.msi"
$S1Log = "$env:TEMP\SentinelOneInstall.log"
$S1URL = "https://exchangemymail-my.sharepoint.com/:u:/r/personal/amairura_cloudscale365_com/Documents/SysAdmin/Projects/CS365/Networking/SentinelInstaller_windows_64bit_v24_1_5_277.msi?csf=1&web=1&e=EnSYes"

if (Download-With-Retry -url $S1URL -destination $S1Path) {
    if ((Get-Item $S1Path).Length -lt 100kb) {
        Write-Error "SentinelOne MSI appears to be corrupted or incomplete. Aborting install."
    } else {
        try {
            $arguments = "/i `"$S1Path`" /qn SITE_TOKEN=`"$SentinelOneSiteToken`" WSC=false /l*v `"$S1Log`""
            $process = Start-Process -FilePath "msiexec.exe" -ArgumentList $arguments -Wait -PassThru
            if ($process.ExitCode -eq 0) {
                Write-Host "SentinelOne installed successfully."
                $s1Service = Get-Service -Name "SentinelAgent" -ErrorAction SilentlyContinue
                if ($s1Service) {
                    Write-Host "SentinelOne service is running."
                } else {
                    Write-Warning "SentinelOne service not found."
                }
            } else {
                Write-Error "SentinelOne installation failed with exit code $($process.ExitCode). Check log at $S1Log."
            }
        } catch {
            Write-Error "SentinelOne installation failed: $($_.Exception.Message)"
        }
    }
}

Write-Host "All installations completed."
Stop-Transcript
