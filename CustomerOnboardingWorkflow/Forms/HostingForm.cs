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
    public partial class HostingForm : Form
    {
        private Customer _customer;
        
        public HostingForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            // Load the customer's hosting information if it exists
            if (_customer.HostingInformation != null)
            {
                LoadHostingData();
            }
        }
        
        private void LoadHostingData()
        {
            // Populate the form fields with the customer's hosting data
            cboHostingType.Text = _customer.HostingInformation.HostingType;
            txtProvider.Text = _customer.HostingInformation.Provider;
            chkNewHosting.Checked = _customer.HostingInformation.IsNewHosting;
            
            // Load website and database counts
            nudTotalWebsites.Value = _customer.HostingInformation.TotalWebsites;
            nudTotalDatabases.Value = _customer.HostingInformation.TotalDatabases;
            
            // Load website information
            lstWebsites.Items.Clear();
            foreach (string website in _customer.HostingInformation.Websites)
            {
                lstWebsites.Items.Add(website);
            }
            
            // Load email hosting information
            chkIncludesEmailHosting.Checked = _customer.HostingInformation.IncludesEmailHosting;
            nudTotalMailboxes.Value = _customer.HostingInformation.TotalMailboxes;
            
            // Load DNS information
            chkDnsConfigured.Checked = _customer.HostingInformation.DnsConfigured;
            txtDnsProvider.Text = _customer.HostingInformation.DnsProvider;
            
            // Load SSL information
            chkSslRequired.Checked = _customer.HostingInformation.SslRequired;
            if (_customer.HostingInformation.SslExpirationDate.HasValue)
            {
                dtpSslExpirationDate.Value = _customer.HostingInformation.SslExpirationDate.Value;
            }
            
            // Load backup information
            chkBackupConfigured.Checked = _customer.HostingInformation.BackupConfigured;
            txtBackupSchedule.Text = _customer.HostingInformation.BackupSchedule;
            
            // Load monitoring information
            chkMonitoringConfigured.Checked = _customer.HostingInformation.MonitoringConfigured;
            txtMonitoringNotes.Text = _customer.HostingInformation.MonitoringNotes;
            
            // Load documentation information
            chkHostingDocumented.Checked = _customer.HostingInformation.HostingDocumented;
            txtDocumentationLocation.Text = _customer.HostingInformation.DocumentationLocation;
            txtAdditionalNotes.Text = _customer.HostingInformation.AdditionalNotes;
            
            // Update UI based on loaded data
            UpdateUI();
        }
        
        private void UpdateUI()
        {
            // Enable/disable controls based on checkbox states
            pnlEmailHosting.Enabled = chkIncludesEmailHosting.Checked;
            pnlDns.Enabled = chkDnsConfigured.Checked;
            pnlSsl.Enabled = chkSslRequired.Checked;
            pnlBackup.Enabled = chkBackupConfigured.Checked;
            pnlMonitoring.Enabled = chkMonitoringConfigured.Checked;
            pnlDocumentation.Enabled = chkHostingDocumented.Checked;
        }
        
        private void chkIncludesEmailHosting_CheckedChanged(object sender, EventArgs e)
        {
            pnlEmailHosting.Enabled = chkIncludesEmailHosting.Checked;
        }
        
        private void chkDnsConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlDns.Enabled = chkDnsConfigured.Checked;
        }
        
        private void chkSslRequired_CheckedChanged(object sender, EventArgs e)
        {
            pnlSsl.Enabled = chkSslRequired.Checked;
        }
        
        private void chkBackupConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlBackup.Enabled = chkBackupConfigured.Checked;
        }
        
        private void chkMonitoringConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlMonitoring.Enabled = chkMonitoringConfigured.Checked;
        }
        
        private void chkHostingDocumented_CheckedChanged(object sender, EventArgs e)
        {
            pnlDocumentation.Enabled = chkHostingDocumented.Checked;
        }
        
        private void btnAddWebsite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWebsite.Text))
            {
                lstWebsites.Items.Add(txtWebsite.Text);
                txtWebsite.Clear();
                txtWebsite.Focus();
            }
        }
        
        private void btnRemoveWebsite_Click(object sender, EventArgs e)
        {
            if (lstWebsites.SelectedIndex >= 0)
            {
                lstWebsites.Items.RemoveAt(lstWebsites.SelectedIndex);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new HostingInfo object if it doesn't exist
            if (_customer.HostingInformation == null)
            {
                _customer.HostingInformation = new HostingInfo();
            }
            
            // Save the hosting information
            _customer.HostingInformation.HostingType = cboHostingType.Text;
            _customer.HostingInformation.Provider = txtProvider.Text;
            _customer.HostingInformation.IsNewHosting = chkNewHosting.Checked;
            
            // Save website and database counts
            _customer.HostingInformation.TotalWebsites = (int)nudTotalWebsites.Value;
            _customer.HostingInformation.TotalDatabases = (int)nudTotalDatabases.Value;
            
            // Save website information
            _customer.HostingInformation.Websites.Clear();
            foreach (string website in lstWebsites.Items)
            {
                _customer.HostingInformation.Websites.Add(website);
            }
            
            // Save email hosting information
            _customer.HostingInformation.IncludesEmailHosting = chkIncludesEmailHosting.Checked;
            _customer.HostingInformation.TotalMailboxes = (int)nudTotalMailboxes.Value;
            
            // Save DNS information
            _customer.HostingInformation.DnsConfigured = chkDnsConfigured.Checked;
            _customer.HostingInformation.DnsProvider = txtDnsProvider.Text;
            
            // Save SSL information
            _customer.HostingInformation.SslRequired = chkSslRequired.Checked;
            _customer.HostingInformation.SslExpirationDate = chkSslRequired.Checked ? 
                dtpSslExpirationDate.Value : (DateTime?)null;
            
            // Save backup information
            _customer.HostingInformation.BackupConfigured = chkBackupConfigured.Checked;
            _customer.HostingInformation.BackupSchedule = txtBackupSchedule.Text;
            
            // Save monitoring information
            _customer.HostingInformation.MonitoringConfigured = chkMonitoringConfigured.Checked;
            _customer.HostingInformation.MonitoringNotes = txtMonitoringNotes.Text;
            
            // Save documentation information
            _customer.HostingInformation.HostingDocumented = chkHostingDocumented.Checked;
            _customer.HostingInformation.DocumentationLocation = txtDocumentationLocation.Text;
            _customer.HostingInformation.AdditionalNotes = txtAdditionalNotes.Text;
            
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
