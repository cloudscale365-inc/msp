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
    public partial class Office365Form : Form
    {
        private Customer _customer;
        
        public Office365Form(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            // Load the customer's Office 365 information if it exists
            if (_customer.Office365Information != null)
            {
                LoadOffice365Data();
            }
        }
        
        private void LoadOffice365Data()
        {
            // Populate the form fields with the customer's Office 365 data
            chkExistingLicenses.Checked = _customer.Office365Information.HasExistingLicenses;
            nudNumberOfLicenses.Value = _customer.Office365Information.NumberOfLicenses > 0 ? 
                _customer.Office365Information.NumberOfLicenses : 1;
            txtLicenseType.Text = _customer.Office365Information.LicenseType;
            chkCredentialsProvided.Checked = _customer.Office365Information.HasProvidedCredentials;
            txtAdminUsername.Text = _customer.Office365Information.AdminUsername;
            txtAdminPassword.Text = _customer.Office365Information.AdminPassword;
            txtTenantId.Text = _customer.Office365Information.TenantId;
            txtDomain.Text = _customer.Office365Information.Domain;
            
            // Load required services
            foreach (string service in _customer.Office365Information.RequiredServices)
            {
                switch (service)
                {
                    case "Exchange":
                        chkExchange.Checked = true;
                        break;
                    case "SharePoint":
                        chkSharePoint.Checked = true;
                        break;
                    case "Teams":
                        chkTeams.Checked = true;
                        break;
                    case "OneDrive":
                        chkOneDrive.Checked = true;
                        break;
                }
            }
            
            // Load migration information
            chkRequiresMigration.Checked = _customer.Office365Information.RequiresMigration;
            txtMigrationSource.Text = _customer.Office365Information.MigrationSource;
            if (_customer.Office365Information.ScheduledMigrationDate.HasValue)
            {
                dtpMigrationDate.Value = _customer.Office365Information.ScheduledMigrationDate.Value;
            }
            txtMigrationNotes.Text = _customer.Office365Information.MigrationNotes;
            
            // Load setup information
            chkSetupComplete.Checked = _customer.Office365Information.SetupComplete;
            txtSetupNotes.Text = _customer.Office365Information.SetupNotes;
            
            // Update UI based on loaded data
            UpdateUI();
        }
        
        private void UpdateUI()
        {
            // Enable/disable controls based on checkbox states
            pnlLicenses.Enabled = chkExistingLicenses.Checked;
            pnlCredentials.Enabled = chkCredentialsProvided.Checked;
            pnlMigration.Enabled = chkRequiresMigration.Checked;
        }
        
        private void chkExistingLicenses_CheckedChanged(object sender, EventArgs e)
        {
            pnlLicenses.Enabled = chkExistingLicenses.Checked;
        }
        
        private void chkCredentialsProvided_CheckedChanged(object sender, EventArgs e)
        {
            pnlCredentials.Enabled = chkCredentialsProvided.Checked;
        }
        
        private void chkRequiresMigration_CheckedChanged(object sender, EventArgs e)
        {
            pnlMigration.Enabled = chkRequiresMigration.Checked;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new Office365Info object if it doesn't exist
            if (_customer.Office365Information == null)
            {
                _customer.Office365Information = new Office365Info();
            }
            
            // Save the Office 365 information
            _customer.Office365Information.HasExistingLicenses = chkExistingLicenses.Checked;
            _customer.Office365Information.NumberOfLicenses = (int)nudNumberOfLicenses.Value;
            _customer.Office365Information.LicenseType = txtLicenseType.Text;
            _customer.Office365Information.HasProvidedCredentials = chkCredentialsProvided.Checked;
            _customer.Office365Information.AdminUsername = txtAdminUsername.Text;
            _customer.Office365Information.AdminPassword = txtAdminPassword.Text;
            _customer.Office365Information.TenantId = txtTenantId.Text;
            _customer.Office365Information.Domain = txtDomain.Text;
            
            // Save required services
            _customer.Office365Information.RequiredServices.Clear();
            if (chkExchange.Checked) _customer.Office365Information.RequiredServices.Add("Exchange");
            if (chkSharePoint.Checked) _customer.Office365Information.RequiredServices.Add("SharePoint");
            if (chkTeams.Checked) _customer.Office365Information.RequiredServices.Add("Teams");
            if (chkOneDrive.Checked) _customer.Office365Information.RequiredServices.Add("OneDrive");
            
            // Save migration information
            _customer.Office365Information.RequiresMigration = chkRequiresMigration.Checked;
            _customer.Office365Information.MigrationSource = txtMigrationSource.Text;
            _customer.Office365Information.ScheduledMigrationDate = chkRequiresMigration.Checked ? 
                dtpMigrationDate.Value : (DateTime?)null;
            _customer.Office365Information.MigrationNotes = txtMigrationNotes.Text;
            
            // Save setup information
            _customer.Office365Information.SetupComplete = chkSetupComplete.Checked;
            _customer.Office365Information.SetupNotes = txtSetupNotes.Text;
            
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
