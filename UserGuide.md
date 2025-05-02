# Customer Onboarding Workflow - User Guide

## Introduction

The Customer Onboarding Workflow application is designed to streamline the process of onboarding new customers after receiving their signed contracts. This guide will walk you through the various features and functions of the application.

## Getting Started

### Installation

1. Obtain the installer from the IT department or from the shared network drive
2. Run the installer (`CustomerOnboardingWorkflow-Setup.exe`)
3. Follow the installation wizard instructions
4. Launch the application from the Start menu or desktop shortcut

### Main Dashboard

The main dashboard is the central hub of the application. From here, you can:

- View existing customers
- Add new customers
- Search for specific customers
- Access reports and analytics

## Onboarding a New Customer

### Step 1: Create a New Customer Record

1. Click the "New Customer" button on the dashboard
2. Enter the customer's basic information:
   - Company name
   - Primary address
   - Point of contact (name, email, phone)
   - Contract details (number, sign date, start/end dates)
3. Click "Next" to proceed

### Step 2: Select Services

1. Check the boxes for each service included in the customer's contract:
   - Office 365
   - Network Monitoring
   - Server Management
   - SaaS/Cloud Monitoring
   - Hosting
2. Click "Next" to proceed

### Step 3: Complete Service-Specific Forms

For each selected service, you'll need to complete a dedicated form:

#### Office 365 Form

- Indicate if the customer has existing licenses
- Enter the number of licenses and license type
- Specify the domain
- Note if credentials have been provided
- Indicate if migration is required and provide migration details

#### Network Monitoring Form

- Confirm if access has been granted and specify the access method
- Document discovery completion and results
- Record vulnerability scan results
- Document monitoring tools installation
- Configure alerting settings
- Note documentation location

#### Server Management Form

- Confirm access details
- Complete server inventory (physical, virtual, cloud)
- Document monitoring agent installation
- Configure backup settings
- Set up patch management
- Record security assessment results
- Document server information

#### SaaS/Cloud Monitoring Form

- Complete inventory of SaaS applications
- Document cloud services
- Configure monitoring settings
- Set up alerting
- Record security assessment details
- Document service information

#### Hosting Form

- Specify hosting type and provider
- Document websites and databases
- Configure email hosting if applicable
- Record DNS and SSL details
- Set up backup and monitoring
- Document hosting information

### Step 4: Generate and Save Report

1. After completing all required forms, click "Generate Report"
2. Review the onboarding report for accuracy
3. Click "Export" to save the report as a PDF or text file
4. Click "Save" to finalize the customer onboarding

## Managing Existing Customers

### Viewing Customer Details

1. From the dashboard, select a customer from the list
2. Click "View Details" to see the customer's information
3. Navigate through the tabs to view different aspects of the customer's setup

### Updating Customer Information

1. From the customer details view, click "Edit"
2. Make the necessary changes to the customer's information
3. Click "Save" to update the record

### Generating Reports

1. From the dashboard, click "Reports"
2. Select the type of report you want to generate
3. Choose the customers to include in the report
4. Click "Generate" to create the report
5. Export or print the report as needed

## Tips and Best Practices

- Complete each form thoroughly to ensure all necessary information is captured
- Use the notes fields to document any special considerations or requirements
- Regularly update customer information as changes occur
- Generate reports before team meetings to provide up-to-date information
- Use the search function to quickly find specific customers

## Troubleshooting

### Common Issues

- **Application won't start**: Ensure you have the correct .NET runtime installed
- **Can't save customer data**: Check your permissions on the data directory
- **Report generation fails**: Verify that all required fields are completed

### Getting Help

If you encounter issues not covered in this guide, please contact the IT department for assistance.

## Data Backup and Recovery

The application automatically backs up the database daily. If you need to recover data:

1. Contact the IT department
2. Provide the date of the data you need to recover
3. Follow the instructions provided by IT

## Security Considerations

- Do not share your login credentials
- Lock your computer when away from your desk
- Do not export customer data to unsecured locations
- Report any security concerns to the IT department immediately
