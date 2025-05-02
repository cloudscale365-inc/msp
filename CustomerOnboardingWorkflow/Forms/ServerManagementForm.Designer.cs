namespace CustomerOnboardingWorkflow
{
    partial class ServerManagementForm
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
            this.txtCredentials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAccessMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAccessGranted = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.btnRemoveServerType = new System.Windows.Forms.Button();
            this.btnAddServerType = new System.Windows.Forms.Button();
            this.lstServerTypes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServerType = new System.Windows.Forms.TextBox();
            this.nudCloudServers = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudVirtualServers = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPhysicalServers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTotalServers = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkInventoryComplete = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlMonitoring = new System.Windows.Forms.Panel();
            this.txtMonitoringNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkMonitoringAgentsInstalled = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlBackup = new System.Windows.Forms.Panel();
            this.txtBackupSchedule = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboBackupSolution = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkBackupConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnlPatchManagement = new System.Windows.Forms.Panel();
            this.txtPatchSchedule = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboPatchManagementSolution = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkPatchManagementConfigured = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlSecurityAssessment = new System.Windows.Forms.Panel();
            this.nudLowIssues = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nudMediumIssues = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nudHighIssues = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nudCriticalIssues = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpSecurityAssessmentDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.chkSecurityAssessmentComplete = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pnlDocumentation = new System.Windows.Forms.Panel();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDocumentationLocation = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkServersDocumented = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAccess.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCloudServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVirtualServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhysicalServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalServers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnlMonitoring.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlBackup.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlPatchManagement.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlSecurityAssessment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMediumIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalIssues)).BeginInit();
            this.groupBox7.SuspendLayout();
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
            this.label1.Text = "Server Management Setup";
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
            this.pnlAccess.Controls.Add(this.txtCredentials);
            this.pnlAccess.Controls.Add(this.label3);
            this.pnlAccess.Controls.Add(this.cboAccessMethod);
            this.pnlAccess.Controls.Add(this.label2);
            this.pnlAccess.Enabled = false;
            this.pnlAccess.Location = new System.Drawing.Point(20, 55);
            this.pnlAccess.Name = "pnlAccess";
            this.pnlAccess.Size = new System.Drawing.Size(425, 55);
            this.pnlAccess.TabIndex = 1;
            // 
            // txtCredentials
            // 
            this.txtCredentials.Location = new System.Drawing.Point(300, 20);
            this.txtCredentials.Name = "txtCredentials";
            this.txtCredentials.Size = new System.Drawing.Size(125, 27);
            this.txtCredentials.TabIndex = 3;
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
            "SSH",
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
            this.groupBox2.Controls.Add(this.pnlInventory);
            this.groupBox2.Controls.Add(this.chkInventoryComplete);
            this.groupBox2.Location = new System.Drawing.Point(495, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Inventory";
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.btnRemoveServerType);
            this.pnlInventory.Controls.Add(this.btnAddServerType);
            this.pnlInventory.Controls.Add(this.lstServerTypes);
            this.pnlInventory.Controls.Add(this.label8);
            this.pnlInventory.Controls.Add(this.txtServerType);
            this.pnlInventory.Controls.Add(this.nudCloudServers);
            this.pnlInventory.Controls.Add(this.label7);
            this.pnlInventory.Controls.Add(this.nudVirtualServers);
            this.pnlInventory.Controls.Add(this.label6);
            this.pnlInventory.Controls.Add(this.nudPhysicalServers);
            this.pnlInventory.Controls.Add(this.label5);
            this.pnlInventory.Controls.Add(this.nudTotalServers);
            this.pnlInventory.Controls.Add(this.label4);
            this.pnlInventory.Enabled = false;
            this.pnlInventory.Location = new System.Drawing.Point(20, 55);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(425, 185);
            this.pnlInventory.TabIndex = 1;
            // 
            // btnRemoveServerType
            // 
            this.btnRemoveServerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveServerType.FlatAppearance.BorderSize = 0;
            this.btnRemoveServerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveServerType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveServerType.ForeColor = System.Drawing.Color.White;
            this.btnRemoveServerType.Location = new System.Drawing.Point(350, 150);
            this.btnRemoveServerType.Name = "btnRemoveServerType";
            this.btnRemoveServerType.Size = new System.Drawing.Size(70, 29);
            this.btnRemoveServerType.TabIndex = 12;
            this.btnRemoveServerType.Text = "-";
            this.btnRemoveServerType.UseVisualStyleBackColor = false;
            this.btnRemoveServerType.Click += new System.EventHandler(this.btnRemoveServerType_Click);
            // 
            // btnAddServerType
            // 
            this.btnAddServerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddServerType.FlatAppearance.BorderSize = 0;
            this.btnAddServerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServerType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddServerType.ForeColor = System.Drawing.Color.White;
            this.btnAddServerType.Location = new System.Drawing.Point(350, 115);
            this.btnAddServerType.Name = "btnAddServerType";
            this.btnAddServerType.Size = new System.Drawing.Size(70, 29);
            this.btnAddServerType.TabIndex = 11;
            this.btnAddServerType.Text = "+";
            this.btnAddServerType.UseVisualStyleBackColor = false;
            this.btnAddServerType.Click += new System.EventHandler(this.btnAddServerType_Click);
            // 
            // lstServerTypes
            // 
            this.lstServerTypes.FormattingEnabled = true;
            this.lstServerTypes.ItemHeight = 20;
            this.lstServerTypes.Location = new System.Drawing.Point(5, 145);
            this.lstServerTypes.Name = "lstServerTypes";
            this.lstServerTypes.Size = new System.Drawing.Size(340, 24);
            this.lstServerTypes.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Server Types:";
            // 
            // txtServerType
            // 
            this.txtServerType.Location = new System.Drawing.Point(105, 117);
            this.txtServerType.Name = "txtServerType";
            this.txtServerType.Size = new System.Drawing.Size(240, 27);
            this.txtServerType.TabIndex = 8;
            // 
            // nudCloudServers
            // 
            this.nudCloudServers.Location = new System.Drawing.Point(350, 85);
            this.nudCloudServers.Name = "nudCloudServers";
            this.nudCloudServers.Size = new System.Drawing.Size(70, 27);
            this.nudCloudServers.TabIndex = 7;
            //
