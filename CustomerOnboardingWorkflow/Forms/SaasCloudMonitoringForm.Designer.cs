namespace CustomerOnboardingWorkflow
{
    partial class SaasCloudMonitoringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSaasInventory = new System.Windows.Forms.Panel();
            this.btnRemoveSaasApplication = new System.Windows.Forms.Button();
            this.btnAddSaasApplication = new System.Windows.Forms.Button();
            this.lstSaasApplications = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaasApplication = new System.Windows.Forms.TextBox();
            this.nudTotalSaasApplications = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInventoryComplete = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlCloudInventory = new System.Windows.Forms.Panel();
            this.btnRemoveCloudService = new System.Windows.Forms.Button();
            this.btnAddCloudService = new System.Windows.Forms.Button();
            this.lstCloudServices = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCloudService = new System.Windows.Forms.TextBox();
            this.nudTotalCloudServices = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCloudInventoryComplete = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlMonitoring = new System.Windows.Forms.Panel();
            this.txtMonitoringNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkMonitoringConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlAlerting = new System.Windows.Forms.Panel();
            this.btnRemoveRecipient = new System.Windows.Forms.Button();
            this.btnAddRecipient = new System.Windows.Forms.Button();
            this.lstAlertRecipients = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlertRecipient = new System.Windows.Forms.TextBox();
            this.chkAlertingConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnlSecurityAssessment = new System.Windows.Forms.Panel();
            this.dtpSecurityAssessmentDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.chkSecurityAssessmentComplete = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlDocumentation = new System.Windows.Forms.Panel();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocumentationLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkServicesDocumented = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSaasInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSaasApplications)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlCloudInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalCloudServices)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnlMonitoring.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlAlerting.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlSecurityAssessment.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlDocumentation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SaaS/Cloud Monitoring Setup";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlSaasInventory);
            this.groupBox1.Controls.Add(this.chkInventoryComplete);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SaaS Applications Inventory";
            // 
            // pnlSaasInventory
            // 
            this.pnlSaasInventory.Controls.Add(this.btnRemoveSaasApplication);
            this.pnlSaasInventory.Controls.Add(this.btnAddSaasApplication);
            this.pnlSaasInventory.Controls.Add(this.lstSaasApplications);
            this.pnlSaasInventory.Controls.Add(this.label3);
            this.pnlSaasInventory.Controls.Add(this.txtSaasApplication);
            this.pnlSaasInventory.Controls.Add(this.nudTotalSaasApplications);
            this.pnlSaasInventory.Controls.Add(this.label2);
            this.pnlSaasInventory.Enabled = false;
            this.pnlSaasInventory.Location = new System.Drawing.Point(20, 55);
            this.pnlSaasInventory.Name = "pnlSaasInventory";
            this.pnlSaasInventory.Size = new System.Drawing.Size(425, 135);
            this.pnlSaasInventory.TabIndex = 1;
            // 
            // btnRemoveSaasApplication
            // 
            this.btnRemoveSaasApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveSaasApplication.FlatAppearance.BorderSize = 0;
            this.btnRemoveSaasApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSaasApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSaasApplication.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSaasApplication.Location = new System.Drawing.Point(350, 100);
            this.btnRemoveSaasApplication.Name = "btnRemoveSaasApplication";
            this.btnRemoveSaasApplication.Size = new System.Drawing.Size(70, 29);
            this.btnRemoveSaasApplication.TabIndex = 6;
            this.btnRemoveSaasApplication.Text = "-";
            this.btnRemoveSaasApplication.UseVisualStyleBackColor = false;
            this.btnRemoveSaasApplication.Click += new System.EventHandler(this.btnRemoveSaasApplication_Click);
            // 
            // btnAddSaasApplication
            // 
            this.btnAddSaasApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddSaasApplication.FlatAppearance.BorderSize = 0;
            this.btnAddSaasApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSaasApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSaasApplication.ForeColor = System.Drawing.Color.White;
            this.btnAddSaasApplication.Location = new System.Drawing.Point(350, 65);
            this.btnAddSaasApplication.Name = "btnAddSaasApplication";
            this.btnAddSaasApplication.Size = new System.Drawing.Size(70, 29);
            this.btnAddSaasApplication.TabIndex = 5;
            this.btnAddSaasApplication.Text = "+";
            this.btnAddSaasApplication.UseVisualStyleBackColor = false;
            this.btnAddSaasApplication.Click += new System.EventHandler(this.btnAddSaasApplication_Click);
            // 
            // lstSaasApplications
            // 
            this.lstSaasApplications.FormattingEnabled = true;
            this.lstSaasApplications.ItemHeight = 20;
            this.lstSaasApplications.Location = new System.Drawing.Point(5, 95);
            this.lstSaasApplications.Name = "lstSaasApplications";
            this.lstSaasApplications.Size = new System.Drawing.Size(340, 24);
            this.lstSaasApplications.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Applications:";
            // 
            // txtSaasApplication
            // 
            this.txtSaasApplication.Location = new System.Drawing.Point(105, 67);
            this.txtSaasApplication.Name = "txtSaasApplication";
            this.txtSaasApplication.Size = new System.Drawing.Size(240, 27);
            this.txtSaasApplication.TabIndex = 2;
            // 
            // nudTotalSaasApplications
            // 
            this.nudTotalSaasApplications.Location = new System.Drawing.Point(125, 20);
            this.nudTotalSaasApplications.Name = "nudTotalSaasApplications";
            this.nudTotalSaasApplications.Size = new System.Drawing.Size(70, 27);
            this.nudTotalSaasApplications.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Applications:";
            // 
            // chkInventoryComplete
            // 
            this.chkInventoryComplete.AutoSize = true;
            this.chkInventoryComplete.Location = new System.Drawing.Point(20, 26);
            this.chkInventoryComplete.Name = "chkInventoryComplete";
            this.chkInventoryComplete.Size = new System.Drawing.Size(164, 24);
            this.chkInventoryComplete.TabIndex = 0;
            this.chkInventoryComplete.Text = "Inventory Complete";
            this.chkInventoryComplete.UseVisualStyleBackColor = true;
            this.chkInventoryComplete.CheckedChanged += new System.EventHandler(this.chkInventoryComplete_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlCloudInventory);
            this.groupBox2.Controls.Add(this.chkCloudInventoryComplete);
            this.groupBox2.Location = new System.Drawing.Point(495, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cloud Services Inventory";
            // 
            // pnlCloudInventory
            // 
            this.pnlCloudInventory.Controls.Add(this.btnRemoveCloudService);
            this.pnlCloudInventory.Controls.Add(this.btnAddCloudService);
            this.pnlCloudInventory.Controls.Add(this.lstCloudServices);
            this.pnlCloudInventory.Controls.Add(this.label5);
            this.pnlCloudInventory.Controls.Add(this.txtCloudService);
            this.pnlCloudInventory.Controls.Add(this.nudTotalCloudServices);
            this.pnlCloudInventory.Controls.Add(this.label4);
            this.pnlCloudInventory.Enabled = false;
            this.pnlCloudInventory.Location = new System.Drawing.Point(20, 55);
            this.pnlCloudInventory.Name = "pnlCloudInventory";
            this.pnlCloudInventory.Size = new System.Drawing.Size(425, 135);
            this.pnlCloudInventory.TabIndex = 1;
            // 
            // btnRemoveCloudService
            // 
            this.btnRemoveCloudService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveCloudService.FlatAppearance.BorderSize = 0;
            this.btnRemoveCloudService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCloudService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCloudService.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCloudService.Location = new System.Drawing.Point(350, 100);
            this.btnRemoveCloudService.Name = "btnRemoveCloudService";
            this.btnRemoveCloudService.Size = new System.Drawing.Size(70, 29);
            this.btnRemoveCloudService.TabIndex = 6;
            this.btnRemoveCloudService.Text = "-";
            this.btnRemoveCloudService.UseVisualStyleBackColor = false;
            this.btnRemoveCloudService.Click += new System.EventHandler(this.btnRemoveCloudService_Click);
            // 
            // btnAddCloudService
            // 
            this.btnAddCloudService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddCloudService.FlatAppearance.BorderSize = 0;
            this.btnAddCloudService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCloudService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCloudService.ForeColor = System.Drawing.Color.White;
            this.btnAddCloudService.Location = new System.Drawing.Point(350, 65);
            this.btnAddCloudService.Name = "btnAddCloudService";
            this.btnAddCloudService.Size = new System.Drawing.Size(70, 29);
            this.btnAddCloudService.TabIndex = 5;
            this.btnAddCloudService.Text = "+";
            this.btnAddCloudService.UseVisualStyleBackColor = false;
            this.btnAddCloudService.Click += new System.EventHandler(this.btnAddCloudService_Click);
            // 
            // lstCloudServices
            // 
            this.lstCloudServices.FormattingEnabled = true;
            this.lstCloudServices.ItemHeight = 20;
            this.lstCloudServices.Location = new System.Drawing.Point(5, 95);
            this.lstCloudServices.Name = "lstCloudServices";
            this.lstCloudServices.Size = new System.Drawing.Size(340, 24);
            this.lstCloudServices.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Services:";
            // 
            // txtCloudService
            // 
            this.txtCloudService.Location = new System.Drawing.Point(75, 67);
            this.txtCloudService.Name = "txtCloudService";
            this.txtCloudService.Size = new System.Drawing.Size(270, 27);
            this.txtCloudService.TabIndex = 2;
            // 
            // nudTotalCloudServices
            // 
            this.nudTotalCloudServices.Location = new System.Drawing.Point(125, 20);
            this.nudTotalCloudServices.Name = "nudTotalCloudServices";
            this.nudTotalCloudServices.Size = new System.Drawing.Size(70, 27);
            this.nudTotalCloudServices.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Services:";
            // 
            // chkCloudInventoryComplete
            // 
            this.chkCloudInventoryComplete.AutoSize = true;
            this.chkCloudInventoryComplete.Location = new System.Drawing.Point(20, 26);
            this.chkCloudInventoryComplete.Name = "chkCloudInventoryComplete";
            this.chkCloudInventoryComplete.Size = new System.Drawing.Size(164, 24);
            this.chkCloudInventoryComplete.TabIndex = 0;
            this.chkCloudInventoryComplete.Text = "Inventory Complete";
            this.chkCloudInventoryComplete.UseVisualStyleBackColor = true;
            this.chkCloudInventoryComplete.CheckedChanged += new System.EventHandler(this.chkCloudInventoryComplete_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlMonitoring);
            this.groupBox3.Controls.Add(this.chkMonitoringConfigured);
            this.groupBox3.Location = new System.Drawing.Point(12, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitoring";
            // 
            // pnlMonitoring
            // 
            this.pnlMonitoring.Controls.Add(this.txtMonitoringNotes);
            this.pnlMonitoring.Controls.Add(this.label6);
            this.pnlMonitoring.Enabled = false;
            this.pnlMonitoring.Location = new System.Drawing.Point(20, 55);
            this.pnlMonitoring.Name = "pnlMonitoring";
            this.pnlMonitoring.Size = new System.Drawing.Size(425, 55);
            this.pnlMonitoring.TabIndex = 1;
            // 
            // txtMonitoringNotes
            // 
            this.txtMonitoringNotes.Location = new System.Drawing.Point(70, 20);
            this.txtMonitoringNotes.Name = "txtMonitoringNotes";
            this.txtMonitoringNotes.Size = new System.Drawing.Size(350, 27);
            this.txtMonitoringNotes.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Notes:";
            // 
            // chkMonitoringConfigured
            // 
            this.chkMonitoringConfigured.AutoSize = true;
            this.chkMonitoringConfigured.Location = new System.Drawing.Point(20, 26);
            this.chkMonitoringConfigured.Name = "chkMonitoringConfigured";
            this.chkMonitoringConfigured.Size = new System.Drawing.Size(187, 24);
            this.chkMonitoringConfigured.TabIndex = 0;
            this.chkMonitoringConfigured.Text = "Monitoring Configured";
            this.chkMonitoringConfigured.UseVisualStyleBackColor = true;
            this.chkMonitoringConfigured.CheckedChanged += new System.EventHandler(this.chkMonitoringConfigured_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlAlerting);
            this.groupBox4.Controls.Add(this.chkAlertingConfigured);
            this.groupBox4.Location = new System.Drawing.Point(495, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 150);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alerting";
            // 
            // pnlAlerting
            // 
            this.pnlAlerting.Controls.Add(this.btnRemoveRecipient);
            this.pnlAlerting.Controls.Add(this.btnAddRecipient);
            this.pnlAlerting.Controls.Add(this.lstAlertRecipients);
            this.pnlAlerting.Controls.Add(this.label7);
            this.pnlAlerting.Controls.Add(this.txtAlertRecipient);
            this.pnlAlerting.Enabled = false;
            this.pnlAlerting.Location = new System.Drawing.Point(20, 55);
            this.pnlAlerting.Name = "pnlAlerting";
            this.pnlAlerting.Size = new System.Drawing.Size(425, 85);
            this.pnlAlerting.TabIndex = 1;
            // 
            // btnRemoveRecipient
            // 
            this.btnRemoveRecipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveRecipient.FlatAppearance.BorderSize = 0;
            this.btnRemoveRecipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRecipient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveRecipient.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRecipient.Location = new System.Drawing.Point(350, 50);
            this.btnRemoveRecipient.Name = "btnRemoveRecipient";
            this.btnRemoveRecipient.Size = new System.Drawing.Size(70, 29);
            this.btnRemoveRecipient.TabIndex = 4;
            this.btnRemoveRecipient.Text = "-";
            this.btnRemoveRecipient.UseVisualStyleBackColor = false;
            this.btnRemoveRecipient.Click += new System.EventHandler(this.btnRemoveRecipient_Click);
            // 
            // btnAddRecipient
            // 
            this.btnAddRecipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddRecipient.FlatAppearance.BorderSize = 0;
            this.btnAddRecipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRecipient.ForeColor = System.Drawing.Color.White;
            this.btnAddRecipient.Location = new System.Drawing.Point(350, 15);
            this.btnAddRecipient.Name = "btnAddRecipient";
            this.btnAddRecipient.Size = new System.Drawing.Size(70, 29);
            this.btnAddRecipient.TabIndex = 3;
            this.btnAddRecipient.Text = "+";
            this.btnAddRecipient.UseVisualStyleBackColor = false;
            this.btnAddRecipient.Click += new System.EventHandler(this.btnAddRecipient_Click);
            // 
            // lstAlertRecipients
            // 
            this.lstAlertRecipients.FormattingEnabled = true;
            this.lstAlertRecipients.ItemHeight = 20;
            this.lstAlertRecipients.Location = new System.Drawing.Point(5, 50);
            this.lstAlertRecipients.Name = "lstAlertRecipients";
            this.lstAlertRecipients.Size = new System.Drawing.Size(340, 24);
            this.lstAlertRecipients.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Recipient:";
            // 
            // txtAlertRecipient
            // 
            this.txtAlertRecipient.Location = new System.Drawing.Point(85, 15);
            this.txtAlertRecipient.Name = "txtAlertRecipient";
            this.txtAlertRecipient.Size = new System.Drawing.Size(260, 27);
            this.txtAlertRecipient.TabIndex = 0;
            // 
            // chkAlertingConfigured
            // 
            this.chkAlertingConfigured.AutoSize = true;
            this.chkAlertingConfigured.Location = new System.Drawing.Point(20, 26);
            this.chkAlertingConfigured.Name = "chkAlertingConfigured";
            this.chkAlertingConfigured.Size = new System.Drawing.Size(166, 24);
            this.chkAlertingConfigured.TabIndex = 0;
            this.chkAlertingConfigured.Text = "Alerting Configured";
            this.chkAlertingConfigured.UseVisualStyleBackColor = true;
            this.chkAlertingConfigured.CheckedChanged += new System.EventHandler(this.chkAlertingConfigured_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pnlSecurityAssessment);
            this.groupBox5.Controls.Add(this.chkSecurityAssessmentComplete);
            this.groupBox5.Location = new System.Drawing.Point(12, 410);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(465, 120);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Security Assessment";
            // 
            // pnlSecurityAssessment
