namespace CustomerOnboardingWorkflow
{
    partial class NetworkMonitoringForm
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
            this.pnlAccess = new System.Windows.Forms.Panel();
            this.txtVpnCredentials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAccessMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAccessGranted = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlDiscovery = new System.Windows.Forms.Panel();
            this.nudTotalDevices = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDiscoveryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDiscoveryCompleted = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlVulnerabilityReport = new System.Windows.Forms.Panel();
            this.dtpVulnerabilityReportDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.chkVulnerabilitiesReported = new System.Windows.Forms.CheckBox();
            this.pnlVulnerabilities = new System.Windows.Forms.Panel();
            this.nudLowVulnerabilities = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudMediumVulnerabilities = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudHighVulnerabilities = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCriticalVulnerabilities = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkVulnerabilityScanCompleted = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlMonitoring = new System.Windows.Forms.Panel();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.lstMonitoredServices = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMonitoredService = new System.Windows.Forms.TextBox();
            this.txtMonitoringToolsNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkMonitoringToolsInstalled = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnlAlerting = new System.Windows.Forms.Panel();
            this.btnRemoveRecipient = new System.Windows.Forms.Button();
            this.btnAddRecipient = new System.Windows.Forms.Button();
            this.lstAlertRecipients = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAlertRecipient = new System.Windows.Forms.TextBox();
            this.chkAlertingConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlDocumentation = new System.Windows.Forms.Panel();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDocumentationLocation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkNetworkDocumented = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAccess.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlDiscovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDevices)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnlVulnerabilityReport.SuspendLayout();
            this.pnlVulnerabilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowVulnerabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMediumVulnerabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighVulnerabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalVulnerabilities)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.pnlMonitoring.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlAlerting.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(347, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Monitoring Setup";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlAccess);
            this.groupBox1.Controls.Add(this.chkAccessGranted);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Access";
            // 
            // pnlAccess
            // 
            this.pnlAccess.Controls.Add(this.txtVpnCredentials);
            this.pnlAccess.Controls.Add(this.label3);
            this.pnlAccess.Controls.Add(this.cboAccessMethod);
            this.pnlAccess.Controls.Add(this.label2);
            this.pnlAccess.Enabled = false;
            this.pnlAccess.Location = new System.Drawing.Point(20, 55);
            this.pnlAccess.Name = "pnlAccess";
            this.pnlAccess.Size = new System.Drawing.Size(425, 55);
            this.pnlAccess.TabIndex = 1;
            // 
            // txtVpnCredentials
            // 
            this.txtVpnCredentials.Location = new System.Drawing.Point(300, 20);
            this.txtVpnCredentials.Name = "txtVpnCredentials";
            this.txtVpnCredentials.Size = new System.Drawing.Size(125, 27);
            this.txtVpnCredentials.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credentials:";
            // 
            // cboAccessMethod
            // 
            this.cboAccessMethod.FormattingEnabled = true;
            this.cboAccessMethod.Items.AddRange(new object[] {
            "VPN",
            "Site-to-Site",
            "Direct",
            "Remote Desktop",
            "Other"});
            this.cboAccessMethod.Location = new System.Drawing.Point(70, 20);
            this.cboAccessMethod.Name = "cboAccessMethod";
            this.cboAccessMethod.Size = new System.Drawing.Size(125, 28);
            this.cboAccessMethod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Method:";
            // 
            // chkAccessGranted
            // 
            this.chkAccessGranted.AutoSize = true;
            this.chkAccessGranted.Location = new System.Drawing.Point(20, 26);
            this.chkAccessGranted.Name = "chkAccessGranted";
            this.chkAccessGranted.Size = new System.Drawing.Size(135, 24);
            this.chkAccessGranted.TabIndex = 0;
            this.chkAccessGranted.Text = "Access Granted";
            this.chkAccessGranted.UseVisualStyleBackColor = true;
            this.chkAccessGranted.CheckedChanged += new System.EventHandler(this.chkAccessGranted_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlDiscovery);
            this.groupBox2.Controls.Add(this.chkDiscoveryCompleted);
            this.groupBox2.Location = new System.Drawing.Point(495, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discovery";
            // 
            // pnlDiscovery
            // 
            this.pnlDiscovery.Controls.Add(this.nudTotalDevices);
            this.pnlDiscovery.Controls.Add(this.label5);
            this.pnlDiscovery.Controls.Add(this.dtpDiscoveryDate);
            this.pnlDiscovery.Controls.Add(this.label4);
            this.pnlDiscovery.Enabled = false;
            this.pnlDiscovery.Location = new System.Drawing.Point(20, 55);
            this.pnlDiscovery.Name = "pnlDiscovery";
            this.pnlDiscovery.Size = new System.Drawing.Size(425, 55);
            this.pnlDiscovery.TabIndex = 1;
            // 
            // nudTotalDevices
            // 
            this.nudTotalDevices.Location = new System.Drawing.Point(350, 20);
            this.nudTotalDevices.Name = "nudTotalDevices";
            this.nudTotalDevices.Size = new System.Drawing.Size(70, 27);
            this.nudTotalDevices.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Devices:";
            // 
            // dtpDiscoveryDate
            // 
            this.dtpDiscoveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiscoveryDate.Location = new System.Drawing.Point(55, 20);
            this.dtpDiscoveryDate.Name = "dtpDiscoveryDate";
            this.dtpDiscoveryDate.Size = new System.Drawing.Size(125, 27);
            this.dtpDiscoveryDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date:";
            // 
            // chkDiscoveryCompleted
            // 
            this.chkDiscoveryCompleted.AutoSize = true;
            this.chkDiscoveryCompleted.Location = new System.Drawing.Point(20, 26);
            this.chkDiscoveryCompleted.Name = "chkDiscoveryCompleted";
            this.chkDiscoveryCompleted.Size = new System.Drawing.Size(177, 24);
            this.chkDiscoveryCompleted.TabIndex = 0;
            this.chkDiscoveryCompleted.Text = "Discovery Completed";
            this.chkDiscoveryCompleted.UseVisualStyleBackColor = true;
            this.chkDiscoveryCompleted.CheckedChanged += new System.EventHandler(this.chkDiscoveryCompleted_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlVulnerabilityReport);
            this.groupBox3.Controls.Add(this.chkVulnerabilitiesReported);
            this.groupBox3.Controls.Add(this.pnlVulnerabilities);
            this.groupBox3.Controls.Add(this.chkVulnerabilityScanCompleted);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 200);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vulnerabilities";
            // 
            // pnlVulnerabilityReport
            // 
            this.pnlVulnerabilityReport.Controls.Add(this.dtpVulnerabilityReportDate);
            this.pnlVulnerabilityReport.Controls.Add(this.label10);
            this.pnlVulnerabilityReport.Enabled = false;
            this.pnlVulnerabilityReport.Location = new System.Drawing.Point(20, 155);
            this.pnlVulnerabilityReport.Name = "pnlVulnerabilityReport";
            this.pnlVulnerabilityReport.Size = new System.Drawing.Size(425, 35);
            this.pnlVulnerabilityReport.TabIndex = 3;
            // 
            // dtpVulnerabilityReportDate
            // 
            this.dtpVulnerabilityReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVulnerabilityReportDate.Location = new System.Drawing.Point(110, 5);
            this.dtpVulnerabilityReportDate.Name = "dtpVulnerabilityReportDate";
            this.dtpVulnerabilityReportDate.Size = new System.Drawing.Size(125, 27);
            this.dtpVulnerabilityReportDate.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Report Date:";
            // 
            // chkVulnerabilitiesReported
            // 
            this.chkVulnerabilitiesReported.AutoSize = true;
            this.chkVulnerabilitiesReported.Location = new System.Drawing.Point(20, 125);
            this.chkVulnerabilitiesReported.Name = "chkVulnerabilitiesReported";
            this.chkVulnerabilitiesReported.Size = new System.Drawing.Size(195, 24);
            this.chkVulnerabilitiesReported.TabIndex = 2;
            this.chkVulnerabilitiesReported.Text = "Vulnerabilities Reported";
            this.chkVulnerabilitiesReported.UseVisualStyleBackColor = true;
            this.chkVulnerabilitiesReported.CheckedChanged += new System.EventHandler(this.chkVulnerabilitiesReported_CheckedChanged);
            // 
            // pnlVulnerabilities
            // 
            this.pnlVulnerabilities.Controls.Add(this.nudLowVulnerabilities);
            this.pnlVulnerabilities.Controls.Add(this.label9);
            this.pnlVulnerabilities.Controls.Add(this.nudMediumVulnerabilities);
            this.pnlVulnerabilities.Controls.Add(this.label8);
            this.pnlVulnerabilities.Controls.Add(this.nudHighVulnerabilities);
            this.pnlVulnerabilities.Controls.Add(this.label7);
            this.pnlVulnerabilities.Controls.Add(this.nudCriticalVulnerabilities);
            this.pnlVulnerabilities.Controls.Add(this.label6);
            this.pnlVulnerabilities.Enabled = false;
            this.pnlVulnerabilities.Location = new System.Drawing.Point(20, 55);
            this.pnlVulnerabilities.Name = "pnlVulnerabilities";
            this.pnlVulnerabilities.Size = new System.Drawing.Size(425, 65);
            this.pnlVulnerabilities.TabIndex = 1;
            // 
            // nudLowVulnerabilities
            // 
            this.nudLowVulnerabilities.Location = new System.Drawing.Point(350, 35);
            this.nudLowVulnerabilities.Name = "nudLowVulnerabilities";
            this.nudLowVulnerabilities.Size = new System.Drawing.Size(70, 27);
            this.nudLowVulnerabilities.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Low:";
            // 
            // nudMediumVulnerabilities
            // 
            this.nudMediumVulnerabilities.Location = new System.Drawing.Point(230, 35);
            this.nudMediumVulnerabilities.Name = "nudMediumVulnerabilities";
            this.nudMediumVulnerabilities.Size = new System.Drawing.Size(70, 27);
            this.nudMediumVulnerabilities.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Medium:";
            // 
            // nudHighVulnerabilities
            // 
            this.nudHighVulnerabilities.Location = new System.Drawing.Point(85, 35);
            this.nudHighVulnerabilities.Name = "nudHighVulnerabilities";
            this.nudHighVulnerabilities.Size = new System.Drawing.Size(70, 27);
            this.nudHighVulnerabilities.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "High:";
            // 
            // nudCriticalVulnerabilities
            // 
            this.nudCriticalVulnerabilities.Location = new System.Drawing.Point(350, 5);
            this.nudCriticalVulnerabilities.Name = "nudCriticalVulnerabilities";
            this.nudCriticalVulnerabilities.Size = new System.Drawing.Size(70, 27);
            this.nudCriticalVulnerabilities.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number of vulnerabilities by severity level - Critical:";
            // 
            // chkVulnerabilityScanCompleted
            // 
            this.chkVulnerabilityScanCompleted.AutoSize = true;
            this.chkVulnerabilityScanCompleted.Location = new System.Drawing.Point(20, 26);
            this.chkVulnerabilityScanCompleted.Name = "chkVulnerabilityScanCompleted";
            this.chkVulnerabilityScanCompleted.Size = new System.Drawing.Size(233, 24);
            this.chkVulnerabilityScanCompleted.TabIndex = 0;
            this.chkVulnerabilityScanCompleted.Text = "Vulnerability Scan Completed";
            this.chkVulnerabilityScanCompleted.UseVisualStyleBackColor = true;
            this.chkVulnerabilityScanCompleted.CheckedChanged += new System.EventHandler(this.chkVulnerabilityScanCompleted_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlMonitoring);
            this.groupBox4.Controls.Add(this.chkMonitoringToolsInstalled);
            this.groupBox4.Location = new System.Drawing.Point(495, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 200);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monitoring Setup";
            // 
            // pnlMonitoring
            // 
            this.pnlMonitoring.Controls.Add(this.btnRemoveService);
            this.pnlMonitoring.Controls.Add(this.btnAddService);
            this.pnlMonitoring.Controls.Add(this.lstMonitoredServices);
            this.pnlMonitoring.Controls.Add(this.label12);
            this.pnlMonitoring.Controls.Add(this.txtMonitoredService);
            this.pnlMonitoring.Controls.Add(this.txtMonitoringToolsNotes);
            this.pnlMonitoring.Controls.Add(this.label11);
            this.pnlMonitoring.Enabled = false;
            this.pnlMonitoring.Location = new System.Drawing.Point(20, 55);
            this.pnlMonitoring.Name = "pnlMonitoring";
            this.pnlMonitoring.Size = new System.Drawing.Size(425, 135);
            this.pnlMonitoring.TabIndex = 1;
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveService.FlatAppearance.BorderSize = 0;
            this.btnRemoveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveService.ForeColor = System.Drawing.Color.White;
            this.btnRemoveService.Location = new System.Drawing.Point(350, 100);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(70, 29);
            this.btnRemoveService.TabIndex = 6;
            this.btnRemoveService.Text = "-";
            this.btnRemoveService.UseVisualStyleBackColor = false;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(350, 65);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(70, 29);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "+";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // lstMonitoredServices
            // 
            this.lstMonitoredServices.FormattingEnabled = true;
            this.lstMonitoredServices.ItemHeight = 20;
            this.lstMonitoredServices.Location = new System.Drawing.Point(5, 95);
            this.lstMonitoredServices.Name = "lstMonitoredServices";
            this.lstMonitoredServices.Size = new System.Drawing.Size(340, 24);
            this.lstMonitoredServices.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Monitored Services:";
            // 
            // txtMonitoredService
            // 
            this.txtMonitoredService.Location = new System.Drawing.Point(150, 67);
            this.txtMonitoredService.Name = "txtMonitoredService";
            this.txtMonitoredService.Size = new System.Drawing.Size(195, 27);
            this.txtMonitoredService.TabIndex = 2;
            // 
            // txtMonitoringToolsNotes
            // 
            this.txtMonitoringToolsNotes.Location = new System.Drawing.Point(5, 30);
            this.txtMonitoringToolsNotes.Name = "txtMonitoringToolsNotes";
            this.txtMonitoringToolsNotes.Size = new System.Drawing.Size(415, 27);
            this.txtMonitoringToolsNotes.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Monitoring Tools Notes:";
            // 
            // chkMonitoringToolsInstalled
            // 
            this.chkMonitoringToolsInstalled.AutoSize = true;
            this.chkMonitoringToolsInstalled.Location = new System.Drawing.Point(20, 26);
            this.chkMonitoringToolsInstalled.Name = "chkMonitoringToolsInstalled";
            this.chkMonitoringToolsInstalled.Size = new System.Drawing.Size(207, 24);
            this.chkMonitoringToolsInstalled.TabIndex = 0;
            this.chkMonitoringToolsInstalled.Text = "Monitoring Tools Installed";
            this.chkMonitoringToolsInstalled.UseVisualStyleBackColor = true;
            this.chkMonitoringToolsInstalled.CheckedChanged += new System.EventHandler(this.chkMonitoringToolsInstalled_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pnlAlerting);
            this.groupBox5.Controls.Add(this.chkAlertingConfigured);
            this.groupBox5.Location = new System.Drawing.Point(12, 410);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(465, 150);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alerting";
            // 
            // pnlAlerting
            // 
            this.pnlAlerting.Controls.Add(this.btnRemoveRecipient);
            this.pnlAlerting.Controls.Add(this.btnAddRecipient);
            this.pnlAlerting.Controls.Add(this.lstAlertRecipients);
            this.pnlAlerting.Controls.Add(this.label13);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Recipient:";
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pnlDocumentation);
            this.groupBox6.Controls.Add(this.chkNetworkDocumented);
            this.groupBox6.Location = new System.Drawing.Point(495, 410);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(465, 150);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Documentation";
            // 
            // pnlDocumentation
            // 
            this.pnlDocumentation.Controls.Add(this.txtAdditionalNotes);
            this.pnlDocumentation.Controls.Add(this.label15);
            this.pnlDocumentation.Controls.Add(this.txtDocumentationLocation);
            this.pnlDocumentation.Controls.Add(this.label14);
            this.pnlDocumentation.Enabled = false;
            this.pnlDocumentation.Location = new System.Drawing.Point(20, 55);
            this.pnlDocumentation.Name = "pnlDocumentation";
            this.pnlDocumentation.Size = new System.Drawing.Size(425, 85);
            this.pnlDocumentation.TabIndex = 1;
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(85, 50);
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.Size = new System.Drawing.Size(335, 27);
            this.txtAdditionalNotes.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Notes:";
            // 
            // txtDocumentationLocation
            // 
            this.txtDocumentationLocation.Location = new System.Drawing.Point(85, 15);
            this.txtDocumentationLocation.Name = "txtDocumentationLocation";
            this.txtDocumentationLocation.Size = new System.Drawing.Size(335, 27);
            this.txtDocumentationLocation.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Location:";
            // 
            // chkNetworkDocumented
            // 
            this.chkNetworkDocumented.AutoSize = true;
            this.chkNetworkDocumented.Location = new System.Drawing.Point(20, 26);
            this.chkNetworkDocumented.Name = "chkNetworkDocumented";
            this.chkNetworkDocumented.Size = new System.Drawing.Size(185, 24);
            this.chkNetworkDocumented.TabIndex = 0;
            this.chkNetworkDocumented.Text = "Network Documented";
            this.chkNetworkDocumented.UseVisualStyleBackColor = true;
            this.chkNetworkDocumented.CheckedChanged += new System.EventHandler(this.chkNetworkDocumented_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(766, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(866, 570);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NetworkMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 613);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkMonitoringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Network Monitoring Setup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAccess.ResumeLayout(false);
            this.pnlAccess.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlDiscovery.ResumeLayout(false);
            this.pnlDiscovery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDevices)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlVulnerabilityReport.ResumeLayout(false);
            this.pnlVulnerabilityReport.PerformLayout();
            this.pnlVulnerabilities.ResumeLayout(false);
            this.pnlVulnerabilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowVulnerabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMediumVulnerabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighVulnerabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalVulnerabilities)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlMonitoring.ResumeLayout(false);
            this.pnlMonitoring.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pnlAlerting.ResumeLayout(false);
            this.pnlAlerting.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pnlDocumentation.ResumeLayout(false);
            this.pnlDocumentation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlAccess;
        private System.Windows.Forms.TextBox txtVpnCredentials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAccessMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAccessGranted;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlDiscovery;
        private System.Windows.Forms.NumericUpDown nudTotalDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDiscoveryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDiscoveryCompleted;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlVulnerabilityReport;
        private System.Windows.Forms.DateTimePicker dtpVulnerabilityReportDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkVulnerabilitiesReported;
        private System.Windows.Forms.Panel pnlVulnerabilities;
        private System.Windows.Forms.NumericUpDown nudLowVulnerabilities;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMediumVulnerabilities;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudHighVulnerabilities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCriticalVulnerabilities;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkVulnerabilityScanCompleted;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlMonitoring;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ListBox lstMonitoredServices;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMonitoredService;
        private System.Windows.Forms.TextBox txtMonitoringToolsNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkMonitoringToolsInstalled;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel pnlAlerting;
        private System.Windows.Forms.Button btnRemoveRecipient;
        private System.Windows.Forms.Button btnAddRecipient;
        private System.Windows.Forms.ListBox lstAlertRecipients;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAlertRecipient;
        private System.Windows.Forms.CheckBox chkAlertingConfigured;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel pnlDocumentation;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDocumentationLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkNetworkDocumented;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
