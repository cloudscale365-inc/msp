@echo off
echo Running Customer Onboarding Workflow Application...

:: Set variables
set SOLUTION_DIR=%~dp0
set PROJECT_DIR=%SOLUTION_DIR%CustomerOnboardingWorkflow

:: Check if the project exists
if not exist "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj" (
    echo Error: Project file not found.
    echo Please make sure you're running this script from the correct directory.
    pause
    exit /b 1
)

:: Check if dotnet is installed
where dotnet >nul 2>nul
if %ERRORLEVEL% NEQ 0 (
    echo Error: .NET SDK not found.
    echo Please install the .NET 6.0 SDK or later from https://dotnet.microsoft.com/download
    pause
    exit /b 1
)

:: Restore packages if needed
if not exist "%PROJECT_DIR%\bin" (
    echo Restoring packages...
    dotnet restore "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj"
)

:: Run the application
echo Starting the application...
dotnet run --project "%PROJECT_DIR%\CustomerOnboardingWorkflow.csproj"

:: If the application exits with an error, pause to show the error message
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo Application exited with an error.
    pause
)
