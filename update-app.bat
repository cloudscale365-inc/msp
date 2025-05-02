@echo off
echo Customer Onboarding Workflow - Update Tool
echo =========================================
echo.

:: Set variables
set REPO_URL=https://github.com/cloudscale365-inc/msp.git
set SOLUTION_DIR=%~dp0
set BACKUP_DIR=%SOLUTION_DIR%Backup_%date:~-4,4%%date:~-7,2%%date:~-10,2%_%time:~0,2%%time:~3,2%%time:~6,2%
set BACKUP_DIR=%BACKUP_DIR: =0%

:: Check if git is installed
where git >nul 2>nul
if %ERRORLEVEL% NEQ 0 (
    echo Error: Git is not installed.
    echo Please install Git from https://git-scm.com/downloads
    pause
    exit /b 1
)

:: Check if the directory is a git repository
if not exist "%SOLUTION_DIR%.git" (
    echo This directory is not a Git repository.
    echo Would you like to initialize it as a Git repository and pull the latest code?
    choice /C YN /M "Initialize Git repository"
    if %ERRORLEVEL% EQU 1 (
        echo Initializing Git repository...
        git init
        git remote add origin %REPO_URL%
        echo Repository initialized.
    ) else (
        echo Update cancelled.
        pause
        exit /b 0
    )
)

:: Create a backup of the current code
echo Creating backup of current code...
mkdir "%BACKUP_DIR%"
xcopy "%SOLUTION_DIR%*" "%BACKUP_DIR%" /E /H /C /I /Y >nul
echo Backup created at %BACKUP_DIR%

:: Pull the latest code
echo Pulling latest code from repository...
git pull origin main

:: Check if the pull was successful
if %ERRORLEVEL% NEQ 0 (
    echo Error: Failed to pull latest code.
    echo You may have local changes that conflict with the repository.
    echo Your code has been backed up to %BACKUP_DIR%
    echo Please resolve the conflicts manually.
    pause
    exit /b 1
)

:: Restore NuGet packages
echo Restoring NuGet packages...
dotnet restore "%SOLUTION_DIR%CustomerOnboardingWorkflow\CustomerOnboardingWorkflow.csproj"

echo.
echo Update completed successfully!
echo Your previous code has been backed up to %BACKUP_DIR%
echo.
echo Would you like to run the application now?
choice /C YN /M "Run application"
if %ERRORLEVEL% EQU 1 (
    call "%SOLUTION_DIR%run-app.bat"
)

pause
