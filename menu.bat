@echo off
color 0B
title Customer Onboarding Workflow - Management Menu
mode con: cols=100 lines=30

:menu
cls
echo ===============================================================================
echo                    Customer Onboarding Workflow - Management Menu
echo ===============================================================================
echo.
echo  Application Management:
echo  -----------------------
echo  1. Run Application
echo  2. Build Release Package
echo  3. Create Release (with version tag)
echo  4. Install Dependencies
echo  5. Clean Project
echo.
echo  Git Repository Management:
echo  -------------------------
echo  6. Update from Repository
echo  7. Push Changes to Repository
echo  8. Create New Branch
echo.
echo  Documentation:
echo  -------------
echo  9. View README
echo  10. View User Guide
echo.
echo  0. Exit
echo.
echo ===============================================================================
echo.

set /p choice=Enter your choice (0-10): 

if "%choice%"=="1" goto run_app
if "%choice%"=="2" goto build_release
if "%choice%"=="3" goto create_release
if "%choice%"=="4" goto install_dependencies
if "%choice%"=="5" goto clean_project
if "%choice%"=="6" goto update_app
if "%choice%"=="7" goto push_changes
if "%choice%"=="8" goto create_branch
if "%choice%"=="9" goto view_readme
if "%choice%"=="10" goto view_userguide
if "%choice%"=="0" goto exit
goto menu

:run_app
cls
echo Running application...
call "%~dp0run-app.bat"
goto menu

:build_release
cls
echo Building release package...
call "%~dp0build-release.bat"
goto menu

:create_release
cls
echo Creating release...
call "%~dp0create-release.bat"
goto menu

:install_dependencies
cls
echo Installing dependencies...
call "%~dp0install-dependencies.bat"
goto menu

:clean_project
cls
echo Cleaning project...
call "%~dp0cleanup.bat"
goto menu

:update_app
cls
echo Updating from repository...
call "%~dp0update-app.bat"
goto menu

:push_changes
cls
echo Pushing changes to repository...
call "%~dp0push-changes.bat"
goto menu

:create_branch
cls
echo Creating new branch...
call "%~dp0create-branch.bat"
goto menu

:view_readme
cls
echo Viewing README...
type "%~dp0README.md" | more
echo.
pause
goto menu

:view_userguide
cls
echo Viewing User Guide...
type "%~dp0UserGuide.md" | more
echo.
pause
goto menu

:exit
cls
echo Thank you for using Customer Onboarding Workflow Management Menu.
echo.
echo Exiting...
timeout /t 2 >nul
exit
