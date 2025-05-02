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
    public partial class ServerManagementForm : Form
    {
        private Customer _customer;
        
        public ServerManagementForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            // Load the customer's server management information if it exists
            if (_customer.ServerManagementInformation != null)
            {
                LoadServerManagementData();
            }
        }
        
        private void LoadServerManagementData()
        {
            // Populate the form fields with the customer's server management data
            chkAccessGranted.Checked = _customer.ServerManagementInformation.AccessGranted;
            cboAccessMethod.Text = _customer.ServerManagementInformation.AccessMethod;
            txtCredentials.Text = _customer.ServerManagementInformation.Credentials;
            chkInventoryComplete.Checked = _customer.ServerManagementInformation.InventoryComplete;
            
            // Load server counts
            nudTotalServers.Value = _customer.ServerManagementInformation.TotalServers;
            nudPhysicalServers.Value = _customer.ServerManagementInformation.PhysicalServers;
            nudVirtualServers.Value = _customer.ServerManagementInformation.VirtualServers;
            nudCloudServers.Value = _customer.ServerManagementInformation.CloudServers;
            
            // Load server types
            lstServerTypes.Items.Clear();
            foreach (string serverType in _customer.ServerManagementInformation.ServerTypes)
            {
                lstServerTypes.Items.Add(serverType);
            }
            
            // Load monitoring information
            chkMonitoringAgentsInstalled.Checked = _customer.ServerManagementInformation.MonitoringAgentsInstalled;
            txtMonitoringNotes.Text = _customer.ServerManagementInformation.MonitoringNotes;
            
            // Load backup information
            chkBackupConfigured.Checked = _customer.ServerManagementInformation.BackupConfigured;
            cboBackupSolution.Text = _customer.ServerManagementInformation.BackupSolution;
            txtBackupSchedule.Text = _customer.ServerManagementInformation.BackupSchedule;
            
            // Load patch management information
            chkPatchManagementConfigured.Checked = _customer.ServerManagementInformation.PatchManagementConfigured;
            cboPatchManagementSolution.Text = _customer.ServerManagementInformation.PatchManagementSolution;
            txtPatchSchedule.Text = _customer.ServerManagementInformation.PatchSchedule;
            
            // Load security assessment information
            chkSecurityAssessmentComplete.Checked = _customer.ServerManagementInformation.SecurityAssessmentComplete;
            if (_customer.ServerManagementInformation.SecurityAssessmentDate.HasValue)
            {
                dtpSecurityAssessmentDate.Value = _customer.ServerManagementInformation.SecurityAssessmentDate.Value;
            }
            nudCriticalIssues.Value = _customer.ServerManagementInformation.CriticalSecurityIssues;
            nudHighIssues.Value = _customer.ServerManagementInformation.HighSecurityIssues;
            nudMediumIssues.Value = _customer.ServerManagementInformation.MediumSecurityIssues;
            nudLowIssues.Value = _customer.ServerManagementInformation.LowSecurityIssues;
            
            // Load documentation information
            chkServersDocumented.Checked = _customer.ServerManagementInformation.ServersDocumented;
            txtDocumentationLocation.Text = _customer.ServerManagementInformation.DocumentationLocation;
            txtAdditionalNotes.Text = _customer.ServerManagementInformation.AdditionalNotes;
            
            // Update UI based on loaded data
            UpdateUI();
        }
        
        private void UpdateUI()
        {
            // Enable/disable controls based on checkbox states
            pnlAccess.Enabled = chkAccessGranted.Checked;
            pnlInventory.Enabled = chkInventoryComplete.Checked;
            pnlMonitoring.Enabled = chkMonitoringAgentsInstalled.Checked;
            pnlBackup.Enabled = chkBackupConfigured.Checked;
            pnlPatchManagement.Enabled = chkPatchManagementConfigured.Checked;
            pnlSecurityAssessment.Enabled = chkSecurityAssessmentComplete.Checked;
            pnlDocumentation.Enabled = chkServersDocumented.Checked;
        }
        
        private void chkAccessGranted_CheckedChanged(object sender, EventArgs e)
        {
            pnlAccess.Enabled = chkAccessGranted.Checked;
        }
        
        private void chkInventoryComplete_CheckedChanged(object sender, EventArgs e)
        {
            pnlInventory.Enabled = chkInventoryComplete.Checked;
        }
        
        private void chkMonitoringAgentsInstalled_CheckedChanged(object sender, EventArgs e)
        {
            pnlMonitoring.Enabled = chkMonitoringAgentsInstalled.Checked;
        }
        
        private void chkBackupConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlBackup.Enabled = chkBackupConfigured.Checked;
        }
        
        private void chkPatchManagementConfigured_CheckedChanged(object sender, EventArgs e)
        {
            pnlPatchManagement.Enabled = chkPatchManagementConfigured.Checked;
        }
        
        private void chkSecurityAssessmentComplete_CheckedChanged(object sender, EventArgs e)
        {
            pnlSecurityAssessment.Enabled = chkSecurityAssessmentComplete.Checked;
        }
        
        private void chkServersDocumented_CheckedChanged(object sender, EventArgs e)
        {
            pnlDocumentation.Enabled = chkServersDocumented.Checked;
        }
        
        private void btnAddServerType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtServerType.Text))
            {
                lstServerTypes.Items.Add(txtServerType.Text);
                txtServerType.Clear();
                txtServerType.Focus();
            }
        }
        
        private void btnRemoveServerType_Click(object sender, EventArgs e)
        {
            if (lstServerTypes.SelectedIndex >= 0)
            {
                lstServerTypes.Items.RemoveAt(lstServerTypes.SelectedIndex);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new ServerManagementInfo object if it doesn't exist
            if (_customer.ServerManagementInformation == null)
            {
                _customer.ServerManagementInformation = new ServerManagementInfo();
            }
            
            // Save the server management information
            _customer.ServerManagementInformation.AccessGranted = chkAccessGranted.Checked;
            _customer.ServerManagementInformation.AccessMethod = cboAccessMethod.Text;
            _customer.ServerManagementInformation.Credentials = txtCredentials.Text;
            _customer.ServerManagementInformation.InventoryComplete = chkInventoryComplete.Checked;
            
            // Save server counts
            _customer.ServerManagementInformation.TotalServers = (int)nudTotalServers.Value;
            _customer.ServerManagementInformation.PhysicalServers = (int)nudPhysicalServers.Value;
            _customer.ServerManagementInformation.VirtualServers = (int)nudVirtualServers.Value;
            _customer.ServerManagementInformation.CloudServers = (int)nudCloudServers.Value;
            
            // Save server types
            _customer.ServerManagementInformation.ServerTypes.Clear();
            foreach (string serverType in lstServerTypes.Items)
            {
                _customer.ServerManagementInformation.ServerTypes.Add(serverType);
            }
            
            // Save monitoring information
            _customer.ServerManagementInformation.MonitoringAgentsInstalled = chkMonitoringAgentsInstalled.Checked;
            _customer.ServerManagementInformation.MonitoringNotes = txtMonitoringNotes.Text;
            
            // Save backup information
            _customer.ServerManagementInformation.BackupConfigured = chkBackupConfigured.Checked;
            _customer.ServerManagementInformation.BackupSolution = cboBackupSolution.Text;
            _customer.ServerManagementInformation.BackupSchedule = txtBackupSchedule.Text;
            
            // Save patch management information
            _customer.ServerManagementInformation.PatchManagementConfigured = chkPatchManagementConfigured.Checked;
            _customer.ServerManagementInformation.PatchManagementSolution = cboPatchManagementSolution.Text;
            _customer.ServerManagementInformation.PatchSchedule = txtPatchSchedule.Text;
            
            // Save security assessment information
            _customer.ServerManagementInformation.SecurityAssessmentComplete = chkSecurityAssessmentComplete.Checked;
            _customer.ServerManagementInformation.SecurityAssessmentDate = chkSecurityAssessmentComplete.Checked ? 
                dtpSecurityAssessmentDate.Value : (DateTime?)null;
            _customer.ServerManagementInformation.CriticalSecurityIssues = (int)nudCriticalIssues.Value;
            _customer.ServerManagementInformation.HighSecurityIssues = (int)nudHighIssues.Value;
            _customer.ServerManagementInformation.MediumSecurityIssues = (int)nudMediumIssues.Value;
            _customer.ServerManagementInformation.LowSecurityIssues = (int)nudLowIssues.Value;
            
            // Save documentation information
            _customer.ServerManagementInformation.ServersDocumented = chkServersDocumented.Checked;
            _customer.ServerManagementInformation.DocumentationLocation = txtDocumentationLocation.Text;
            _customer.ServerManagementInformation.AdditionalNotes = txtAdditionalNotes.Text;
            
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
