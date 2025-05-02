# Customer Onboarding Workflow Application

A comprehensive Windows Forms application for efficiently and consistently onboarding customers after receiving their signed contracts.

## Features

- **Customer Information Management**: Capture and store customer details including company name, address, contact information
- **Service-Specific Forms**:
  - **Office365**: Track existing licenses, credentials, migration requirements
  - **Network Monitoring**: Document access methods, discovery results, vulnerability assessments
  - **Server Management**: Inventory servers, configure monitoring, document security assessments
  - **SaaS/Cloud Monitoring**: Track applications, cloud services, configure monitoring and alerting
  - **Hosting**: Manage website/database details, DNS, SSL, backup and monitoring configurations
- **Reporting**: Generate comprehensive onboarding reports with export capabilities

## Requirements

- Windows 10 or later
- .NET 6.0 SDK or later
- Visual Studio 2022 or later (for development)

## Installation

### Option 1: Using the Installer

1. Download the latest release from the `Releases` folder
2. Run the installer (`CustomerOnboardingWorkflow-Setup.exe`)
3. Follow the installation wizard instructions

### Option 2: Building from Source

1. Clone this repository
2. Open the solution in Visual Studio
3. Build the solution (Build > Build Solution or F6)
4. Run the application (Debug > Start Debugging or F5)

## Usage

1. Launch the application
2. From the main dashboard, click "New Customer" to begin the onboarding process
3. Fill in the customer's basic information
4. Select the services included in the customer's contract
5. Complete the service-specific forms for each selected service
6. Generate and save the onboarding report
7. Access customer records from the dashboard for future reference or updates

## Building the Release Package

To build a release package for distribution:

1. Open a command prompt in the project root directory
2. Run `build-release.bat`
3. The packaged application will be created in the `Releases` folder

## Source Code Repository

The source code for this application is hosted on GitHub:
https://github.com/cloudscale365-inc/msp

### Getting the Latest Code

To get the latest code from the repository:

1. Open a command prompt in the project root directory
2. Run `update-app.bat`
3. Follow the prompts to update the application

## Data Storage

Customer data is stored locally in a SQLite database in the application's data directory:
- `%APPDATA%\CustomerOnboardingWorkflow\data.db`

## Support

For support, please contact the IT department.
