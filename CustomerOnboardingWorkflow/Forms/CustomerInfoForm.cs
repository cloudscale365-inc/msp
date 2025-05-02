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
    public partial class CustomerInfoForm : Form
    {
        private Customer _customer;
        private bool _isNewCustomer;
        
        public CustomerInfoForm(Customer customer, bool isNewCustomer)
        {
            InitializeComponent();
            _customer = customer;
            _isNewCustomer = isNewCustomer;
            
            // Set the form title based on whether we're adding a new customer or editing an existing one
            this.Text = _isNewCustomer ? "Add New Customer" : "Edit Customer Information";
            
            // Load customer data if editing an existing customer
            if (!_isNewCustomer)
            {
                LoadCustomerData();
            }
        }
        
        private void LoadCustomerData()
        {
            // Populate the form fields with the customer's data
            txtCompanyName.Text = _customer.CompanyName;
            txtPrimaryAddress.Text = _customer.PrimaryAddress;
            txtContactName.Text = _customer.ContactName;
            txtContactEmail.Text = _customer.ContactEmail;
            txtContactPhone.Text = _customer.ContactPhone;
            txtContractNumber.Text = _customer.ContractNumber;
            dtpContractSignDate.Value = _customer.ContractSignDate;
            dtpContractStartDate.Value = _customer.ContractStartDate;
            dtpContractEndDate.Value = _customer.ContractEndDate;
            
            // Load additional addresses into the list box
            foreach (string address in _customer.AdditionalAddresses)
            {
                lstAdditionalAddresses.Items.Add(address);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompanyName.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtPrimaryAddress.Text))
            {
                MessageBox.Show("Primary address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrimaryAddress.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtContactName.Text))
            {
                MessageBox.Show("Contact name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactName.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtContactEmail.Text))
            {
                MessageBox.Show("Contact email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactEmail.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtContactPhone.Text))
            {
                MessageBox.Show("Contact phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactPhone.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtContractNumber.Text))
            {
                MessageBox.Show("Contract number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContractNumber.Focus();
                return;
            }
            
            // Save the customer data
            _customer.CompanyName = txtCompanyName.Text;
            _customer.PrimaryAddress = txtPrimaryAddress.Text;
            _customer.ContactName = txtContactName.Text;
            _customer.ContactEmail = txtContactEmail.Text;
            _customer.ContactPhone = txtContactPhone.Text;
            _customer.ContractNumber = txtContractNumber.Text;
            _customer.ContractSignDate = dtpContractSignDate.Value;
            _customer.ContractStartDate = dtpContractStartDate.Value;
            _customer.ContractEndDate = dtpContractEndDate.Value;
            
            // Save additional addresses
            _customer.AdditionalAddresses.Clear();
            foreach (string address in lstAdditionalAddresses.Items)
            {
                _customer.AdditionalAddresses.Add(address);
            }
            
            // If this is a new customer, set the onboarding start date
            if (_isNewCustomer)
            {
                _customer.OnboardingStartDate = DateTime.Now;
                _customer.OnboardingStatus = "In Progress";
            }
            
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
        
        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            // Add the address to the list if it's not empty
            if (!string.IsNullOrWhiteSpace(txtAdditionalAddress.Text))
            {
                lstAdditionalAddresses.Items.Add(txtAdditionalAddress.Text);
                txtAdditionalAddress.Clear();
                txtAdditionalAddress.Focus();
            }
        }
        
        private void btnRemoveAddress_Click(object sender, EventArgs e)
        {
            // Remove the selected address from the list
            if (lstAdditionalAddresses.SelectedIndex >= 0)
            {
                lstAdditionalAddresses.Items.RemoveAt(lstAdditionalAddresses.SelectedIndex);
            }
        }
    }
}
