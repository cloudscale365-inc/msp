@echo off
echo Building Customer Onboarding Workflow Application...

:: Set variables
set SOLUTION_DIR=%~dp0
set RELEASE_DIR=%SOLUTION_DIR%Releases
set PROJECT_DIR=%SOLUTION_DIR%CustomerOnboardingWorkflow
set OUTPUT_DIR=%PROJECT_DIR%\bin\Release\net6.0-windows
set INSTALLER_NAME=CustomerOnboardingWorkflow-Setup.exe

:: Create Releases directory if it doesn't exist
if not exist "%RELEASE_DIR%" mkdir "%RELEASE_DIR%"

:: Clean previous build
echo Cleaning previous build...
dotnet clean "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj" -c Release

:: Restore packages
echo Restoring packages...
dotnet restore "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj"

:: Build the solution in Release mode
echo Building solution in Release mode...
dotnet build "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj" -c Release --no-restore

:: Publish the application
echo Publishing application...
dotnet publish "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj" -c Release --no-build --self-contained true -r win-x64 -p:PublishSingleFile=true -o "%RELEASE_DIR%\App"

:: Copy README and other documentation
echo Copying documentation...
copy "%SOLUTION_DIR%README.md" "%RELEASE_DIR%\"

:: Create a simple installer using PowerShell
echo Creating installer...
powershell -Command "& {Add-Type -A 'System.IO.Compression.FileSystem'; [IO.Compression.ZipFile]::CreateFromDirectory('%RELEASE_DIR%\App', '%RELEASE_DIR%\CustomerOnboardingWorkflow.zip');}"

:: Create a self-extracting installer using 7-Zip (if available)
where 7z >nul 2>nul
if %ERRORLEVEL% EQU 0 (
    echo Creating self-extracting installer with 7-Zip...
    7z a -sfx7z.sfx "%RELEASE_DIR%\%INSTALLER_NAME%" "%RELEASE_DIR%\CustomerOnboardingWorkflow.zip"
    del "%RELEASE_DIR%\CustomerOnboardingWorkflow.zip"
) else (
    echo 7-Zip not found. Using ZIP file as the distribution package.
    echo To create a self-extracting installer, install 7-Zip and run this script again.
    ren "%RELEASE_DIR%\CustomerOnboardingWorkflow.zip" "%RELEASE_DIR%\CustomerOnboardingWorkflow-Install.zip"
)

echo.
echo Build completed successfully!
echo Release package is available in the Releases folder.
echo.

pause
