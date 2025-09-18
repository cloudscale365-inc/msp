
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

Write-Host "Starting installer bundle..."

# Prompt for missing parameters
$HuntressAccountKey = PromptIfMissing -paramName "HuntressAccountKey" -currentValue $HuntressAccountKey
$SentinelOneSiteToken = PromptIfMissing -paramName "SentinelOneSiteToken" -currentValue $SentinelOneSiteToken

# Datto RMM Installer
try {
    Write-Host "Downloading Datto RMM Agent..."
    $DattoPath = "$env:TEMP\AgentInstall.exe"
    (New-Object System.Net.WebClient).DownloadFile("https://concord.rmm.datto.com/download-agent/windows/34124687-895c-46c9-85d0-a276a08082fe", $DattoPath)
    Start-Process $DattoPath -Wait
    Write-Host "Datto RMM Agent installed successfully."
} catch {
    Write-Error "Datto RMM installation failed: $($_.Exception.Message)"
}

# Huntress Installer
try {
    Write-Host "Downloading Huntress Installer..."
    $HuntressPath = "$env:TEMP\HuntressInstaller.exe"
    (New-Object System.Net.WebClient).DownloadFile("https://huntress.io/download/$HuntressAccountKey", $HuntressPath)
    Start-Process -FilePath $HuntressPath -ArgumentList "/S /ACCT_KEY=$HuntressAccountKey" -Wait -NoNewWindow
    Write-Host "Huntress installed successfully."
} catch {
    Write-Error "Huntress installation failed: $($_.Exception.Message)"
}

# SentinelOne Installer
try {
    Write-Host "Downloading SentinelOne Installer..."
    $S1Path = "$env:TEMP\SentinelInstaller.msi"
    Invoke-WebRequest -Uri "https://exchangemymail-my.sharepoint.com/:u:/g/personal/amairura_cloudscale365_com/EZ48S1QCvF9MlVoWmKtVcFoBhC6Z27O0z_SSAKljPdEejw?e=h1Pzch" -OutFile $S1Path
    Start-Process -FilePath $S1Path -ArgumentList "/q SITE_TOKEN=`"$SentinelOneSiteToken`" WSC=false" -Wait
    Write-Host "SentinelOne installed successfully."
} catch {
    Write-Error "SentinelOne installation failed: $($_.Exception.Message)"
}

Write-Host "All installations completed."
