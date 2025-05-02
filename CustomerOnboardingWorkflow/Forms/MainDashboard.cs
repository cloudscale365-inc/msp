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
    public partial class MainDashboard : Form
    {
        // List to store all customers
        private List<Customer> customers = new List<Customer>();
        
        public MainDashboard()
        {
            InitializeComponent();
            
            // In a real application, we would load customers from a database
            // For demo purposes, we'll add some sample data
            LoadSampleData();
            
            // Set up the data grid view
            RefreshCustomerList();
        }
        
        private void LoadSampleData()
        {
            // Add a sample customer for demonstration
            Customer sampleCustomer = new Customer
            {
                CompanyName = "Acme Corporation",
                PrimaryAddress = "123 Main St, Anytown, USA",
                ContactName = "John Doe",
                ContactEmail = "john.doe@acme.com",
                ContactPhone = "555-123-4567",
                ContractNumber = "ACME-2025-001",
                ContractSignDate = DateTime.Now.AddDays(-5),
                ContractStartDate = DateTime.Now,
                ContractEndDate = DateTime.Now.AddYears(1),
                HasOffice365Services = true,
                HasNetworkMonitoring = true,
                HasServerManagement = false,
                HasSaasCloudMonitoring = true,
                HasHosting = false,
                OnboardingStatus = "In Progress"
            };
            
            // Add Office 365 information
            sampleCustomer.Office365Information = new Office365Info
            {
                HasExistingLicenses = true,
                NumberOfLicenses = 25,
                LicenseType = "Microsoft 365 Business Premium",
                HasProvidedCredentials = true,
                Domain = "acme.com"
            };
            
            customers.Add(sampleCustomer);
        }
        
        private void RefreshCustomerList()
        {
            // Bind the customers list to the data grid view
            // In a real application, this would be more sophisticated
            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.DataSource = customers;
            
            // Configure columns for better display
            if (dataGridViewCustomers.Columns.Count > 0)
            {
                dataGridViewCustomers.Columns["Id"].Visible = false;
                dataGridViewCustomers.Columns["AdditionalAddresses"].Visible = false;
                dataGridViewCustomers.Columns["Office365Information"].Visible = false;
                dataGridViewCustomers.Columns["NetworkMonitoringInformation"].Visible = false;
                dataGridViewCustomers.Columns["ServerManagementInformation"].Visible = false;
                dataGridViewCustomers.Columns["SaasCloudMonitoringInformation"].Visible = false;
                dataGridViewCustomers.Columns["HostingInformation"].Visible = false;
                dataGridViewCustomers.Columns["Notes"].Visible = false;
            }
        }
        
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            // Create a new customer and open the customer information form
            Customer newCustomer = new Customer();
            using (CustomerInfoForm customerForm = new CustomerInfoForm(newCustomer, true))
            {
                if (customerForm.ShowDialog() == DialogResult.OK)
                {
                    customers.Add(newCustomer);
                    RefreshCustomerList();
                }
            }
        }
        
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // Edit the selected customer
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                Customer selectedCustomer = (Customer)dataGridViewCustomers.SelectedRows[0].DataBoundItem;
                using (CustomerInfoForm customerForm = new CustomerInfoForm(selectedCustomer, false))
                {
                    if (customerForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCustomerList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnContinueOnboarding_Click(object sender, EventArgs e)
        {
            // Continue the onboarding process for the selected customer
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                Customer selectedCustomer = (Customer)dataGridViewCustomers.SelectedRows[0].DataBoundItem;
                
                // Open the service selection form or the appropriate next form based on the customer's onboarding status
                using (ServiceSelectionForm serviceForm = new ServiceSelectionForm(selectedCustomer))
                {
                    if (serviceForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCustomerList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to continue onboarding.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            // View a report for the selected customer
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                Customer selectedCustomer = (Customer)dataGridViewCustomers.SelectedRows[0].DataBoundItem;
                
                using (ReportForm reportForm = new ReportForm(selectedCustomer))
                {
                    reportForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to view the report.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
