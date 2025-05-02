namespace CustomerOnboardingWorkflow
{
    partial class HostingForm
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
            this.chkNewHosting = new System.Windows.Forms.CheckBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHostingType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveWebsite = new System.Windows.Forms.Button();
            this.btnAddWebsite = new System.Windows.Forms.Button();
            this.lstWebsites = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.nudTotalDatabases = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTotalWebsites = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlEmailHosting = new System.Windows.Forms.Panel();
            this.nudTotalMailboxes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkIncludesEmailHosting = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlDns = new System.Windows.Forms.Panel();
            this.txtDnsProvider = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkDnsConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnlSsl = new System.Windows.Forms.Panel();
            this.dtpSslExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSslRequired = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlBackup = new System.Windows.Forms.Panel();
            this.txtBackupSchedule = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkBackupConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pnlMonitoring = new System.Windows.Forms.Panel();
            this.txtMonitoringNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkMonitoringConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pnlDocumentation = new System.Windows.Forms.Panel();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDocumentationLocation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkHostingDocumented = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalWebsites)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnlEmailHosting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalMailboxes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.pnlDns.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlSsl.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlBackup.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlMonitoring.SuspendLayout();
            this.groupBox8.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(201, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hosting Setup";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNewHosting);
            this.groupBox1.Controls.Add(this.txtProvider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboHostingType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hosting Information";
            // 
            // chkNewHosting
            // 
            this.chkNewHosting.AutoSize = true;
            this.chkNewHosting.Location = new System.Drawing.Point(20, 85);
            this.chkNewHosting.Name = "chkNewHosting";
            this.chkNewHosting.Size = new System.Drawing.Size(121, 24);
            this.chkNewHosting.TabIndex = 4;
            this.chkNewHosting.Text = "New Hosting";
            this.chkNewHosting.UseVisualStyleBackColor = true;
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(90, 55);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(350, 27);
            this.txtProvider.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provider:";
            // 
            // cboHostingType
            // 
            this.cboHostingType.FormattingEnabled = true;
            this.cboHostingType.Items.AddRange(new object[] {
            "Shared Hosting",
            "VPS",
            "Dedicated Server",
            "Cloud Hosting",
            "Managed WordPress",
            "Other"});
            this.cboHostingType.Location = new System.Drawing.Point(90, 25);
            this.cboHostingType.Name = "cboHostingType";
            this.cboHostingType.Size = new System.Drawing.Size(200, 28);
            this.cboHostingType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveWebsite);
            this.groupBox2.Controls.Add(this.btnAddWebsite);
            this.groupBox2.Controls.Add(this.lstWebsites);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtWebsite);
            this.groupBox2.Controls.Add(this.nudTotalDatabases);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudTotalWebsites);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(495, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Websites and Databases";
            // 
            // btnRemoveWebsite
            // 
            this.btnRemoveWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveWebsite.FlatAppearance.BorderSize = 0;
            this.btnRemoveWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveWebsite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveWebsite.ForeColor = System.Drawing.Color.White;
            this.btnRemoveWebsite.Location = new System.Drawing.Point(385, 160);
            this.btnRemoveWebsite.Name = "btnRemoveWebsite";
            this.btnRemoveWebsite.Size = new System.Drawing.Size(70, 29);
            this.btnRemoveWebsite.TabIndex = 8;
            this.btnRemoveWebsite.Text = "-";
            this.btnRemoveWebsite.UseVisualStyleBackColor = false;
            this.btnRemoveWebsite.Click += new System.EventHandler(this.btnRemoveWebsite_Click);
            // 
            // btnAddWebsite
            // 
            this.btnAddWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddWebsite.FlatAppearance.BorderSize = 0;
            this.btnAddWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWebsite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddWebsite.ForeColor = System.Drawing.Color.White;
            this.btnAddWebsite.Location = new System.Drawing.Point(385, 125);
            this.btnAddWebsite.Name = "btnAddWebsite";
            this.btnAddWebsite.Size = new System.Drawing.Size(70, 29);
            this.btnAddWebsite.TabIndex = 7;
            this.btnAddWebsite.Text = "+";
            this.btnAddWebsite.UseVisualStyleBackColor = false;
            this.btnAddWebsite.Click += new System.EventHandler(this.btnAddWebsite_Click);
            // 
            // lstWebsites
            // 
            this.lstWebsites.FormattingEnabled = true;
            this.lstWebsites.ItemHeight = 20;
            this.lstWebsites.Location = new System.Drawing.Point(20, 155);
            this.lstWebsites.Name = "lstWebsites";
            this.lstWebsites.Size = new System.Drawing.Size(360, 24);
            this.lstWebsites.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Websites:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(100, 127);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(280, 27);
            this.txtWebsite.TabIndex = 4;
            // 
            // nudTotalDatabases
            // 
            this.nudTotalDatabases.Location = new System.Drawing.Point(150, 60);
            this.nudTotalDatabases.Name = "nudTotalDatabases";
            this.nudTotalDatabases.Size = new System.Drawing.Size(70, 27);
            this.nudTotalDatabases.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Databases:";
            // 
            // nudTotalWebsites
            // 
            this.nudTotalWebsites.Location = new System.Drawing.Point(150, 25);
            this.nudTotalWebsites.Name = "nudTotalWebsites";
            this.nudTotalWebsites.Size = new System.Drawing.Size(70, 27);
            this.nudTotalWebsites.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Websites:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlEmailHosting);
            this.groupBox3.Controls.Add(this.chkIncludesEmailHosting);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email Hosting";
            // 
            // pnlEmailHosting
            // 
            this.pnlEmailHosting.Controls.Add(this.nudTotalMailboxes);
            this.pnlEmailHosting.Controls.Add(this.label7);
            this.pnlEmailHosting.Enabled = false;
            this.pnlEmailHosting.Location = new System.Drawing.Point(20, 55);
            this.pnlEmailHosting.Name = "pnlEmailHosting";
            this.pnlEmailHosting.Size = new System.Drawing.Size(425, 35);
            this.pnlEmailHosting.TabIndex = 1;
            // 
            // nudTotalMailboxes
            // 
            this.nudTotalMailboxes.Location = new System.Drawing.Point(130, 5);
            this.nudTotalMailboxes.Name = "nudTotalMailboxes";
            this.nudTotalMailboxes.Size = new System.Drawing.Size(70, 27);
            this.nudTotalMailboxes.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Mailboxes:";
            // 
            // chkIncludesEmailHosting
            // 
            this.chkIncludesEmailHosting.AutoSize = true;
            this.chkIncludesEmailHosting.Location = new System.Drawing.Point(20, 26);
            this.chkIncludesEmailHosting.Name = "chkIncludesEmailHosting";
            this.chkIncludesEmailHosting.Size = new System.Drawing.Size(186, 24);
            this.chkIncludesEmailHosting.TabIndex = 0;
            this.chkIncludesEmailHosting.Text = "Includes Email Hosting";
            this.chkIncludesEmailHosting.UseVisualStyleBackColor = true;
            this.chkIncludesEmailHosting.CheckedChanged += new System.EventHandler(this.chkIncludesEmailHosting_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlDns);
            this.groupBox4.Controls.Add(this.chkDnsConfigured);
            this.groupBox4.Location = new System.Drawing.Point(12, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DNS";
            // 
            // pnlDns
            // 
            this.pnlDns.Controls.Add(this.txtDnsProvider);
            this.pnlDns.Controls.Add(this.label8);
            this.pnlDns.Enabled = false;
            this.pnlDns.Location = new System.Drawing.Point(20, 55);
            this.pnlDns.Name = "pnlDns";
            this.pnlDns.Size = new System.Drawing.Size(425, 35);
            this.pnlDns.TabIndex = 1;
            // 
            // txtDnsProvider
            // 
            this.txtDnsProvider.Location = new System.Drawing.Point(70, 5);
            this.txtDnsProvider.Name = "txtDnsProvider";
            this.txtDnsProvider.Size = new System.Drawing.Size(350, 27);
            this.txtDnsProvider.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Provider:";
            // 
            // chkDnsConfigured
            // 
            this.chkDnsConfigured.AutoSize = true;
            this.chkDnsConfigured.Location = new System.Drawing.Point(20, 26);
            this.chkDnsConfigured.Name = "chkDnsConfigured";
            this.chkDnsConfigured.Size = new System.Drawing.Size(143, 24);
            this.chkDnsConfigured.TabIndex = 0;
            this.chkDnsConfigured.Text = "DNS Configured";
            this.chkDnsConfigured.UseVisualStyleBackColor = true;
            this.chkDnsConfigured.CheckedChanged += new System.EventHandler(this.chkDnsConfigured_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pnlSsl);
            this.groupBox5.Controls.Add(this.chkSslRequired);
            this.groupBox5.Location = new System.Drawing.Point(495, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(465, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SSL";
            // 
            // pnlSsl
            // 
            this.pnlSsl.Controls.Add(this.dtpSslExpirationDate);
            this.pnlSsl.Controls.Add(this.label9);
            this.pnlSsl.Enabled = false;
            this.pnlSsl.Location = new System.Drawing.Point(20, 55);
            this.pnlSsl.Name = "pnlSsl";
            this.pnlSsl.Size = new System.Drawing.Size(425, 35);
            this.pnlSsl.TabIndex = 1;
            // 
            // dtpSslExpirationDate
            // 
            this.dtpSslExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSslExpirationDate.Location = new System.Drawing.Point(125, 5);
            this.dtpSslExpirationDate.Name = "dtpSslExpirationDate";
            this.dtpSslExpirationDate.Size = new System.Drawing.Size(125, 27);
            this.dtpSslExpirationDate.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Expiration Date:";
            // 
            // chkSslRequired
            // 
            this.chkSslRequired.AutoSize = true;
            this.chkSslRequired.Location = new System.Drawing.Point(20, 26);
            this.chkSslRequired.Name = "chkSslRequired";
            this.chkSslRequired.Size = new System.Drawing.Size(122, 24);
            this.chkSslRequired.TabIndex = 0;
            this.chkSslRequired.Text = "SSL Required";
            this.chkSslRequired.UseVisualStyleBackColor = true;
            this.chkSslRequired.CheckedChanged += new System.EventHandler(this.chkSslRequired_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pnlBackup);
            this.groupBox6.Controls.Add(this.chkBackupConfigured);
            this.groupBox6.Location = new System.Drawing.Point(495, 390);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(465, 100);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Backup";
            // 
            // pnlBackup
            // 
            this.pnlBackup.Controls.Add(this.txtBackupSchedule);
            this.pnlBackup.Controls.Add(this.label10);
            this.pnlBackup.Enabled = false;
            this.pnlBackup.Location = new System.Drawing.Point(20, 55);
            this.pnlBackup.Name = "pnlBackup";
            this.pnlBackup.Size = new System.Drawing.Size(425, 35);
            this.pnlBackup.TabIndex = 1;
            // 
            // txtBackupSchedule
            // 
            this.txtBackupSchedule.Location = new System.Drawing.Point(80, 5);
            this.txtBackupSchedule.Name = "txtBackupSchedule";
            this.txtBackupSchedule.Size = new System.Drawing.Size(340, 27);
            this.txtBackupSchedule.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Schedule:";
            // 
            // chkBackupConfigured
            // 
            this.chkBackupConfigured.AutoSize = true;
            this.chkBackupConfigured.Location = new System.Drawing.Point(20, 26);
            this.chkBackupConfigured.Name = "chkBackupConfigured";
            this.chkBackupConfigured.Size = new System.Drawing.Size(161, 24);
            this.chkBackupConfigured.TabIndex = 0;
            this.chkBackupConfigured.Text = "Backup Configured";
            this.chkBackupConfigured.UseVisualStyleBackColor = true;
            this.chkBackupConfigured.CheckedChanged += new System.EventHandler(this.chkBackupConfigured_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pnlMonitoring);
            this.groupBox7.Controls.Add(this.chkMonitoringConfigured);
            this.groupBox7.Location = new System.Drawing.Point(12, 416);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(465, 100);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Monitoring";
            // 
            // pnlMonitoring
            // 
            this.pnlMonitoring.Controls.Add(this.txtMonitoringNotes);
            this.pnlMonitoring.Controls.Add(this.label11);
            this.pnlMonitoring.Enabled = false;
            this.pnlMonitoring.Location = new System.Drawing.Point(20, 55);
            this.pnlMonitoring.Name = "pnlMonitoring";
            this.pnlMonitoring.Size = new System.Drawing.Size(425, 35);
            this.pnlMonitoring.TabIndex = 1;
            // 
            // txtMonitoringNotes
            // 
            this.txtMonitoringNotes.Location = new System.Drawing.Point(70, 5);
            this.txtMonitoringNotes.Name = "txtMonitoringNotes";
            this.txtMonitoringNotes.Size = new System.Drawing.Size(350, 27);
            this.txtMonitoringNotes.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Notes:";
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
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pnlDocumentation);
            this.groupBox8.Controls.Add(this.chkHostingDocumented);
            this.groupBox8.Location = new System.Drawing.Point(12, 522);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(948, 120);
            this.groupBox8.TabIndex
