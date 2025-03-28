# Prompt the user for Huntress Account Key and Org Key
$accountKey = Read-Host "Enter your Huntress Account Key"
$orgKey = Read-Host "Enter your Organization Key"

# Define download URL and temp file location
$installerUrl = "https://huntress.io/download/$accountKey"
$installerPath = "$env:TEMP\HuntressInstaller.exe"

# Download the installer
Write-Host "Downloading Huntress installer..."
(New-Object Net.WebClient).DownloadFile($installerUrl, $installerPath)

# Check if download was successful
if (Test-Path $installerPath) {
    Write-Host "Download complete. Installing Huntress..."
    # Execute the installer silently with provided keys
    Start-Process -FilePath $installerPath -ArgumentList "/S /ACCT_KEY=$accountKey /ORG_KEY=$orgKey" -Wait -NoNewWindow
    Write-Host "Installation completed!"
} else {
    Write-Host "Error: Failed to download Huntress installer."
}
