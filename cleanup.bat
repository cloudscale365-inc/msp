@echo off
echo Customer Onboarding Workflow - Cleanup Tool
echo =========================================
echo.

:: Set variables
set SOLUTION_DIR=%~dp0
set PROJECT_DIR=%SOLUTION_DIR%CustomerOnboardingWorkflow

:: Confirm cleanup
echo This will remove all temporary files, build artifacts, and bin/obj directories.
echo Your source code will not be affected.
echo.
choice /C YN /M "Do you want to continue"
if %ERRORLEVEL% NEQ 1 (
    echo Cleanup cancelled.
    pause
    exit /b 0
)

echo.
echo Cleaning up project...

:: Remove bin and obj directories
echo Removing build artifacts...
if exist "%PROJECT_DIR%\bin" rmdir /S /Q "%PROJECT_DIR%\bin"
if exist "%PROJECT_DIR%\obj" rmdir /S /Q "%PROJECT_DIR%\obj"

:: Remove NuGet packages
echo Removing NuGet packages...
if exist "%SOLUTION_DIR%packages" rmdir /S /Q "%SOLUTION_DIR%packages"

:: Remove Visual Studio temporary files
echo Removing Visual Studio temporary files...
if exist "%SOLUTION_DIR%.vs" rmdir /S /Q "%SOLUTION_DIR%.vs"
del /F /Q "%SOLUTION_DIR%*.suo" 2>nul
del /F /Q "%SOLUTION_DIR%*.user" 2>nul
del /F /Q "%SOLUTION_DIR%*.cache" 2>nul

:: Remove Releases directory (optional)
echo.
choice /C YN /M "Do you also want to remove the Releases directory"
if %ERRORLEVEL% EQU 1 (
    if exist "%SOLUTION_DIR%Releases" rmdir /S /Q "%SOLUTION_DIR%Releases"
    echo Releases directory removed.
)

:: Remove Backup directories (optional)
echo.
choice /C YN /M "Do you also want to remove all Backup directories"
if %ERRORLEVEL% EQU 1 (
    for /d %%D in ("%SOLUTION_DIR%Backup_*") do rmdir /S /Q "%%D"
    echo Backup directories removed.
)

:: Clean up complete
echo.
echo Cleanup completed successfully!
echo.
echo Would you like to restore NuGet packages now?
choice /C YN /M "Restore NuGet packages"
if %ERRORLEVEL% EQU 1 (
    echo Restoring NuGet packages...
    dotnet restore "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj"
    echo NuGet packages restored.
)

echo.
pause
