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
    public partial class ServiceSelectionForm : Form
    {
        private Customer _customer;
        
        public ServiceSelectionForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            
            // Load the customer's current service selections
            LoadCustomerServices();
        }
        
        private void LoadCustomerServices()
        {
            // Set the checkboxes based on the customer's current service selections
            chkOffice365.Checked = _customer.HasOffice365Services;
            chkNetworkMonitoring.Checked = _customer.HasNetworkMonitoring;
            chkServerManagement.Checked = _customer.HasServerManagement;
            chkSaasCloudMonitoring.Checked = _customer.HasSaasCloudMonitoring;
            chkHosting.Checked = _customer.HasHosting;
            
            // Update the service details panels visibility
            UpdateServicePanelsVisibility();
        }
        
        private void UpdateServicePanelsVisibility()
        {
            // Show or hide the service details panels based on the checkbox selections
            pnlOffice365.Visible = chkOffice365.Checked;
            pnlNetworkMonitoring.Visible = chkNetworkMonitoring.Checked;
            pnlServerManagement.Visible = chkServerManagement.Checked;
            pnlSaasCloudMonitoring.Visible = chkSaasCloudMonitoring.Checked;
            pnlHosting.Visible = chkHosting.Checked;
        }
        
        private void chkOffice365_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServicePanelsVisibility();
        }
        
        private void chkNetworkMonitoring_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServicePanelsVisibility();
        }
        
        private void chkServerManagement_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServicePanelsVisibility();
        }
        
        private void chkSaasCloudMonitoring_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServicePanelsVisibility();
        }
        
        private void chkHosting_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServicePanelsVisibility();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the service selections
            _customer.HasOffice365Services = chkOffice365.Checked;
            _customer.HasNetworkMonitoring = chkNetworkMonitoring.Checked;
            _customer.HasServerManagement = chkServerManagement.Checked;
            _customer.HasSaasCloudMonitoring = chkSaasCloudMonitoring.Checked;
            _customer.HasHosting = chkHosting.Checked;
            
            // Initialize service-specific information objects if they don't exist
            if (_customer.HasOffice365Services && _customer.Office365Information == null)
            {
                _customer.Office365Information = new Office365Info();
                
                // Set initial values from the form
                _customer.Office365Information.HasExistingLicenses = radExistingLicenses.Checked;
                _customer.Office365Information.HasProvidedCredentials = chkCredentialsProvided.Checked;
            }
            
            if (_customer.HasNetworkMonitoring && _customer.NetworkMonitoringInformation == null)
            {
                _customer.NetworkMonitoringInformation = new NetworkMonitoringInfo();
                
                // Set initial values from the form
                _customer.NetworkMonitoringInformation.AccessGranted = chkNetworkAccessGranted.Checked;
            }
            
            if (_customer.HasServerManagement && _customer.ServerManagementInformation == null)
            {
                _customer.ServerManagementInformation = new ServerManagementInfo();
            }
            
            if (_customer.HasSaasCloudMonitoring && _customer.SaasCloudMonitoringInformation == null)
            {
                _customer.SaasCloudMonitoringInformation = new SaasCloudMonitoringInfo();
            }
            
            if (_customer.HasHosting && _customer.HostingInformation == null)
            {
                _customer.HostingInformation = new HostingInfo();
            }
            
            // Determine the next form to open based on the selected services
            if (_customer.HasOffice365Services)
            {
                using (Office365Form office365Form = new Office365Form(_customer))
                {
                    if (office365Form.ShowDialog() == DialogResult.OK)
                    {
                        // Continue with the next service or close this form
                        ContinueWithNextService(ServiceType.Office365);
                    }
                }
            }
            else if (_customer.HasNetworkMonitoring)
            {
                using (NetworkMonitoringForm networkForm = new NetworkMonitoringForm(_customer))
                {
                    if (networkForm.ShowDialog() == DialogResult.OK)
                    {
                        // Continue with the next service or close this form
                        ContinueWithNextService(ServiceType.NetworkMonitoring);
                    }
                }
            }
            else if (_customer.HasServerManagement)
            {
                using (ServerManagementForm serverForm = new ServerManagementForm(_customer))
                {
                    if (serverForm.ShowDialog() == DialogResult.OK)
                    {
                        // Continue with the next service or close this form
                        ContinueWithNextService(ServiceType.ServerManagement);
                    }
                }
            }
            else if (_customer.HasSaasCloudMonitoring)
            {
                using (SaasCloudMonitoringForm saasForm = new SaasCloudMonitoringForm(_customer))
                {
                    if (saasForm.ShowDialog() == DialogResult.OK)
                    {
                        // Continue with the next service or close this form
                        ContinueWithNextService(ServiceType.SaasCloudMonitoring);
                    }
                }
            }
            else if (_customer.HasHosting)
            {
                using (HostingForm hostingForm = new HostingForm(_customer))
                {
                    if (hostingForm.ShowDialog() == DialogResult.OK)
                    {
                        // Continue with the next service or close this form
                        ContinueWithNextService(ServiceType.Hosting);
                    }
                }
            }
            else
            {
                // No services selected, just close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        
        private void ContinueWithNextService(ServiceType currentService)
        {
            // Determine the next service to configure
            switch (currentService)
            {
                case ServiceType.Office365:
                    if (_customer.HasNetworkMonitoring)
                    {
                        using (NetworkMonitoringForm networkForm = new NetworkMonitoringForm(_customer))
                        {
                            if (networkForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.NetworkMonitoring);
                            }
                        }
                    }
                    else if (_customer.HasServerManagement)
                    {
                        using (ServerManagementForm serverForm = new ServerManagementForm(_customer))
                        {
                            if (serverForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.ServerManagement);
                            }
                        }
                    }
                    else if (_customer.HasSaasCloudMonitoring)
                    {
                        using (SaasCloudMonitoringForm saasForm = new SaasCloudMonitoringForm(_customer))
                        {
                            if (saasForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.SaasCloudMonitoring);
                            }
                        }
                    }
                    else if (_customer.HasHosting)
                    {
                        using (HostingForm hostingForm = new HostingForm(_customer))
                        {
                            if (hostingForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.Hosting);
                            }
                        }
                    }
                    else
                    {
                        // No more services to configure
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    break;
                
                case ServiceType.NetworkMonitoring:
                    if (_customer.HasServerManagement)
                    {
                        using (ServerManagementForm serverForm = new ServerManagementForm(_customer))
                        {
                            if (serverForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.ServerManagement);
                            }
                        }
                    }
                    else if (_customer.HasSaasCloudMonitoring)
                    {
                        using (SaasCloudMonitoringForm saasForm = new SaasCloudMonitoringForm(_customer))
                        {
                            if (saasForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.SaasCloudMonitoring);
                            }
                        }
                    }
                    else if (_customer.HasHosting)
                    {
                        using (HostingForm hostingForm = new HostingForm(_customer))
                        {
                            if (hostingForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.Hosting);
                            }
                        }
                    }
                    else
                    {
                        // No more services to configure
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    break;
                
                case ServiceType.ServerManagement:
                    if (_customer.HasSaasCloudMonitoring)
                    {
                        using (SaasCloudMonitoringForm saasForm = new SaasCloudMonitoringForm(_customer))
                        {
                            if (saasForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.SaasCloudMonitoring);
                            }
                        }
                    }
                    else if (_customer.HasHosting)
                    {
                        using (HostingForm hostingForm = new HostingForm(_customer))
                        {
                            if (hostingForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.Hosting);
                            }
                        }
                    }
                    else
                    {
                        // No more services to configure
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    break;
                
                case ServiceType.SaasCloudMonitoring:
                    if (_customer.HasHosting)
                    {
                        using (HostingForm hostingForm = new HostingForm(_customer))
                        {
                            if (hostingForm.ShowDialog() == DialogResult.OK)
                            {
                                ContinueWithNextService(ServiceType.Hosting);
                            }
                        }
                    }
                    else
                    {
                        // No more services to configure
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    break;
                
                case ServiceType.Hosting:
                    // No more services to configure
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
    
    // Enum to represent the different service types
    public enum ServiceType
    {
        Office365,
        NetworkMonitoring,
        ServerManagement,
        SaasCloudMonitoring,
        Hosting
    }
}
