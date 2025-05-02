@echo off
echo Customer Onboarding Workflow - Push Changes Tool
echo =============================================
echo.

:: Set variables
set REPO_URL=https://github.com/cloudscale365-inc/msp.git
set SOLUTION_DIR=%~dp0

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
    echo Would you like to initialize it as a Git repository?
    choice /C YN /M "Initialize Git repository"
    if %ERRORLEVEL% EQU 1 (
        echo Initializing Git repository...
        git init
        git remote add origin %REPO_URL%
        echo Repository initialized.
    ) else (
        echo Push cancelled.
        pause
        exit /b 0
    )
)

:: Check for changes
echo Checking for changes...
git status
echo.

:: Ask for commit message
set /p COMMIT_MESSAGE=Enter commit message (or press Enter to cancel): 
if "%COMMIT_MESSAGE%"=="" (
    echo Push cancelled.
    pause
    exit /b 0
)

:: Add all changes
echo Adding all changes...
git add .

:: Commit changes
echo Committing changes...
git commit -m "%COMMIT_MESSAGE%"

:: Push changes
echo.
echo Would you like to push your changes to the repository?
echo Note: This requires proper access rights to the repository.
choice /C YN /M "Push changes"
if %ERRORLEVEL% EQU 1 (
    echo Pushing changes to repository...
    git push origin main
    
    :: Check if the push was successful
    if %ERRORLEVEL% NEQ 0 (
        echo.
        echo Error: Failed to push changes to the repository.
        echo This could be due to:
        echo - Lack of access rights to the repository
        echo - Network issues
        echo - Conflicts with remote changes
        echo.
        echo Try pulling the latest changes first with update-app.bat
        pause
        exit /b 1
    )
    
    echo.
    echo Changes pushed successfully!
) else (
    echo.
    echo Changes committed locally but not pushed to the repository.
    echo You can push them later by running this script again.
)

pause
