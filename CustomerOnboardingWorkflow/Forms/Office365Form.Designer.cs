namespace CustomerOnboardingWorkflow
{
    partial class Office365Form
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
            this.pnlLicenses = new System.Windows.Forms.Panel();
            this.txtLicenseType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumberOfLicenses = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkExistingLicenses = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlCredentials = new System.Windows.Forms.Panel();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCredentialsProvided = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkOneDrive = new System.Windows.Forms.CheckBox();
            this.chkTeams = new System.Windows.Forms.CheckBox();
            this.chkSharePoint = new System.Windows.Forms.CheckBox();
            this.chkExchange = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlMigration = new System.Windows.Forms.Panel();
            this.txtMigrationNotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpMigrationDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMigrationSource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkRequiresMigration = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSetupNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkSetupComplete = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfLicenses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlCredentials.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlMigration.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office 365 Onboarding";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlLicenses);
            this.groupBox1.Controls.Add(this.chkExistingLicenses);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Licensing";
            // 
            // pnlLicenses
            // 
            this.pnlLicenses.Controls.Add(this.txtLicenseType);
            this.pnlLicenses.Controls.Add(this.label3);
            this.pnlLicenses.Controls.Add(this.nudNumberOfLicenses);
            this.pnlLicenses.Controls.Add(this.label2);
            this.pnlLicenses.Enabled = false;
            this.pnlLicenses.Location = new System.Drawing.Point(20, 55);
            this.pnlLicenses.Name = "pnlLicenses";
            this.pnlLicenses.Size = new System.Drawing.Size(330, 85);
            this.pnlLicenses.TabIndex = 1;
            // 
            // txtLicenseType
            // 
            this.txtLicenseType.Location = new System.Drawing.Point(150, 45);
            this.txtLicenseType.Name = "txtLicenseType";
            this.txtLicenseType.Size = new System.Drawing.Size(180, 27);
            this.txtLicenseType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Type:";
            // 
            // nudNumberOfLicenses
            // 
            this.nudNumberOfLicenses.Location = new System.Drawing.Point(150, 10);
            this.nudNumberOfLicenses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfLicenses.Name = "nudNumberOfLicenses";
            this.nudNumberOfLicenses.Size = new System.Drawing.Size(150, 27);
            this.nudNumberOfLicenses.TabIndex = 1;
            this.nudNumberOfLicenses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of licenses:";
            // 
            // chkExistingLicenses
            // 
            this.chkExistingLicenses.AutoSize = true;
            this.chkExistingLicenses.Location = new System.Drawing.Point(20, 26);
            this.chkExistingLicenses.Name = "chkExistingLicenses";
            this.chkExistingLicenses.Size = new System.Drawing.Size(142, 24);
            this.chkExistingLicenses.TabIndex = 0;
            this.chkExistingLicenses.Text = "Existing Licenses";
            this.chkExistingLicenses.UseVisualStyleBackColor = true;
            this.chkExistingLicenses.CheckedChanged += new System.EventHandler(this.chkExistingLicenses_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlCredentials);
            this.groupBox2.Controls.Add(this.chkCredentialsProvided);
            this.groupBox2.Location = new System.Drawing.Point(400, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Access";
            // 
            // pnlCredentials
            // 
            this.pnlCredentials.Controls.Add(this.txtDomain);
            this.pnlCredentials.Controls.Add(this.label7);
            this.pnlCredentials.Controls.Add(this.txtTenantId);
            this.pnlCredentials.Controls.Add(this.label6);
            this.pnlCredentials.Controls.Add(this.txtAdminPassword);
            this.pnlCredentials.Controls.Add(this.label5);
            this.pnlCredentials.Controls.Add(this.txtAdminUsername);
            this.pnlCredentials.Controls.Add(this.label4);
            this.pnlCredentials.Enabled = false;
            this.pnlCredentials.Location = new System.Drawing.Point(20, 55);
            this.pnlCredentials.Name = "pnlCredentials";
            this.pnlCredentials.Size = new System.Drawing.Size(330, 165);
            this.pnlCredentials.TabIndex = 1;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(150, 125);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(180, 27);
            this.txtDomain.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Domain:";
            // 
            // txtTenantId
            // 
            this.txtTenantId.Location = new System.Drawing.Point(150, 90);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(180, 27);
            this.txtTenantId.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tenant ID:";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(150, 55);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(180, 27);
            this.txtAdminPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(150, 20);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(180, 27);
            this.txtAdminUsername.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            // 
            // chkCredentialsProvided
            // 
            this.chkCredentialsProvided.AutoSize = true;
            this.chkCredentialsProvided.Location = new System.Drawing.Point(20, 26);
            this.chkCredentialsProvided.Name = "chkCredentialsProvided";
            this.chkCredentialsProvided.Size = new System.Drawing.Size(167, 24);
            this.chkCredentialsProvided.TabIndex = 0;
            this.chkCredentialsProvided.Text = "Credentials Provided";
            this.chkCredentialsProvided.UseVisualStyleBackColor = true;
            this.chkCredentialsProvided.CheckedChanged += new System.EventHandler(this.chkCredentialsProvided_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkOneDrive);
            this.groupBox3.Controls.Add(this.chkTeams);
            this.groupBox3.Controls.Add(this.chkSharePoint);
            this.groupBox3.Controls.Add(this.chkExchange);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Required Services";
            // 
            // chkOneDrive
            // 
            this.chkOneDrive.AutoSize = true;
            this.chkOneDrive.Location = new System.Drawing.Point(200, 60);
            this.chkOneDrive.Name = "chkOneDrive";
            this.chkOneDrive.Size = new System.Drawing.Size(95, 24);
            this.chkOneDrive.TabIndex = 3;
            this.chkOneDrive.Text = "OneDrive";
            this.chkOneDrive.UseVisualStyleBackColor = true;
            // 
            // chkTeams
            // 
            this.chkTeams.AutoSize = true;
            this.chkTeams.Location = new System.Drawing.Point(200, 30);
            this.chkTeams.Name = "chkTeams";
            this.chkTeams.Size = new System.Drawing.Size(73, 24);
            this.chkTeams.TabIndex = 2;
            this.chkTeams.Text = "Teams";
            this.chkTeams.UseVisualStyleBackColor = true;
            // 
            // chkSharePoint
            // 
            this.chkSharePoint.AutoSize = true;
            this.chkSharePoint.Location = new System.Drawing.Point(20, 60);
            this.chkSharePoint.Name = "chkSharePoint";
            this.chkSharePoint.Size = new System.Drawing.Size(103, 24);
            this.chkSharePoint.TabIndex = 1;
            this.chkSharePoint.Text = "SharePoint";
            this.chkSharePoint.UseVisualStyleBackColor = true;
            // 
            // chkExchange
            // 
            this.chkExchange.AutoSize = true;
            this.chkExchange.Location = new System.Drawing.Point(20, 30);
            this.chkExchange.Name = "chkExchange";
            this.chkExchange.Size = new System.Drawing.Size(95, 24);
            this.chkExchange.TabIndex = 0;
            this.chkExchange.Text = "Exchange";
            this.chkExchange.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlMigration);
            this.groupBox4.Controls.Add(this.chkRequiresMigration);
            this.groupBox4.Location = new System.Drawing.Point(12, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 200);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Migration";
            // 
            // pnlMigration
            // 
            this.pnlMigration.Controls.Add(this.txtMigrationNotes);
            this.pnlMigration.Controls.Add(this.label10);
            this.pnlMigration.Controls.Add(this.dtpMigrationDate);
            this.pnlMigration.Controls.Add(this.label9);
            this.pnlMigration.Controls.Add(this.txtMigrationSource);
            this.pnlMigration.Controls.Add(this.label8);
            this.pnlMigration.Enabled = false;
            this.pnlMigration.Location = new System.Drawing.Point(20, 55);
            this.pnlMigration.Name = "pnlMigration";
            this.pnlMigration.Size = new System.Drawing.Size(330, 135);
            this.pnlMigration.TabIndex = 1;
            // 
            // txtMigrationNotes
            // 
            this.txtMigrationNotes.Location = new System.Drawing.Point(10, 100);
            this.txtMigrationNotes.Name = "txtMigrationNotes";
            this.txtMigrationNotes.Size = new System.Drawing.Size(310, 27);
            this.txtMigrationNotes.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Notes:";
            // 
            // dtpMigrationDate
            // 
            this.dtpMigrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMigrationDate.Location = new System.Drawing.Point(150, 45);
            this.dtpMigrationDate.Name = "dtpMigrationDate";
            this.dtpMigrationDate.Size = new System.Drawing.Size(170, 27);
            this.dtpMigrationDate.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Migration Date:";
            // 
            // txtMigrationSource
            // 
            this.txtMigrationSource.Location = new System.Drawing.Point(150, 10);
            this.txtMigrationSource.Name = "txtMigrationSource";
            this.txtMigrationSource.Size = new System.Drawing.Size(170, 27);
            this.txtMigrationSource.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Migration Source:";
            // 
            // chkRequiresMigration
            // 
            this.chkRequiresMigration.AutoSize = true;
            this.chkRequiresMigration.Location = new System.Drawing.Point(20, 26);
            this.chkRequiresMigration.Name = "chkRequiresMigration";
            this.chkRequiresMigration.Size = new System.Drawing.Size(158, 24);
            this.chkRequiresMigration.TabIndex = 0;
            this.chkRequiresMigration.Text = "Requires Migration";
            this.chkRequiresMigration.UseVisualStyleBackColor = true;
            this.chkRequiresMigration.CheckedChanged += new System.EventHandler(this.chkRequiresMigration_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSetupNotes);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.chkSetupComplete);
            this.groupBox5.Location = new System.Drawing.Point(400, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 150);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Setup Status";
            // 
            // txtSetupNotes
            // 
            this.txtSetupNotes.Location = new System.Drawing.Point(20, 85);
            this.txtSetupNotes.Multiline = true;
            this.txtSetupNotes.Name = "txtSetupNotes";
            this.txtSetupNotes.Size = new System.Drawing.Size(330, 50);
            this.txtSetupNotes.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Setup Notes:";
            // 
            // chkSetupComplete
            // 
            this.chkSetupComplete.AutoSize = true;
            this.chkSetupComplete.Location = new System.Drawing.Point(20, 30);
            this.chkSetupComplete.Name = "chkSetupComplete";
            this.chkSetupComplete.Size = new System.Drawing.Size(138, 24);
            this.chkSetupComplete.TabIndex = 0;
            this.chkSetupComplete.Text = "Setup Complete";
            this.chkSetupComplete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(566, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
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
            this.btnCancel.Location = new System.Drawing.Point(666, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Office365Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Office365Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Office 365 Onboarding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLicenses.ResumeLayout(false);
            this.pnlLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfLicenses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlCredentials.ResumeLayout(false);
            this.pnlCredentials.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlMigration.ResumeLayout(false);
            this.pnlMigration.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlLicenses;
        private System.Windows.Forms.TextBox txtLicenseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumberOfLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkExistingLicenses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlCredentials;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCredentialsProvided;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkOneDrive;
        private System.Windows.Forms.CheckBox chkTeams;
        private System.Windows.Forms.CheckBox chkSharePoint;
        private System.Windows.Forms.CheckBox chkExchange;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlMigration;
        private System.Windows.Forms.TextBox txtMigrationNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpMigrationDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMigrationSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkRequiresMigration;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSetupNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkSetupComplete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
