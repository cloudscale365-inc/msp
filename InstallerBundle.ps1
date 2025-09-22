Param(
    [string]$HuntressAccountKey,
    [string]$SentinelOneSiteToken
)

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
        exit 1
    }
}

Ensure-Admin

Write-Host "Starting installer bundle..."

# Prompt for missing parameters
$HuntressAccountKey = PromptIfMissing -paramName "HuntressAccountKey" -currentValue $HuntressAccountKey
$SentinelOneSiteToken = PromptIfMissing -paramName "SentinelOneSiteToken" -currentValue $SentinelOneSiteToken

# Datto RMM Installer
try {
    Write-Host "Downloading Datto RMM Agent..."
    $DattoPath = "$env:TEMP\AgentInstall.exe"
    $DattoLog = "$env:TEMP\DattoInstall.log"
    (New-Object System.Net.WebClient).DownloadFile("https://concord.rmm.datto.com/download-agent/windows/34124687-895c-46c9-85d0-a276a08082fe", $DattoPath)
    $process = Start-Process -FilePath $DattoPath -Wait -PassThru -RedirectStandardOutput $DattoLog -RedirectStandardError $DattoLog
    if ($process.ExitCode -eq 0) {
        Write-Host "Datto RMM Agent installed successfully."
    } else {
        Write-Error "Datto RMM installation failed with exit code $($process.ExitCode). Check log at $DattoLog."
    }
} catch {
    Write-Error "Datto RMM installation failed: $($_.Exception.Message)"
}

# Huntress Installer
try {
    Write-Host "Downloading Huntress Installer..."
    $HuntressPath = "$env:TEMP\HuntressInstaller.exe"
    $HuntressLog = "$env:TEMP\HuntressInstall.log"
    (New-Object System.Net.WebClient).DownloadFile("https://huntress.io/download/$HuntressAccountKey", $HuntressPath)
    $process = Start-Process -FilePath $HuntressPath -ArgumentList "/S /ACCT_KEY=$HuntressAccountKey" -Wait -NoNewWindow -PassThru -RedirectStandardOutput $HuntressLog -RedirectStandardError $HuntressLog
    if ($process.ExitCode -eq 0) {
        Write-Host "Huntress installed successfully."
    } else {
        Write-Error "Huntress installation failed with exit code $($process.ExitCode). Check log at $HuntressLog."
    }
} catch {
    Write-Error "Huntress installation failed: $($_.Exception.Message)"
}

# SentinelOne Installer (MSI best practice)
try {
    Write-Host "Downloading SentinelOne Installer..."
    $S1Path = "$env:TEMP\SentinelInstaller.msi"
    $S1Log = "$env:TEMP\SentinelOneInstall.log"
    Invoke-WebRequest -Uri "https://exchangemymail-my.sharepoint.com/:u:/g/personal/amairura_cloudscale365_com/EZ48S1QCvF9MlVoWmKtVcFoBhC6Z27O0z_SSAKljPdEejw?e=h1Pzch" -OutFile $S1Path
    $arguments = "/i `"$S1Path`" /qn SITE_TOKEN=`"$SentinelOneSiteToken`" WSC=false /l*v `"$S1Log`""
    $process = Start-Process -FilePath "msiexec.exe" -ArgumentList $arguments -Wait -PassThru
    if ($process.ExitCode -eq 0) {
        Write-Host "SentinelOne installed successfully."
    } else {
        Write-Error "SentinelOne installation failed with exit code $($process.ExitCode). Check log at $S1Log."
    }
} catch {
    Write-Error "SentinelOne installation failed: $($_.Exception.Message)"
}

Write-Host "All installations completed."
