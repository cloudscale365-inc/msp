# Customer Onboarding Workflow - Dependency Installer
# This script checks for and installs the necessary dependencies for the application

# Ensure script is running with administrator privileges
if (-NOT ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")) {
    Write-Warning "This script requires administrator privileges. Please run as administrator."
    Start-Sleep -Seconds 3
    exit
}

Write-Host "Customer Onboarding Workflow - Dependency Installer" -ForegroundColor Cyan
Write-Host "======================================================" -ForegroundColor Cyan
Write-Host ""

# Function to check if a command exists
function Test-CommandExists {
    param ($command)
    $oldPreference = $ErrorActionPreference
    $ErrorActionPreference = 'stop'
    try {
        if (Get-Command $command) { return $true }
    } catch {
        return $false
    } finally {
        $ErrorActionPreference = $oldPreference
    }
}

# Check for .NET SDK
Write-Host "Checking for .NET SDK..." -ForegroundColor Yellow
$dotnetInstalled = Test-CommandExists dotnet
if ($dotnetInstalled) {
    $dotnetVersion = (dotnet --version)
    Write-Host ".NET SDK version $dotnetVersion is installed." -ForegroundColor Green
    
    # Check if the version is 6.0 or higher
    $versionParts = $dotnetVersion.Split('.')
    $majorVersion = [int]$versionParts[0]
    if ($majorVersion -lt 6) {
        Write-Host "Warning: This application requires .NET 6.0 or higher." -ForegroundColor Yellow
        $installDotNet = Read-Host "Would you like to install .NET 6.0? (Y/N)"
        if ($installDotNet -eq "Y" -or $installDotNet -eq "y") {
            Write-Host "Installing .NET 6.0..." -ForegroundColor Yellow
            # Download and install .NET 6.0
            $dotnetUrl = "https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.100-windows-x64-installer"
            Start-Process $dotnetUrl
            Write-Host "Please follow the instructions in the browser to download and install .NET 6.0." -ForegroundColor Yellow
            Write-Host "After installation, please restart this script." -ForegroundColor Yellow
            Start-Sleep -Seconds 5
            exit
        }
    }
} else {
    Write-Host ".NET SDK is not installed." -ForegroundColor Red
    $installDotNet = Read-Host "Would you like to install .NET 6.0? (Y/N)"
    if ($installDotNet -eq "Y" -or $installDotNet -eq "y") {
        Write-Host "Installing .NET 6.0..." -ForegroundColor Yellow
        # Download and install .NET 6.0
        $dotnetUrl = "https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-6.0.100-windows-x64-installer"
        Start-Process $dotnetUrl
        Write-Host "Please follow the instructions in the browser to download and install .NET 6.0." -ForegroundColor Yellow
        Write-Host "After installation, please restart this script." -ForegroundColor Yellow
        Start-Sleep -Seconds 5
        exit
    } else {
        Write-Host "Warning: The application will not run without .NET 6.0 or higher." -ForegroundColor Red
    }
}

# Check for SQLite
Write-Host "Checking for SQLite..." -ForegroundColor Yellow
$sqliteInstalled = Test-Path "C:\Program Files\SQLite"
if ($sqliteInstalled) {
    Write-Host "SQLite is installed." -ForegroundColor Green
} else {
    Write-Host "SQLite is not installed." -ForegroundColor Yellow
    Write-Host "SQLite will be installed as a NuGet package when the application is built." -ForegroundColor Yellow
}

# Check for 7-Zip (optional, used for creating self-extracting installers)
Write-Host "Checking for 7-Zip (optional)..." -ForegroundColor Yellow
$7zipInstalled = Test-CommandExists 7z
if ($7zipInstalled) {
    Write-Host "7-Zip is installed." -ForegroundColor Green
} else {
    Write-Host "7-Zip is not installed." -ForegroundColor Yellow
    $install7Zip = Read-Host "Would you like to install 7-Zip? It's used for creating self-extracting installers. (Y/N)"
    if ($install7Zip -eq "Y" -or $install7Zip -eq "y") {
        Write-Host "Installing 7-Zip..." -ForegroundColor Yellow
        # Check if Chocolatey is installed
        $chocoInstalled = Test-CommandExists choco
        if ($chocoInstalled) {
            # Install 7-Zip using Chocolatey
            choco install 7zip -y
        } else {
            # Download and install 7-Zip manually
            $7zipUrl = "https://www.7-zip.org/a/7z1900-x64.exe"
            $7zipInstaller = "$env:TEMP\7z1900-x64.exe"
            Invoke-WebRequest -Uri $7zipUrl -OutFile $7zipInstaller
            Start-Process -FilePath $7zipInstaller -ArgumentList "/S" -Wait
            Remove-Item $7zipInstaller
        }
        Write-Host "7-Zip has been installed." -ForegroundColor Green
    }
}

# Summary
Write-Host ""
Write-Host "Dependency Check Summary:" -ForegroundColor Cyan
Write-Host "------------------------" -ForegroundColor Cyan
if ($dotnetInstalled) {
    Write-Host "✓ .NET SDK: Installed (version $dotnetVersion)" -ForegroundColor Green
} else {
    Write-Host "✗ .NET SDK: Not installed" -ForegroundColor Red
}

if ($sqliteInstalled) {
    Write-Host "✓ SQLite: Installed" -ForegroundColor Green
} else {
    Write-Host "~ SQLite: Will be installed with NuGet" -ForegroundColor Yellow
}

if ($7zipInstalled) {
    Write-Host "✓ 7-Zip: Installed (optional)" -ForegroundColor Green
} else {
    Write-Host "~ 7-Zip: Not installed (optional)" -ForegroundColor Yellow
}

Write-Host ""
if ($dotnetInstalled) {
    Write-Host "All required dependencies are installed. You can now build and run the application." -ForegroundColor Green
    Write-Host "Use 'run-app.bat' to run the application or 'build-release.bat' to create a distributable package." -ForegroundColor Green
} else {
    Write-Host "Some required dependencies are missing. Please install them before running the application." -ForegroundColor Red
}

Write-Host ""
Read-Host "Press Enter to exit"
