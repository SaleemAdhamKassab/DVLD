namespace DVLD.Applications.Renew_Local_License
{
    partial class FrmRenewLocalDrivingLicenseApplication
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
            groupBox1 = new GroupBox();
            btnRenewLicense = new Button();
            lblTotalFees = new Label();
            label12 = new Label();
            lblCreatedBy = new Label();
            label11 = new Label();
            lblExpirationDate = new Label();
            label10 = new Label();
            lblOldLicenseId = new Label();
            label9 = new Label();
            lblRenewedLicenseId = new Label();
            label8 = new Label();
            txtNotes = new TextBox();
            label3 = new Label();
            lblLicenseFees = new Label();
            label6 = new Label();
            lblAppFees = new Label();
            label5 = new Label();
            lblIssueDate = new Label();
            label4 = new Label();
            lblRLAppId = new Label();
            label2 = new Label();
            lnkShowLicenseHistory = new LinkLabel();
            lnkShowNewLicenseInfo = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.InsertedNewApplicationId = -1;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 12);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1186, 374);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(173, 40);
            label1.Name = "label1";
            label1.Size = new Size(296, 25);
            label1.TabIndex = 10;
            label1.Text = "Renew License Application";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalFees);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblExpirationDate);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblOldLicenseId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblRenewedLicenseId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblLicenseFees);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblAppFees);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblIssueDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblRLAppId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(47, 401);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1139, 157);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application New License Info";
            // 
            // btnRenewLicense
            // 
            btnRenewLicense.Location = new Point(1111, 564);
            btnRenewLicense.Name = "btnRenewLicense";
            btnRenewLicense.Size = new Size(75, 23);
            btnRenewLicense.TabIndex = 22;
            btnRenewLicense.Text = "Renew";
            btnRenewLicense.UseVisualStyleBackColor = true;
            btnRenewLicense.Click += btnRenewLicense_Click;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(616, 115);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(17, 15);
            lblTotalFees.TabIndex = 21;
            lblTotalFees.Text = "??";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(510, 115);
            label12.Name = "label12";
            label12.Size = new Size(65, 15);
            label12.TabIndex = 20;
            label12.Text = "Total Fees:";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(363, 35);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(17, 15);
            lblCreatedBy.TabIndex = 19;
            lblCreatedBy.Text = "??";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(255, 35);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 18;
            label11.Text = "Created By:";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Location = new Point(363, 115);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(17, 15);
            lblExpirationDate.TabIndex = 17;
            lblExpirationDate.Text = "??";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(255, 115);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 16;
            label10.Text = "Expiration Date:";
            // 
            // lblOldLicenseId
            // 
            lblOldLicenseId.AutoSize = true;
            lblOldLicenseId.Location = new Point(151, 115);
            lblOldLicenseId.Name = "lblOldLicenseId";
            lblOldLicenseId.Size = new Size(17, 15);
            lblOldLicenseId.TabIndex = 15;
            lblOldLicenseId.Text = "??";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 115);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 14;
            label9.Text = "Old License Id:";
            // 
            // lblRenewedLicenseId
            // 
            lblRenewedLicenseId.AutoSize = true;
            lblRenewedLicenseId.Location = new Point(151, 77);
            lblRenewedLicenseId.Name = "lblRenewedLicenseId";
            lblRenewedLicenseId.Size = new Size(17, 15);
            lblRenewedLicenseId.TabIndex = 13;
            lblRenewedLicenseId.Text = "??";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 77);
            label8.Name = "label8";
            label8.Size = new Size(121, 15);
            label8.TabIndex = 12;
            label8.Text = "Renewed License Id:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(699, 63);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(401, 76);
            txtNotes.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(699, 35);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Notes";
            // 
            // lblLicenseFees
            // 
            lblLicenseFees.AutoSize = true;
            lblLicenseFees.Location = new Point(616, 77);
            lblLicenseFees.Name = "lblLicenseFees";
            lblLicenseFees.Size = new Size(17, 15);
            lblLicenseFees.TabIndex = 9;
            lblLicenseFees.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(510, 77);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 8;
            label6.Text = "License Fees:";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Location = new Point(616, 35);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(17, 15);
            lblAppFees.TabIndex = 7;
            lblAppFees.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(510, 35);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 6;
            label5.Text = "Application Fees:";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(363, 77);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(17, 15);
            lblIssueDate.TabIndex = 5;
            lblIssueDate.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(255, 77);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "Issue Date:";
            // 
            // lblRLAppId
            // 
            lblRLAppId.AutoSize = true;
            lblRLAppId.Location = new Point(151, 35);
            lblRLAppId.Name = "lblRLAppId";
            lblRLAppId.Size = new Size(17, 15);
            lblRLAppId.TabIndex = 1;
            lblRLAppId.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 35);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "R.L.App Id:";
            // 
            // lnkShowLicenseHistory
            // 
            lnkShowLicenseHistory.AutoSize = true;
            lnkShowLicenseHistory.Location = new Point(48, 568);
            lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            lnkShowLicenseHistory.Size = new Size(119, 15);
            lnkShowLicenseHistory.TabIndex = 12;
            lnkShowLicenseHistory.TabStop = true;
            lnkShowLicenseHistory.Text = "Show License History";
            // 
            // lnkShowNewLicenseInfo
            // 
            lnkShowNewLicenseInfo.AutoSize = true;
            lnkShowNewLicenseInfo.Location = new Point(173, 568);
            lnkShowNewLicenseInfo.Name = "lnkShowNewLicenseInfo";
            lnkShowNewLicenseInfo.Size = new Size(129, 15);
            lnkShowNewLicenseInfo.TabIndex = 13;
            lnkShowNewLicenseInfo.TabStop = true;
            lnkShowNewLicenseInfo.Text = "Show New License Info";
            lnkShowNewLicenseInfo.LinkClicked += lnkShowNewLicenseInfo_LinkClicked;
            // 
            // FrmRenewLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 597);
            Controls.Add(btnRenewLicense);
            Controls.Add(lnkShowNewLicenseInfo);
            Controls.Add(lnkShowLicenseHistory);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmRenewLocalDrivingLicenseApplication";
            Text = "Renew Local Driving License";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Local_Licenses.CtrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblRLAppId;
        private Label label2;
        private Label lblIssueDate;
        private Label label4;
        private Label lblAppFees;
        private Label label5;
        private Label lblLicenseFees;
        private Label label6;
        private Label label3;
        private TextBox txtNotes;
        private Label lblRenewedLicenseId;
        private Label label8;
        private Label lblOldLicenseId;
        private Label label9;
        private Label lblExpirationDate;
        private Label label10;
        private Label lblCreatedBy;
        private Label label11;
        private Label lblTotalFees;
        private Label label12;
        private Button btnRenewLicense;
        private LinkLabel lnkShowLicenseHistory;
        private LinkLabel lnkShowNewLicenseInfo;
    }
}