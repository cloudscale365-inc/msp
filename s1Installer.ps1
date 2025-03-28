# Define the SharePoint download link
$DownloadUrl = "https://exchangemymail-my.sharepoint.com/:u:/g/personal/amairura_cloudscale365_com/EZ48S1QCvF9MlVoWmKtVcFoBhC6Z27O0z_SSAKljPdEejw?e=h1Pzch"

# Define the local path for the installer
$InstallerPath = "$env:TEMP\SentinelInstaller.msi"

# Prompt the user for the SITE TOKEN
$SiteToken = Read-Host "Enter your SentinelOne Site Token"

# Download the MSI file
Write-Host "Downloading SentinelOne Installer..."
Invoke-WebRequest -Uri $DownloadUrl -OutFile $InstallerPath

# Check if the file was downloaded successfully
if (Test-Path $InstallerPath) {
    Write-Host "Download complete. Running installation..."
    
    # Run the installer with the provided SITE TOKEN
    Start-Process -FilePath $InstallerPath -ArgumentList "/q SITE_TOKEN=`"$SiteToken`" WSC=false" -Wait
    
    Write-Host "SentinelOne installation completed."
} else {
    Write-Host "Error: Failed to download the SentinelOne installer. Please check the URL."
}
