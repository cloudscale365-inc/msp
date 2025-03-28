# Prompt the user to enter the token
$token = Read-Host "Please enter the token"

# Prompt the user to enter the domains allowed to login
$domainsAllowedToLogin = Read-Host "Please enter the domains allowed to login (comma-separated)"

# Check if $app is already installed (Registry detection)
$regKeys = @('HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\')
$regKeys += 'HKLM:\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\'

# Detect and install $app based on the Windows architecture (32-bit or 64-bit)
$arch = (Get-CimInstance Win32_operatingsystem).OSArchitecture

function InstallChromeBrowser {
    $installed = $regKeys | Get-ChildItem | Get-ItemProperty | Where-Object { $_.DisplayName -like '*chrome*' }
    # Check if $app is already installed (File exists detection)
    $file = Test-Path -Path "C:\Program Files*\Google\Chrome\Application\chrome.exe"

    $app = "Google Chrome Browser"

    # Install $app if it is not installed yet
    if ((($installed | Measure-Object).Count -gt '0') -or ($file -eq 'True')) {
        Write-Host "$app is already installed." -ForegroundColor Yellow
    } else {
        if ($arch -match '64-bit') {
            $url = 'https://dl.google.com/dl/chrome/install/googlechromestandaloneenterprise64.msi'
        } else {
            $url = 'https://dl.google.com/dl/chrome/install/googlechromestandaloneenterprise.msi'
        }

        Write-Host "Installing the $arch version of $app ..." -ForegroundColor Green
        try {
            Start-Process -FilePath msiexec.exe -ArgumentList "/i $url /qn" -NoNewWindow -Wait
            Write-Host "$app has been installed successfully." -ForegroundColor Green
        }
        catch {
            Write-Error "Failed to install $app."
        }
    }
}

function InstallGCPW {
    $app = "Google Credential Provider for Windows"

    if ($arch -match '64-bit') {
        $url = "https://dl.google.com/tag/s/appguid=%7B32987697-A14E-4B89-84D6-630D5431E831%7D&needsadmin=true&appname=GCPW&etoken=$token/credentialprovider/gcpwstandaloneenterprise64.exe"
    } else {
        $url = "https://dl.google.com/tag/s/appguid=%7B32987697-A14E-4B89-84D6-630D5431E831%7D&needsadmin=true&appname=GCPW&etoken=$token/credentialprovider/gcpwstandaloneenterprise.exe"
    }

    Write-Host "Installing the $arch version of $app ..." -ForegroundColor Green
    # Path to save the downloaded .exe file in the temporary folder
    $tempDownloadPath = [System.IO.Path]::Combine([System.IO.Path]::GetTempPath(), "GCPW.exe")

    # Arguments to pass to the .exe when running it
    $arguments = "/silent /install"

    # Download the .exe file to the temporary folder
    Invoke-WebRequest -Uri $url -OutFile $tempDownloadPath

    try {
        Start-Process -FilePath $tempDownloadPath -ArgumentList $arguments -NoNewWindow -Wait
        Write-Host "$app has been installed successfully." -ForegroundColor Green
        SetAllowedDomains
    }
    catch {
        Write-Error "Failed to install $app."
    }
}

function SetAllowedDomains {
    <# Set the required registry key with the allowed domains #>
    $registryPath = 'HKEY_LOCAL_MACHINE\Software\Google\GCPW'
    $name = 'domains_allowed_to_login'
    [microsoft.win32.registry]::SetValue($registryPath, $name, $domainsAllowedToLogin)

    $domains = Get-ItemPropertyValue HKLM:\Software\Google\GCPW -Name $name

    if ($domains -eq $domainsAllowedToLogin) {
        Write-Host "Configuration completed successfully!" -ForegroundColor Green
    }
    else {
        Write-Error "Could not write to registry. Configuration was not completed."
    }
}

if ($null -eq $token -or $null -eq $domainsAllowedToLogin) {
    Write-Error "Token not found. Exiting."
    exit 1
} else {
    InstallGCPW
    InstallChromeBrowser
}