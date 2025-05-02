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
    public partial class SaasCloudMonitoringForm : Form
    {
        private Customer _customer;
        
        public SaasCloudMonitoringForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            // Load the customer's SaaS/Cloud monitoring information if it exists
            if (_customer.SaasCloudMonitoringInformation != null)
            {
                LoadSaasCloudMonitoringData();
            }
        }
        
        private void LoadSaasCloudMonitoringData()
        {
            // Populate the form fields with the customer's SaaS/Cloud monitoring data
            chkInventoryComplete.Checked = _customer.SaasCloudMonitoringInformation.InventoryComplete;
            nudTotalSaasApplications.Value = _customer.SaasCloudMonitoringInformation.TotalSaasApplications;
            
            // Load SaaS applications
            lstSaasApplications.Items.Clear();
            foreach (string app in _customer.SaasCloudMonitoringInformation.SaasApplications)
            {
                lstSaasApplications.Items.Add(app);
            }
            
            chkCloudInventoryComplete.Checked = _customer.SaasCloudMonitoringInformation.CloudInventoryComplete;
            nudTotalCloudServices.Value = _customer.SaasCloudMonitoringInformation.TotalCloudServices;
            
            // Load cloud services
            lstCloudServices.Items.Clear();
            foreach (string service in _customer.SaasCloudMonitoringInformation.CloudServices)
            {
                lstCloudServices.Items.Add(service);
            }
            
            // Load monitoring information
            chkMonitoringConfigured.Checked = _customer.SaasCloudMonitoringInformation.MonitoringConfigured;
            txtMonitoringNotes.Text = _customer.SaasCloudMonitoringInformation.MonitoringNotes;
            
            // Load alerting information
            chkAlertingConfigured.Checked = _customer.SaasCloudMonitoringInformation.AlertingConfigured;
            
            // Load alert recipients
            lstAlertRecipients.Items.Clear();
            foreach (string recipient in _customer.SaasCloudMonitoringInformation.AlertRecipients)
            {
                lstAlertRecipients.Items.Add(recipient);
            }
            
            // Load security assessment information
            chkSecurityAssessmentComplete.Checked = _customer.SaasCloudMonitoringInformation.SecurityAssessmentComplete;
            if (_customer.SaasCloudMonitoringInformation.SecurityAssessmentDate.HasValue)
            {
                dtpSecurityAssessmentDate.Value = _customer.SaasCloudMonitoringInformation.SecurityAssessmentDate.Value;
            }
            
            // Load documentation information
            chkServicesDocumented.Checked = _customer.SaasCloudMonitoringInformation.ServicesDocumented;
            txtDocumentationLocation.Text = _customer.SaasCloudMonitoringInformation.DocumentationLocation;
            txtAdditionalNotes.Text = _customer.SaasCloudMonitoringInformation.AdditionalNotes;
            
            // Update UI based on loaded data
            UpdateUI();
        }
        
        private void UpdateUI()
        {
            // Enable/disable controls based on checkbox states
            pnlSaasInventory.Enabled = chkInventoryComplete.Checked;
            pnlCloudInventory.Enabled = chkCloudInventoryComplete.Checked;
            pnlMonitoring.Enabled = chkMonitoringConfigured.Checked;
            pnlAlerting.Enabled = chkAlertingConfigured.Checked;
            pnlSecurityAssessment.Enabled = chkSecurityAssessmentComplete.Checked;
            pnlDocumentation.Enabled = chkServicesDocumented.Checked;
        }
        
        private void chkInventoryComplete_CheckedChanged(object sender, EventArgs e)
        {
            pnlSaasInventory.Enabled = chkInventoryComplete.Checked;
        }
        
        private void chkCloudInventoryComplete_CheckedChanged(object sender, EventArgs e)
        {
            pnlCloudInventory.Enabled = chkCloudInventoryComplete.Checked;
        }
        
        private void chkMonitoringConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlMonitoring.Enabled = chkMonitoringConfigured.Checked;
        }
        
        private void chkAlertingConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlAlerting.Enabled = chkAlertingConfigured.Checked;
        }
        
        private void chkSecurityAssessmentComplete_CheckedChanged(object sender, EventArgs e)
        {
            pnlSecurityAssessment.Enabled = chkSecurityAssessmentComplete.Checked;
        }
        
        private void chkServicesDocumented_CheckedChanged(object sender, EventArgs e)
        {
            pnlDocumentation.Enabled = chkServicesDocumented.Checked;
        }
        
        private void btnAddSaasApplication_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSaasApplication.Text))
            {
                lstSaasApplications.Items.Add(txtSaasApplication.Text);
                txtSaasApplication.Clear();
                txtSaasApplication.Focus();
            }
        }
        
        private void btnRemoveSaasApplication_Click(object sender, EventArgs e)
        {
            if (lstSaasApplications.SelectedIndex >= 0)
            {
                lstSaasApplications.Items.RemoveAt(lstSaasApplications.SelectedIndex);
            }
        }
        
        private void btnAddCloudService_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCloudService.Text))
            {
                lstCloudServices.Items.Add(txtCloudService.Text);
                txtCloudService.Clear();
                txtCloudService.Focus();
            }
        }
        
        private void btnRemoveCloudService_Click(object sender, EventArgs e)
        {
            if (lstCloudServices.SelectedIndex >= 0)
            {
                lstCloudServices.Items.RemoveAt(lstCloudServices.SelectedIndex);
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
            // Create a new SaasCloudMonitoringInfo object if it doesn't exist
            if (_customer.SaasCloudMonitoringInformation == null)
            {
                _customer.SaasCloudMonitoringInformation = new SaasCloudMonitoringInfo();
            }
            
            // Save the SaaS/Cloud monitoring information
            _customer.SaasCloudMonitoringInformation.InventoryComplete = chkInventoryComplete.Checked;
            _customer.SaasCloudMonitoringInformation.TotalSaasApplications = (int)nudTotalSaasApplications.Value;
            
            // Save SaaS applications
            _customer.SaasCloudMonitoringInformation.SaasApplications.Clear();
            foreach (string app in lstSaasApplications.Items)
            {
                _customer.SaasCloudMonitoringInformation.SaasApplications.Add(app);
            }
            
            // Save cloud inventory information
            _customer.SaasCloudMonitoringInformation.CloudInventoryComplete = chkCloudInventoryComplete.Checked;
            _customer.SaasCloudMonitoringInformation.TotalCloudServices = (int)nudTotalCloudServices.Value;
            
            // Save cloud services
            _customer.SaasCloudMonitoringInformation.CloudServices.Clear();
            foreach (string service in lstCloudServices.Items)
            {
                _customer.SaasCloudMonitoringInformation.CloudServices.Add(service);
            }
            
            // Save monitoring information
            _customer.SaasCloudMonitoringInformation.MonitoringConfigured = chkMonitoringConfigured.Checked;
            _customer.SaasCloudMonitoringInformation.MonitoringNotes = txtMonitoringNotes.Text;
            
            // Save alerting information
            _customer.SaasCloudMonitoringInformation.AlertingConfigured = chkAlertingConfigured.Checked;
            
            // Save alert recipients
            _customer.SaasCloudMonitoringInformation.AlertRecipients.Clear();
            foreach (string recipient in lstAlertRecipients.Items)
            {
                _customer.SaasCloudMonitoringInformation.AlertRecipients.Add(recipient);
            }
            
            // Save security assessment information
            _customer.SaasCloudMonitoringInformation.SecurityAssessmentComplete = chkSecurityAssessmentComplete.Checked;
            _customer.SaasCloudMonitoringInformation.SecurityAssessmentDate = chkSecurityAssessmentComplete.Checked ? 
                dtpSecurityAssessmentDate.Value : (DateTime?)null;
            
            // Save documentation information
            _customer.SaasCloudMonitoringInformation.ServicesDocumented = chkServicesDocumented.Checked;
            _customer.SaasCloudMonitoringInformation.DocumentationLocation = txtDocumentationLocation.Text;
            _customer.SaasCloudMonitoringInformation.AdditionalNotes = txtAdditionalNotes.Text;
            
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
