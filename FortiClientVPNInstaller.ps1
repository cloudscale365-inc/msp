# Check if the app is already installed (Registry detection)
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls, [Net.SecurityProtocolType]::Tls11, [Net.SecurityProtocolType]::Tls12, [Net.SecurityProtocolType]::Ssl3
[Net.ServicePointManager]::SecurityProtocol = "Tls, Tls11, Tls12, Ssl3"
$regKeys = @('HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\')
$regKeys += 'HKLM:\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\'


$appPath = "C:\Program Files*\Fortinet\FortiClient\FortiClient.exe"
$appName = "FortiClient VPN"
$installed = $regKeys | Get-ChildItem | Get-ItemProperty | Where-Object { $_.DisplayName -like "*'$appName'*" }
$app64Link = "https://links.fortinet.com/forticlient/win/vpnagent"

# Check if the app is already installed (File exists detection)
$file = Test-Path -Path $appPath

# Path to save the downloaded .exe file in the temporary folder
$tempDownloadPath = [System.IO.Path]::Combine([System.IO.Path]::GetTempPath(), "AppInstaller.exe")

# Arguments to pass to the .exe when running it
$arguments = "/quiet /norestart"

# Function to Cleanup
function Cleanup {
    if (Test-Path -Path $tempDownloadPath) {
        Remove-Item -Path $tempDownloadPath -Force
    }
}

# Function to check if the app is already installed 
function IsInstalled {
    if ((($installed | Measure-Object).Count -gt '0') -or ($file -eq $true)) {
        return $true
    }
    else {
        return $false
    }   
}

# Function to detect architecture
function GetUrl {
    $arch = (Get-CimInstance Win32_operatingsystem).OSArchitecture

    if ($arch -match '64-bit') {
        $url = $app64Link
    }
    else {
        $url = $app64Link   
    }
    return $url
}

function Install-App {
    # Download the .exe file to the temporary folder
    Invoke-WebRequest -Uri (GetUrl) -OutFile $tempDownloadPath
    Write-Host "Installing $appName ..." -ForegroundColor Green
    try {
        Start-Process -FilePath $tempDownloadPath -ArgumentList $arguments -NoNewWindow -Wait
        Write-Host "The app has been installed successfully." -ForegroundColor Green
    }
    catch {
        Write-Error "Failed to install the app." -ForegroundColor Red
    }
    Cleanup
}

if (IsInstalled) {
    Write-Host "The app is already installed." -ForegroundColor Yellow
}
else {
    Install-App
}