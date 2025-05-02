namespace CustomerOnboardingWorkflow
{
    partial class ServiceSelectionForm
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
            this.chkHosting = new System.Windows.Forms.CheckBox();
            this.chkSaasCloudMonitoring = new System.Windows.Forms.CheckBox();
            this.chkServerManagement = new System.Windows.Forms.CheckBox();
            this.chkNetworkMonitoring = new System.Windows.Forms.CheckBox();
            this.chkOffice365 = new System.Windows.Forms.CheckBox();
            this.pnlOffice365 = new System.Windows.Forms.Panel();
            this.chkCredentialsProvided = new System.Windows.Forms.CheckBox();
            this.radNewLicenses = new System.Windows.Forms.RadioButton();
            this.radExistingLicenses = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNetworkMonitoring = new System.Windows.Forms.Panel();
            this.chkNetworkAccessGranted = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlServerManagement = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSaasCloudMonitoring = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHosting = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlOffice365.SuspendLayout();
            this.pnlNetworkMonitoring.SuspendLayout();
            this.pnlServerManagement.SuspendLayout();
            this.pnlSaasCloudMonitoring.SuspendLayout();
            this.pnlHosting.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Selection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHosting);
            this.groupBox1.Controls.Add(this.chkSaasCloudMonitoring);
            this.groupBox1.Controls.Add(this.chkServerManagement);
            this.groupBox1.Controls.Add(this.chkNetworkMonitoring);
            this.groupBox1.Controls.Add(this.chkOffice365);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Services";
            // 
            // chkHosting
            // 
            this.chkHosting.AutoSize = true;
            this.chkHosting.Location = new System.Drawing.Point(628, 45);
            this.chkHosting.Name = "chkHosting";
            this.chkHosting.Size = new System.Drawing.Size(83, 24);
            this.chkHosting.TabIndex = 4;
            this.chkHosting.Text = "Hosting";
            this.chkHosting.UseVisualStyleBackColor = true;
            this.chkHosting.CheckedChanged += new System.EventHandler(this.chkHosting_CheckedChanged);
            // 
            // chkSaasCloudMonitoring
            // 
            this.chkSaasCloudMonitoring.AutoSize = true;
            this.chkSaasCloudMonitoring.Location = new System.Drawing.Point(442, 45);
            this.chkSaasCloudMonitoring.Name = "chkSaasCloudMonitoring";
            this.chkSaasCloudMonitoring.Size = new System.Drawing.Size(180, 24);
            this.chkSaasCloudMonitoring.TabIndex = 3;
            this.chkSaasCloudMonitoring.Text = "SaaS Cloud Monitoring";
            this.chkSaasCloudMonitoring.UseVisualStyleBackColor = true;
            this.chkSaasCloudMonitoring.CheckedChanged += new System.EventHandler(this.chkSaasCloudMonitoring_CheckedChanged);
            // 
            // chkServerManagement
            // 
            this.chkServerManagement.AutoSize = true;
            this.chkServerManagement.Location = new System.Drawing.Point(290, 45);
            this.chkServerManagement.Name = "chkServerManagement";
            this.chkServerManagement.Size = new System.Drawing.Size(163, 24);
            this.chkServerManagement.TabIndex = 2;
            this.chkServerManagement.Text = "Server Management";
            this.chkServerManagement.UseVisualStyleBackColor = true;
            this.chkServerManagement.CheckedChanged += new System.EventHandler(this.chkServerManagement_CheckedChanged);
            // 
            // chkNetworkMonitoring
            // 
            this.chkNetworkMonitoring.AutoSize = true;
            this.chkNetworkMonitoring.Location = new System.Drawing.Point(135, 45);
            this.chkNetworkMonitoring.Name = "chkNetworkMonitoring";
            this.chkNetworkMonitoring.Size = new System.Drawing.Size(167, 24);
            this.chkNetworkMonitoring.TabIndex = 1;
            this.chkNetworkMonitoring.Text = "Network Monitoring";
            this.chkNetworkMonitoring.UseVisualStyleBackColor = true;
            this.chkNetworkMonitoring.CheckedChanged += new System.EventHandler(this.chkNetworkMonitoring_CheckedChanged);
            // 
            // chkOffice365
            // 
            this.chkOffice365.AutoSize = true;
            this.chkOffice365.Location = new System.Drawing.Point(20, 45);
            this.chkOffice365.Name = "chkOffice365";
            this.chkOffice365.Size = new System.Drawing.Size(101, 24);
            this.chkOffice365.TabIndex = 0;
            this.chkOffice365.Text = "Office 365";
            this.chkOffice365.UseVisualStyleBackColor = true;
            this.chkOffice365.CheckedChanged += new System.EventHandler(this.chkOffice365_CheckedChanged);
            // 
            // pnlOffice365
            // 
            this.pnlOffice365.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOffice365.Controls.Add(this.chkCredentialsProvided);
            this.pnlOffice365.Controls.Add(this.radNewLicenses);
            this.pnlOffice365.Controls.Add(this.radExistingLicenses);
            this.pnlOffice365.Controls.Add(this.label2);
            this.pnlOffice365.Location = new System.Drawing.Point(12, 184);
            this.pnlOffice365.Name = "pnlOffice365";
            this.pnlOffice365.Size = new System.Drawing.Size(758, 70);
            this.pnlOffice365.TabIndex = 2;
            this.pnlOffice365.Visible = false;
            // 
            // chkCredentialsProvided
            // 
            this.chkCredentialsProvided.AutoSize = true;
            this.chkCredentialsProvided.Location = new System.Drawing.Point(442, 25);
            this.chkCredentialsProvided.Name = "chkCredentialsProvided";
            this.chkCredentialsProvided.Size = new System.Drawing.Size(167, 24);
            this.chkCredentialsProvided.TabIndex = 3;
            this.chkCredentialsProvided.Text = "Credentials Provided";
            this.chkCredentialsProvided.UseVisualStyleBackColor = true;
            // 
            // radNewLicenses
            // 
            this.radNewLicenses.AutoSize = true;
            this.radNewLicenses.Location = new System.Drawing.Point(290, 25);
            this.radNewLicenses.Name = "radNewLicenses";
            this.radNewLicenses.Size = new System.Drawing.Size(120, 24);
            this.radNewLicenses.TabIndex = 2;
            this.radNewLicenses.Text = "New Licenses";
            this.radNewLicenses.UseVisualStyleBackColor = true;
            // 
            // radExistingLicenses
            // 
            this.radExistingLicenses.AutoSize = true;
            this.radExistingLicenses.Checked = true;
            this.radExistingLicenses.Location = new System.Drawing.Point(135, 25);
            this.radExistingLicenses.Name = "radExistingLicenses";
            this.radExistingLicenses.Size = new System.Drawing.Size(142, 24);
            this.radExistingLicenses.TabIndex = 1;
            this.radExistingLicenses.TabStop = true;
            this.radExistingLicenses.Text = "Existing Licenses";
            this.radExistingLicenses.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Office 365:";
            // 
            // pnlNetworkMonitoring
            // 
            this.pnlNetworkMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNetworkMonitoring.Controls.Add(this.chkNetworkAccessGranted);
            this.pnlNetworkMonitoring.Controls.Add(this.label3);
            this.pnlNetworkMonitoring.Location = new System.Drawing.Point(12, 260);
            this.pnlNetworkMonitoring.Name = "pnlNetworkMonitoring";
            this.pnlNetworkMonitoring.Size = new System.Drawing.Size(758, 70);
            this.pnlNetworkMonitoring.TabIndex = 3;
            this.pnlNetworkMonitoring.Visible = false;
            // 
            // chkNetworkAccessGranted
            // 
            this.chkNetworkAccessGranted.AutoSize = true;
            this.chkNetworkAccessGranted.Location = new System.Drawing.Point(185, 25);
            this.chkNetworkAccessGranted.Name = "chkNetworkAccessGranted";
            this.chkNetworkAccessGranted.Size = new System.Drawing.Size(135, 24);
            this.chkNetworkAccessGranted.TabIndex = 1;
            this.chkNetworkAccessGranted.Text = "Access Granted";
            this.chkNetworkAccessGranted.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Network Monitoring:";
            // 
            // pnlServerManagement
            // 
            this.pnlServerManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServerManagement.Controls.Add(this.label4);
            this.pnlServerManagement.Location = new System.Drawing.Point(12, 336);
            this.pnlServerManagement.Name = "pnlServerManagement";
            this.pnlServerManagement.Size = new System.Drawing.Size(758, 70);
            this.pnlServerManagement.TabIndex = 4;
            this.pnlServerManagement.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server Management:";
            // 
            // pnlSaasCloudMonitoring
            // 
            this.pnlSaasCloudMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaasCloudMonitoring.Controls.Add(this.label5);
            this.pnlSaasCloudMonitoring.Location = new System.Drawing.Point(12, 412);
            this.pnlSaasCloudMonitoring.Name = "pnlSaasCloudMonitoring";
            this.pnlSaasCloudMonitoring.Size = new System.Drawing.Size(758, 70);
            this.pnlSaasCloudMonitoring.TabIndex = 5;
            this.pnlSaasCloudMonitoring.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "SaaS Cloud Monitoring:";
            // 
            // pnlHosting
            // 
            this.pnlHosting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHosting.Controls.Add(this.label6);
            this.pnlHosting.Location = new System.Drawing.Point(12, 488);
            this.pnlHosting.Name = "pnlHosting";
            this.pnlHosting.Size = new System.Drawing.Size(758, 70);
            this.pnlHosting.TabIndex = 6;
            this.pnlHosting.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hosting:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(566, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Continue";
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
            this.btnCancel.Location = new System.Drawing.Point(666, 564);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ServiceSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlHosting);
            this.Controls.Add(this.pnlSaasCloudMonitoring);
            this.Controls.Add(this.pnlServerManagement);
            this.Controls.Add(this.pnlNetworkMonitoring);
            this.Controls.Add(this.pnlOffice365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Service Selection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlOffice365.ResumeLayout(false);
            this.pnlOffice365.PerformLayout();
            this.pnlNetworkMonitoring.ResumeLayout(false);
            this.pnlNetworkMonitoring.PerformLayout();
            this.pnlServerManagement.ResumeLayout(false);
            this.pnlServerManagement.PerformLayout();
            this.pnlSaasCloudMonitoring.ResumeLayout(false);
            this.pnlSaasCloudMonitoring.PerformLayout();
            this.pnlHosting.ResumeLayout(false);
            this.pnlHosting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkHosting;
        private System.Windows.Forms.CheckBox chkSaasCloudMonitoring;
        private System.Windows.Forms.CheckBox chkServerManagement;
        private System.Windows.Forms.CheckBox chkNetworkMonitoring;
        private System.Windows.Forms.CheckBox chkOffice365;
        private System.Windows.Forms.Panel pnlOffice365;
        private System.Windows.Forms.CheckBox chkCredentialsProvided;
        private System.Windows.Forms.RadioButton radNewLicenses;
        private System.Windows.Forms.RadioButton radExistingLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNetworkMonitoring;
        private System.Windows.Forms.CheckBox chkNetworkAccessGranted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlServerManagement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSaasCloudMonitoring;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlHosting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
