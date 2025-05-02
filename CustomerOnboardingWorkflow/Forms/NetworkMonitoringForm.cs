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
    public partial class NetworkMonitoringForm : Form
    {
        private Customer _customer;
        
        public NetworkMonitoringForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            // Load the customer's network monitoring information if it exists
            if (_customer.NetworkMonitoringInformation != null)
            {
                LoadNetworkMonitoringData();
            }
        }
        
        private void LoadNetworkMonitoringData()
        {
            // Populate the form fields with the customer's network monitoring data
            chkAccessGranted.Checked = _customer.NetworkMonitoringInformation.AccessGranted;
            cboAccessMethod.Text = _customer.NetworkMonitoringInformation.AccessMethod;
            txtVpnCredentials.Text = _customer.NetworkMonitoringInformation.VpnCredentials;
            chkDiscoveryCompleted.Checked = _customer.NetworkMonitoringInformation.DiscoveryCompleted;
            
            if (_customer.NetworkMonitoringInformation.DiscoveryDate.HasValue)
            {
                dtpDiscoveryDate.Value = _customer.NetworkMonitoringInformation.DiscoveryDate.Value;
            }
            
            // Load device count
            nudTotalDevices.Value = _customer.NetworkMonitoringInformation.TotalDevicesDiscovered;
            
            // Load vulnerability information
            chkVulnerabilityScanCompleted.Checked = _customer.NetworkMonitoringInformation.VulnerabilityScanCompleted;
            nudCriticalVulnerabilities.Value = _customer.NetworkMonitoringInformation.CriticalVulnerabilities;
            nudHighVulnerabilities.Value = _customer.NetworkMonitoringInformation.HighVulnerabilities;
            nudMediumVulnerabilities.Value = _customer.NetworkMonitoringInformation.MediumVulnerabilities;
            nudLowVulnerabilities.Value = _customer.NetworkMonitoringInformation.LowVulnerabilities;
            chkVulnerabilitiesReported.Checked = _customer.NetworkMonitoringInformation.VulnerabilitiesReported;
            
            if (_customer.NetworkMonitoringInformation.VulnerabilityReportDate.HasValue)
            {
                dtpVulnerabilityReportDate.Value = _customer.NetworkMonitoringInformation.VulnerabilityReportDate.Value;
            }
            
            // Load monitoring setup information
            chkMonitoringToolsInstalled.Checked = _customer.NetworkMonitoringInformation.MonitoringToolsInstalled;
            txtMonitoringToolsNotes.Text = _customer.NetworkMonitoringInformation.MonitoringToolsNotes;
            
            // Load monitored services
            lstMonitoredServices.Items.Clear();
            foreach (string service in _customer.NetworkMonitoringInformation.MonitoredServices)
            {
                lstMonitoredServices.Items.Add(service);
            }
            
            chkAlertingConfigured.Checked = _customer.NetworkMonitoringInformation.AlertingConfigured;
            
            // Load alert recipients
            lstAlertRecipients.Items.Clear();
            foreach (string recipient in _customer.NetworkMonitoringInformation.AlertRecipients)
            {
                lstAlertRecipients.Items.Add(recipient);
            }
            
            // Load documentation information
            chkNetworkDocumented.Checked = _customer.NetworkMonitoringInformation.NetworkDocumented;
            txtDocumentationLocation.Text = _customer.NetworkMonitoringInformation.DocumentationLocation;
            txtAdditionalNotes.Text = _customer.NetworkMonitoringInformation.AdditionalNotes;
            
            // Update UI based on loaded data
            UpdateUI();
        }
        
        private void UpdateUI()
        {
            // Enable/disable controls based on checkbox states
            pnlAccess.Enabled = chkAccessGranted.Checked;
            pnlDiscovery.Enabled = chkDiscoveryCompleted.Checked;
            pnlVulnerabilities.Enabled = chkVulnerabilityScanCompleted.Checked;
            pnlVulnerabilityReport.Enabled = chkVulnerabilitiesReported.Checked;
            pnlMonitoring.Enabled = chkMonitoringToolsInstalled.Checked;
            pnlAlerting.Enabled = chkAlertingConfigured.Checked;
            pnlDocumentation.Enabled = chkNetworkDocumented.Checked;
        }
        
        private void chkAccessGranted_CheckedChanged(object sender, EventArgs e)
        {
            pnlAccess.Enabled = chkAccessGranted.Checked;
        }
        
        private void chkDiscoveryCompleted_CheckedChanged(object sender, EventArgs e)
        {
            pnlDiscovery.Enabled = chkDiscoveryCompleted.Checked;
        }
        
        private void chkVulnerabilityScanCompleted_CheckedChanged(object sender, EventArgs e)
        {
            pnlVulnerabilities.Enabled = chkVulnerabilityScanCompleted.Checked;
        }
        
        private void chkVulnerabilitiesReported_CheckedChanged(object sender, EventArgs e)
        {
            pnlVulnerabilityReport.Enabled = chkVulnerabilitiesReported.Checked;
        }
        
        private void chkMonitoringToolsInstalled_CheckedChanged(object sender, EventArgs e)
        {
            pnlMonitoring.Enabled = chkMonitoringToolsInstalled.Checked;
        }
        
        private void chkAlertingConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlAlerting.Enabled = chkAlertingConfigured.Checked;
        }
        
        private void chkNetworkDocumented_CheckedChanged(object sender, EventArgs e)
        {
            pnlDocumentation.Enabled = chkNetworkDocumented.Checked;
        }
        
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMonitoredService.Text))
            {
                lstMonitoredServices.Items.Add(txtMonitoredService.Text);
                txtMonitoredService.Clear();
                txtMonitoredService.Focus();
            }
        }
        
        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            if (lstMonitoredServices.SelectedIndex >= 0)
            {
                lstMonitoredServices.Items.RemoveAt(lstMonitoredServices.SelectedIndex);
            }
        }
        
        private void btnAddRecipient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAlertRecipient.Text))
            {
                lstAlertRecipients.Items.Add(txtAlertRecipient.Text);
                txtAlertRecipient.Clear();
                txtAlertRecipient.Focus();
            }
        }
        
        private void btnRemoveRecipient_Click(object sender, EventArgs e)
        {
            if (lstAlertRecipients.SelectedIndex >= 0)
            {
                lstAlertRecipients.Items.RemoveAt(lstAlertRecipients.SelectedIndex);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new NetworkMonitoringInfo object if it doesn't exist
            if (_customer.NetworkMonitoringInformation == null)
            {
                _customer.NetworkMonitoringInformation = new NetworkMonitoringInfo();
            }
            
            // Save the network monitoring information
            _customer.NetworkMonitoringInformation.AccessGranted = chkAccessGranted.Checked;
            _customer.NetworkMonitoringInformation.AccessMethod = cboAccessMethod.Text;
            _customer.NetworkMonitoringInformation.VpnCredentials = txtVpnCredentials.Text;
            _customer.NetworkMonitoringInformation.DiscoveryCompleted = chkDiscoveryCompleted.Checked;
            _customer.NetworkMonitoringInformation.DiscoveryDate = chkDiscoveryCompleted.Checked ? 
                dtpDiscoveryDate.Value : (DateTime?)null;
            
            // Save device count
            _customer.NetworkMonitoringInformation.TotalDevicesDiscovered = (int)nudTotalDevices.Value;
            
            // Save vulnerability information
            _customer.NetworkMonitoringInformation.VulnerabilityScanCompleted = chkVulnerabilityScanCompleted.Checked;
            _customer.NetworkMonitoringInformation.CriticalVulnerabilities = (int)nudCriticalVulnerabilities.Value;
            _customer.NetworkMonitoringInformation.HighVulnerabilities = (int)nudHighVulnerabilities.Value;
            _customer.NetworkMonitoringInformation.MediumVulnerabilities = (int)nudMediumVulnerabilities.Value;
            _customer.NetworkMonitoringInformation.LowVulnerabilities = (int)nudLowVulnerabilities.Value;
            _customer.NetworkMonitoringInformation.VulnerabilitiesReported = chkVulnerabilitiesReported.Checked;
            _customer.NetworkMonitoringInformation.VulnerabilityReportDate = chkVulnerabilitiesReported.Checked ? 
                dtpVulnerabilityReportDate.Value : (DateTime?)null;
            
            // Save monitoring setup information
            _customer.NetworkMonitoringInformation.MonitoringToolsInstalled = chkMonitoringToolsInstalled.Checked;
            _customer.NetworkMonitoringInformation.MonitoringToolsNotes = txtMonitoringToolsNotes.Text;
            
            // Save monitored services
            _customer.NetworkMonitoringInformation.MonitoredServices.Clear();
            foreach (string service in lstMonitoredServices.Items)
            {
                _customer.NetworkMonitoringInformation.MonitoredServices.Add(service);
            }
            
            // Save alerting information
            _customer.NetworkMonitoringInformation.AlertingConfigured = chkAlertingConfigured.Checked;
            
            // Save alert recipients
            _customer.NetworkMonitoringInformation.AlertRecipients.Clear();
            foreach (string recipient in lstAlertRecipients.Items)
            {
                _customer.NetworkMonitoringInformation.AlertRecipients.Add(recipient);
            }
            
            // Save documentation information
            _customer.NetworkMonitoringInformation.NetworkDocumented = chkNetworkDocumented.Checked;
            _customer.NetworkMonitoringInformation.DocumentationLocation = txtDocumentationLocation.Text;
            _customer.NetworkMonitoringInformation.AdditionalNotes = txtAdditionalNotes.Text;
            
            // Close the form with a successful result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
