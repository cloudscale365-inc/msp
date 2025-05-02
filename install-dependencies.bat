@echo off
echo Customer Onboarding Workflow - Dependency Installer Launcher
echo =========================================================
echo.

:: Check for administrative privileges
net session >nul 2>&1
if %errorLevel% neq 0 (
    echo This script requires administrator privileges.
    echo Right-click on this file and select "Run as administrator".
    echo.
    pause
    exit /b 1
)

:: Run the PowerShell script
echo Running dependency installer...
echo.
PowerShell -NoProfile -ExecutionPolicy Bypass -File "%~dp0install-dependencies.ps1"

:: Exit
exit /b 0
