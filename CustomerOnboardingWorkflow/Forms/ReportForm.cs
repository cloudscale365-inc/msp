using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerOnboardingWorkflow.Models;

namespace CustomerOnboardingWorkflow
{
    public partial class ReportForm : Form
    {
        private Customer _customer;
        
        public ReportForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            // Generate and display the report
            GenerateReport();
        }
        
        private void GenerateReport()
        {
            StringBuilder report = new StringBuilder();
            
            // Add customer information
            report.AppendLine("CUSTOMER ONBOARDING REPORT");
            report.AppendLine("=========================");
            report.AppendLine();
            report.AppendLine($"Company: {_customer.CompanyName}");
            report.AppendLine($"Primary Address: {_customer.PrimaryAddress}");
            report.AppendLine($"Contact: {_customer.ContactName}");
            report.AppendLine($"Email: {_customer.ContactEmail}");
            report.AppendLine($"Phone: {_customer.ContactPhone}");
            report.AppendLine();
            report.AppendLine($"Contract Number: {_customer.ContractNumber}");
            report.AppendLine($"Contract Sign Date: {_customer.ContractSignDate.ToShortDateString()}");
            report.AppendLine($"Contract Period: {_customer.ContractStartDate.ToShortDateString()} to {_customer.ContractEndDate.ToShortDateString()}");
            report.AppendLine();
            report.AppendLine("SERVICES OVERVIEW");
            report.AppendLine("----------------");
            
            // Add service information
            if (_customer.HasOffice365Services)
            {
                report.AppendLine("Office 365: YES");
                if (_customer.Office365Information != null)
                {
                    report.AppendLine($"  - Existing Licenses: {(_customer.Office365Information.HasExistingLicenses ? "Yes" : "No")}");
                    report.AppendLine($"  - Number of Licenses: {_customer.Office365Information.NumberOfLicenses}");
                    report.AppendLine($"  - License Type: {_customer.Office365Information.LicenseType}");
                    report.AppendLine($"  - Domain: {_customer.Office365Information.Domain}");
                    report.AppendLine($"  - Credentials Provided: {(_customer.Office365Information.HasProvidedCredentials ? "Yes" : "No")}");
                    report.AppendLine($"  - Requires Migration: {(_customer.Office365Information.RequiresMigration ? "Yes" : "No")}");
                    if (_customer.Office365Information.RequiresMigration)
                    {
                        report.AppendLine($"  - Migration Source: {_customer.Office365Information.MigrationSource}");
                        if (_customer.Office365Information.ScheduledMigrationDate.HasValue)
                        {
                            report.AppendLine($"  - Migration Date: {_customer.Office365Information.ScheduledMigrationDate.Value.ToShortDateString()}");
                        }
                    }
                    report.AppendLine($"  - Setup Complete: {(_customer.Office365Information.SetupComplete ? "Yes" : "No")}");
                }
                report.AppendLine();
            }
            else
            {
                report.AppendLine("Office 365: NO");
                report.AppendLine();
            }
            
            if (_customer.HasNetworkMonitoring)
            {
                report.AppendLine("Network Monitoring: YES");
                if (_customer.NetworkMonitoringInformation != null)
                {
                    report.AppendLine($"  - Access Granted: {(_customer.NetworkMonitoringInformation.AccessGranted ? "Yes" : "No")}");
                    report.AppendLine($"  - Access Method: {_customer.NetworkMonitoringInformation.AccessMethod}");
                    report.AppendLine($"  - Discovery Completed: {(_customer.NetworkMonitoringInformation.DiscoveryCompleted ? "Yes" : "No")}");
                    if (_customer.NetworkMonitoringInformation.DiscoveryCompleted)
                    {
                        report.AppendLine($"  - Discovery Date: {(_customer.NetworkMonitoringInformation.DiscoveryDate.HasValue ? _customer.NetworkMonitoringInformation.DiscoveryDate.Value.ToShortDateString() : "N/A")}");
                        report.AppendLine($"  - Total Devices: {_customer.NetworkMonitoringInformation.TotalDevicesDiscovered}");
                    }
                    report.AppendLine($"  - Vulnerability Scan Completed: {(_customer.NetworkMonitoringInformation.VulnerabilityScanCompleted ? "Yes" : "No")}");
                    if (_customer.NetworkMonitoringInformation.VulnerabilityScanCompleted)
                    {
                        report.AppendLine($"  - Critical Vulnerabilities: {_customer.NetworkMonitoringInformation.CriticalVulnerabilities}");
                        report.AppendLine($"  - High Vulnerabilities: {_customer.NetworkMonitoringInformation.HighVulnerabilities}");
                        report.AppendLine($"  - Medium Vulnerabilities: {_customer.NetworkMonitoringInformation.MediumVulnerabilities}");
                        report.AppendLine($"  - Low Vulnerabilities: {_customer.NetworkMonitoringInformation.LowVulnerabilities}");
                        report.AppendLine($"  - Vulnerabilities Reported: {(_customer.NetworkMonitoringInformation.VulnerabilitiesReported ? "Yes" : "No")}");
                    }
                    report.AppendLine($"  - Monitoring Tools Installed: {(_customer.NetworkMonitoringInformation.MonitoringToolsInstalled ? "Yes" : "No")}");
                    report.AppendLine($"  - Alerting Configured: {(_customer.NetworkMonitoringInformation.AlertingConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - Network Documented: {(_customer.NetworkMonitoringInformation.NetworkDocumented ? "Yes" : "No")}");
                }
                report.AppendLine();
            }
            else
            {
                report.AppendLine("Network Monitoring: NO");
                report.AppendLine();
            }
            
            if (_customer.HasServerManagement)
            {
                report.AppendLine("Server Management: YES");
                if (_customer.ServerManagementInformation != null)
                {
                    report.AppendLine($"  - Access Granted: {(_customer.ServerManagementInformation.AccessGranted ? "Yes" : "No")}");
                    report.AppendLine($"  - Access Method: {_customer.ServerManagementInformation.AccessMethod}");
                    report.AppendLine($"  - Inventory Complete: {(_customer.ServerManagementInformation.InventoryComplete ? "Yes" : "No")}");
                    report.AppendLine($"  - Total Servers: {_customer.ServerManagementInformation.TotalServers}");
                    report.AppendLine($"  - Monitoring Agents Installed: {(_customer.ServerManagementInformation.MonitoringAgentsInstalled ? "Yes" : "No")}");
                    report.AppendLine($"  - Backup Configured: {(_customer.ServerManagementInformation.BackupConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - Patch Management Configured: {(_customer.ServerManagementInformation.PatchManagementConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - Security Assessment Complete: {(_customer.ServerManagementInformation.SecurityAssessmentComplete ? "Yes" : "No")}");
                    report.AppendLine($"  - Servers Documented: {(_customer.ServerManagementInformation.ServersDocumented ? "Yes" : "No")}");
                }
                report.AppendLine();
            }
            else
            {
                report.AppendLine("Server Management: NO");
                report.AppendLine();
            }
            
            if (_customer.HasSaasCloudMonitoring)
            {
                report.AppendLine("SaaS/Cloud Monitoring: YES");
                if (_customer.SaasCloudMonitoringInformation != null)
                {
                    report.AppendLine($"  - SaaS Inventory Complete: {(_customer.SaasCloudMonitoringInformation.InventoryComplete ? "Yes" : "No")}");
                    report.AppendLine($"  - Total SaaS Applications: {_customer.SaasCloudMonitoringInformation.TotalSaasApplications}");
                    report.AppendLine($"  - Cloud Inventory Complete: {(_customer.SaasCloudMonitoringInformation.CloudInventoryComplete ? "Yes" : "No")}");
                    report.AppendLine($"  - Total Cloud Services: {_customer.SaasCloudMonitoringInformation.TotalCloudServices}");
                    report.AppendLine($"  - Monitoring Configured: {(_customer.SaasCloudMonitoringInformation.MonitoringConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - Alerting Configured: {(_customer.SaasCloudMonitoringInformation.AlertingConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - Security Assessment Complete: {(_customer.SaasCloudMonitoringInformation.SecurityAssessmentComplete ? "Yes" : "No")}");
                    report.AppendLine($"  - Services Documented: {(_customer.SaasCloudMonitoringInformation.ServicesDocumented ? "Yes" : "No")}");
                }
                report.AppendLine();
            }
            else
            {
                report.AppendLine("SaaS/Cloud Monitoring: NO");
                report.AppendLine();
            }
            
            if (_customer.HasHosting)
            {
                report.AppendLine("Hosting: YES");
                if (_customer.HostingInformation != null)
                {
                    report.AppendLine($"  - Hosting Type: {_customer.HostingInformation.HostingType}");
                    report.AppendLine($"  - Provider: {_customer.HostingInformation.Provider}");
                    report.AppendLine($"  - New Hosting: {(_customer.HostingInformation.IsNewHosting ? "Yes" : "No")}");
                    report.AppendLine($"  - Total Websites: {_customer.HostingInformation.TotalWebsites}");
                    report.AppendLine($"  - Total Databases: {_customer.HostingInformation.TotalDatabases}");
                    report.AppendLine($"  - Includes Email Hosting: {(_customer.HostingInformation.IncludesEmailHosting ? "Yes" : "No")}");
                    report.AppendLine($"  - DNS Configured: {(_customer.HostingInformation.DnsConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - SSL Required: {(_customer.HostingInformation.SslRequired ? "Yes" : "No")}");
                    report.AppendLine($"  - Backup Configured: {(_customer.HostingInformation.BackupConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - Monitoring Configured: {(_customer.HostingInformation.MonitoringConfigured ? "Yes" : "No")}");
                    report.AppendLine($"  - Hosting Documented: {(_customer.HostingInformation.HostingDocumented ? "Yes" : "No")}");
                }
                report.AppendLine();
            }
            else
            {
                report.AppendLine("Hosting: NO");
                report.AppendLine();
            }
            
            // Add onboarding status
            report.AppendLine("ONBOARDING STATUS");
            report.AppendLine("----------------");
            report.AppendLine($"Status: {_customer.OnboardingStatus}");
            report.AppendLine($"Start Date: {_customer.OnboardingStartDate.ToShortDateString()}");
            if (_customer.OnboardingCompletionDate.HasValue)
            {
                report.AppendLine($"Completion Date: {_customer.OnboardingCompletionDate.Value.ToShortDateString()}");
            }
            else
            {
                report.AppendLine("Completion Date: Not completed");
            }
            
            // Display the report in the text box
            txtReport.Text = report.ToString();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // In a real application, this would print the report
            MessageBox.Show("Printing functionality would be implemented here.", "Print Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnExport_Click(object sender, EventArgs e)
        {
            // In a real application, this would export the report to a file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            saveFileDialog.Title = "Export Report";
            saveFileDialog.FileName = $"{_customer.CompanyName} - Onboarding Report.txt";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, txtReport.Text);
                    MessageBox.Show("Report exported successfully.", "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting report: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
