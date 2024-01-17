namespace DVLD.Applications.International_License
{
    partial class FrmNewInternationalLicenseApplication
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
            ctrlDriverLicenseInfoWithFilter1 = new CustomControls.Local_Licenses.CtrlDriverLicenseInfoWithFilter();
            label1 = new Label();
            gbApplicationInfo = new GroupBox();
            lblCreatedBy = new Label();
            label7 = new Label();
            lblExpirationDate = new Label();
            label6 = new Label();
            lblILLicenseId = new Label();
            label5 = new Label();
            lblFees = new Label();
            label4 = new Label();
            lblILApplicationId = new Label();
            label2 = new Label();
            btnIssue = new Button();
            lnkShowNewLicenseInfo = new LinkLabel();
            lnkShowLicenseHistory = new LinkLabel();
            gbApplicationInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.InsertedInternationalLicenseId = -1;
            ctrlDriverLicenseInfoWithFilter1.InsertedNewApplicationId = -1;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(-18, 12);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1200, 374);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 12;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(103, 42);
            label1.Name = "label1";
            label1.Size = new Size(356, 25);
            label1.TabIndex = 14;
            label1.Text = "International License Application";
            // 
            // gbApplicationInfo
            // 
            gbApplicationInfo.Controls.Add(lblCreatedBy);
            gbApplicationInfo.Controls.Add(label7);
            gbApplicationInfo.Controls.Add(lblExpirationDate);
            gbApplicationInfo.Controls.Add(label6);
            gbApplicationInfo.Controls.Add(lblILLicenseId);
            gbApplicationInfo.Controls.Add(label5);
            gbApplicationInfo.Controls.Add(lblFees);
            gbApplicationInfo.Controls.Add(label4);
            gbApplicationInfo.Controls.Add(lblILApplicationId);
            gbApplicationInfo.Controls.Add(label2);
            gbApplicationInfo.Location = new Point(12, 392);
            gbApplicationInfo.Name = "gbApplicationInfo";
            gbApplicationInfo.Size = new Size(1148, 82);
            gbApplicationInfo.TabIndex = 15;
            gbApplicationInfo.TabStop = false;
            gbApplicationInfo.Text = "Application Info";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(1038, 39);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(17, 15);
            lblCreatedBy.TabIndex = 9;
            lblCreatedBy.Text = "??";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(961, 39);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 8;
            label7.Text = "Created By:";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Location = new Point(787, 39);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(17, 15);
            lblExpirationDate.TabIndex = 7;
            lblExpirationDate.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(682, 39);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 6;
            label6.Text = "Expiration Date:";
            // 
            // lblILLicenseId
            // 
            lblILLicenseId.AutoSize = true;
            lblILLicenseId.Location = new Point(344, 39);
            lblILLicenseId.Name = "lblILLicenseId";
            lblILLicenseId.Size = new Size(17, 15);
            lblILLicenseId.TabIndex = 5;
            lblILLicenseId.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(239, 39);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 4;
            label5.Text = "I.L.License Id:";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(536, 39);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(17, 15);
            lblFees.TabIndex = 3;
            lblFees.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(495, 39);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 2;
            label4.Text = "Fees:";
            // 
            // lblILApplicationId
            // 
            lblILApplicationId.AutoSize = true;
            lblILApplicationId.Location = new Point(129, 39);
            lblILApplicationId.Name = "lblILApplicationId";
            lblILApplicationId.Size = new Size(17, 15);
            lblILApplicationId.TabIndex = 1;
            lblILApplicationId.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 39);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "I.L.Application Id:";
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(1085, 493);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(75, 23);
            btnIssue.TabIndex = 23;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // lnkShowNewLicenseInfo
            // 
            lnkShowNewLicenseInfo.AutoSize = true;
            lnkShowNewLicenseInfo.Location = new Point(151, 497);
            lnkShowNewLicenseInfo.Name = "lnkShowNewLicenseInfo";
            lnkShowNewLicenseInfo.Size = new Size(129, 15);
            lnkShowNewLicenseInfo.TabIndex = 25;
            lnkShowNewLicenseInfo.TabStop = true;
            lnkShowNewLicenseInfo.Text = "Show New License Info";
            lnkShowNewLicenseInfo.LinkClicked += lnkShowNewLicenseInfo_LinkClicked;
            // 
            // lnkShowLicenseHistory
            // 
            lnkShowLicenseHistory.AutoSize = true;
            lnkShowLicenseHistory.Location = new Point(14, 497);
            lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            lnkShowLicenseHistory.Size = new Size(119, 15);
            lnkShowLicenseHistory.TabIndex = 24;
            lnkShowLicenseHistory.TabStop = true;
            lnkShowLicenseHistory.Text = "Show License History";
            // 
            // FrmNewInternationalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 536);
            Controls.Add(lnkShowNewLicenseInfo);
            Controls.Add(lnkShowLicenseHistory);
            Controls.Add(btnIssue);
            Controls.Add(gbApplicationInfo);
            Controls.Add(label1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmNewInternationalLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sa";
            gbApplicationInfo.ResumeLayout(false);
            gbApplicationInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Local_Licenses.CtrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private Label label1;
        private GroupBox gbApplicationInfo;
        private Label lblILApplicationId;
        private Label label2;
        private Label lblFees;
        private Label label4;
        private Label lblILLicenseId;
        private Label label5;
        private Label lblExpirationDate;
        private Label label6;
        private Label lblCreatedBy;
        private Label label7;
        private Button btnIssue;
        private LinkLabel lnkShowNewLicenseInfo;
        private LinkLabel lnkShowLicenseHistory;
    }
}