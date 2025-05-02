@echo off
echo Customer Onboarding Workflow - Create Branch Tool
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
        echo Branch creation cancelled.
        pause
        exit /b 0
    )
)

:: Ask for branch name
set /p BRANCH_NAME=Enter branch name (or press Enter to cancel): 
if "%BRANCH_NAME%"=="" (
    echo Branch creation cancelled.
    pause
    exit /b 0
)

:: Check if branch already exists
git show-ref --verify --quiet refs/heads/%BRANCH_NAME%
if %ERRORLEVEL% EQU 0 (
    echo.
    echo Branch '%BRANCH_NAME%' already exists.
    echo Would you like to switch to this branch?
    choice /C YN /M "Switch to existing branch"
    if %ERRORLEVEL% EQU 1 (
        echo Switching to branch '%BRANCH_NAME%'...
        git checkout %BRANCH_NAME%
        echo Switched to branch '%BRANCH_NAME%'.
        pause
        exit /b 0
    ) else (
        echo Branch creation cancelled.
        pause
        exit /b 0
    )
)

:: Create and switch to new branch
echo Creating and switching to branch '%BRANCH_NAME%'...
git checkout -b %BRANCH_NAME%

:: Check if branch creation was successful
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo Error: Failed to create branch '%BRANCH_NAME%'.
    pause
    exit /b 1
)

echo.
echo Branch '%BRANCH_NAME%' created successfully!
echo You are now working on branch '%BRANCH_NAME%'.
echo.

:: Ask if user wants to push the branch to remote
echo Would you like to push this branch to the remote repository?
echo Note: This requires proper access rights to the repository.
choice /C YN /M "Push branch to remote"
if %ERRORLEVEL% EQU 1 (
    echo Pushing branch '%BRANCH_NAME%' to remote repository...
    git push -u origin %BRANCH_NAME%
    
    :: Check if the push was successful
    if %ERRORLEVEL% NEQ 0 (
        echo.
        echo Error: Failed to push branch to the repository.
        echo This could be due to:
        echo - Lack of access rights to the repository
        echo - Network issues
        echo.
        echo The branch has been created locally but not pushed to the repository.
        echo You can push it later by running: git push -u origin %BRANCH_NAME%
        pause
        exit /b 1
    )
    
    echo.
    echo Branch '%BRANCH_NAME%' pushed to remote repository successfully!
) else (
    echo.
    echo Branch '%BRANCH_NAME%' created locally but not pushed to the repository.
    echo You can push it later by running: git push -u origin %BRANCH_NAME%
)

pause
