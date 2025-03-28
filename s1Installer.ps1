$SiteToken = Read-Host "Enter your SentinelOne Site Token"
$DownloadUrl = "https://usea1-swprd1.sentinelone.net/web/api/v2.1/update/agent/download/1954575331355041287/2102955481874601430"
$InstallerPath = "$env:TEMP\SentinelInstaller.msi"

# Download the MSI installer
Invoke-WebRequest -Uri $DownloadUrl -OutFile $InstallerPath

# Install SentinelOne silently
Start-Process "msiexec.exe" -ArgumentList "/i `"$InstallerPath`" /q SITE_TOKEN=$SiteToken WSC=false" -Wait -NoNewWindow
