@echo off
echo Customer Onboarding Workflow - Create Release Tool
echo =============================================
echo.

:: Set variables
set REPO_URL=https://github.com/cloudscale365-inc/msp.git
set SOLUTION_DIR=%~dp0
set RELEASE_DIR=%SOLUTION_DIR%Releases
set PROJECT_DIR=%SOLUTION_DIR%CustomerOnboardingWorkflow

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
    echo Error: This directory is not a Git repository.
    echo Please initialize it as a Git repository first using update-app.bat or push-changes.bat.
    pause
    exit /b 1
)

:: Check if there are uncommitted changes
git diff-index --quiet HEAD --
if %ERRORLEVEL% NEQ 0 (
    echo Warning: You have uncommitted changes.
    echo It's recommended to commit your changes before creating a release.
    echo.
    echo Would you like to commit your changes now?
    choice /C YN /M "Commit changes"
    if %ERRORLEVEL% EQU 1 (
        :: Ask for commit message
        set /p COMMIT_MESSAGE=Enter commit message (or press Enter to cancel): 
        if "%COMMIT_MESSAGE%"=="" (
            echo Release creation cancelled.
            pause
            exit /b 0
        )
        
        :: Add all changes
        echo Adding all changes...
        git add .
        
        :: Commit changes
        echo Committing changes...
        git commit -m "%COMMIT_MESSAGE%"
    ) else (
        echo Continuing without committing changes...
        echo.
    )
)

:: Ask for release version
set /p RELEASE_VERSION=Enter release version (e.g., 1.0.0) or press Enter to cancel: 
if "%RELEASE_VERSION%"=="" (
    echo Release creation cancelled.
    pause
    exit /b 0
)

:: Check if tag already exists
git show-ref --tags | findstr "refs/tags/v%RELEASE_VERSION%" >nul
if %ERRORLEVEL% EQU 0 (
    echo.
    echo Error: Tag 'v%RELEASE_VERSION%' already exists.
    echo Please choose a different version number.
    pause
    exit /b 1
)

:: Create Releases directory if it doesn't exist
if not exist "%RELEASE_DIR%" mkdir "%RELEASE_DIR%"

:: Create a release-specific directory
set RELEASE_VERSION_DIR=%RELEASE_DIR%\v%RELEASE_VERSION%
if not exist "%RELEASE_VERSION_DIR%" mkdir "%RELEASE_VERSION_DIR%"

:: Build the release
echo Building release v%RELEASE_VERSION%...
echo.

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
dotnet publish "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj" -c Release --no-build --self-contained true -r win-x64 -p:PublishSingleFile=true -o "%RELEASE_VERSION_DIR%\App"

:: Copy README and other documentation
echo Copying documentation...
copy "%SOLUTION_DIR%README.md" "%RELEASE_VERSION_DIR%\"
copy "%SOLUTION_DIR%UserGuide.md" "%RELEASE_VERSION_DIR%\"

:: Create a simple installer using PowerShell
echo Creating installer...
powershell -Command "& {Add-Type -A 'System.IO.Compression.FileSystem'; [IO.Compression.ZipFile]::CreateFromDirectory('%RELEASE_VERSION_DIR%\App', '%RELEASE_VERSION_DIR%\CustomerOnboardingWorkflow-v%RELEASE_VERSION%.zip');}"

:: Create a self-extracting installer using 7-Zip (if available)
where 7z >nul 2>nul
if %ERRORLEVEL% EQU 0 (
    echo Creating self-extracting installer with 7-Zip...
    7z a -sfx7z.sfx "%RELEASE_VERSION_DIR%\CustomerOnboardingWorkflow-v%RELEASE_VERSION%-Setup.exe" "%RELEASE_VERSION_DIR%\CustomerOnboardingWorkflow-v%RELEASE_VERSION%.zip"
    del "%RELEASE_VERSION_DIR%\CustomerOnboardingWorkflow-v%RELEASE_VERSION%.zip"
) else (
    echo 7-Zip not found. Using ZIP file as the distribution package.
    echo To create a self-extracting installer, install 7-Zip and run this script again.
    ren "%RELEASE_VERSION_DIR%\CustomerOnboardingWorkflow-v%RELEASE_VERSION%.zip" "%RELEASE_VERSION_DIR%\CustomerOnboardingWorkflow-v%RELEASE_VERSION%-Install.zip"
)

:: Create a tag in the repository
echo.
echo Would you like to create a tag for this release in the repository?
choice /C YN /M "Create tag"
if %ERRORLEVEL% EQU 1 (
    :: Ask for tag message
    set /p TAG_MESSAGE=Enter tag message (or press Enter to use default): 
    if "%TAG_MESSAGE%"=="" (
        set TAG_MESSAGE=Release v%RELEASE_VERSION%
    )
    
    :: Create tag
    echo Creating tag 'v%RELEASE_VERSION%'...
    git tag -a "v%RELEASE_VERSION%" -m "%TAG_MESSAGE%"
    
    :: Ask if user wants to push the tag to remote
    echo.
    echo Would you like to push this tag to the remote repository?
    echo Note: This requires proper access rights to the repository.
    choice /C YN /M "Push tag to remote"
    if %ERRORLEVEL% EQU 1 (
        echo Pushing tag 'v%RELEASE_VERSION%' to remote repository...
        git push origin "v%RELEASE_VERSION%"
        
        :: Check if the push was successful
        if %ERRORLEVEL% NEQ 0 (
            echo.
            echo Error: Failed to push tag to the repository.
            echo This could be due to:
            echo - Lack of access rights to the repository
            echo - Network issues
            echo.
            echo The tag has been created locally but not pushed to the repository.
            echo You can push it later by running: git push origin v%RELEASE_VERSION%
        ) else (
            echo.
            echo Tag 'v%RELEASE_VERSION%' pushed to remote repository successfully!
        )
    ) else (
        echo.
        echo Tag 'v%RELEASE_VERSION%' created locally but not pushed to the repository.
        echo You can push it later by running: git push origin v%RELEASE_VERSION%
    )
)

echo.
echo Release v%RELEASE_VERSION% created successfully!
echo Release package is available in the Releases\v%RELEASE_VERSION% folder.
echo.

pause
