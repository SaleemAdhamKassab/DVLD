namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    partial class FrmReplaceLostOrDamagedLicenseApplication
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
            gbReplacmentFor = new GroupBox();
            rbLostLicense = new RadioButton();
            rbDamagedLicense = new RadioButton();
            label1 = new Label();
            btnIssueReplacment = new Button();
            lnkShowNewLicenseInfo = new LinkLabel();
            lnkShowLicenseHistory = new LinkLabel();
            gbApplicationInfoForLicenseReplacment = new GroupBox();
            lblCreatedBy = new Label();
            label7 = new Label();
            lblOldLicenseId = new Label();
            label6 = new Label();
            lblApplicationFees = new Label();
            label5 = new Label();
            lblReplacedLicenseId = new Label();
            label4 = new Label();
            gbReplacmentFor.SuspendLayout();
            gbApplicationInfoForLicenseReplacment.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 64);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1200, 374);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            // 
            // gbReplacmentFor
            // 
            gbReplacmentFor.Controls.Add(rbLostLicense);
            gbReplacmentFor.Controls.Add(rbDamagedLicense);
            gbReplacmentFor.Location = new Point(38, 64);
            gbReplacmentFor.Name = "gbReplacmentFor";
            gbReplacmentFor.Size = new Size(566, 85);
            gbReplacmentFor.TabIndex = 1;
            gbReplacmentFor.TabStop = false;
            gbReplacmentFor.Text = "Replacment For";
            // 
            // rbLostLicense
            // 
            rbLostLicense.AutoSize = true;
            rbLostLicense.Location = new Point(277, 38);
            rbLostLicense.Name = "rbLostLicense";
            rbLostLicense.Size = new Size(89, 19);
            rbLostLicense.TabIndex = 1;
            rbLostLicense.Text = "Lost License";
            rbLostLicense.UseVisualStyleBackColor = true;
            rbLostLicense.CheckedChanged += rbLostLicense_CheckedChanged;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.AutoSize = true;
            rbDamagedLicense.Location = new Point(98, 38);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.Size = new Size(118, 19);
            rbDamagedLicense.TabIndex = 0;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.UseVisualStyleBackColor = true;
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(369, 23);
            label1.Name = "label1";
            label1.Size = new Size(439, 25);
            label1.TabIndex = 10;
            label1.Text = "Replacment For Damaged / Lost License";
            // 
            // btnIssueReplacment
            // 
            btnIssueReplacment.Location = new Point(1074, 547);
            btnIssueReplacment.Name = "btnIssueReplacment";
            btnIssueReplacment.Size = new Size(117, 23);
            btnIssueReplacment.TabIndex = 11;
            btnIssueReplacment.Text = "Issue Replacment";
            btnIssueReplacment.UseVisualStyleBackColor = true;
            btnIssueReplacment.Click += btnIssueReplacment_Click;
            // 
            // lnkShowNewLicenseInfo
            // 
            lnkShowNewLicenseInfo.AutoSize = true;
            lnkShowNewLicenseInfo.Location = new Point(175, 555);
            lnkShowNewLicenseInfo.Name = "lnkShowNewLicenseInfo";
            lnkShowNewLicenseInfo.Size = new Size(129, 15);
            lnkShowNewLicenseInfo.TabIndex = 15;
            lnkShowNewLicenseInfo.TabStop = true;
            lnkShowNewLicenseInfo.Text = "Show New License Info";
            lnkShowNewLicenseInfo.LinkClicked += lnkShowNewLicenseInfo_LinkClicked;
            // 
            // lnkShowLicenseHistory
            // 
            lnkShowLicenseHistory.AutoSize = true;
            lnkShowLicenseHistory.Location = new Point(38, 555);
            lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            lnkShowLicenseHistory.Size = new Size(119, 15);
            lnkShowLicenseHistory.TabIndex = 14;
            lnkShowLicenseHistory.TabStop = true;
            lnkShowLicenseHistory.Text = "Show License History";
            // 
            // gbApplicationInfoForLicenseReplacment
            // 
            gbApplicationInfoForLicenseReplacment.Controls.Add(lblCreatedBy);
            gbApplicationInfoForLicenseReplacment.Controls.Add(label7);
            gbApplicationInfoForLicenseReplacment.Controls.Add(lblOldLicenseId);
            gbApplicationInfoForLicenseReplacment.Controls.Add(label6);
            gbApplicationInfoForLicenseReplacment.Controls.Add(lblApplicationFees);
            gbApplicationInfoForLicenseReplacment.Controls.Add(label5);
            gbApplicationInfoForLicenseReplacment.Controls.Add(lblReplacedLicenseId);
            gbApplicationInfoForLicenseReplacment.Controls.Add(label4);
            gbApplicationInfoForLicenseReplacment.Location = new Point(38, 444);
            gbApplicationInfoForLicenseReplacment.Name = "gbApplicationInfoForLicenseReplacment";
            gbApplicationInfoForLicenseReplacment.Size = new Size(1153, 84);
            gbApplicationInfoForLicenseReplacment.TabIndex = 16;
            gbApplicationInfoForLicenseReplacment.TabStop = false;
            gbApplicationInfoForLicenseReplacment.Text = "Application Info For License Replacment";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(1031, 35);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(17, 15);
            lblCreatedBy.TabIndex = 9;
            lblCreatedBy.Text = "??";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(924, 35);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 8;
            label7.Text = "Created By:";
            // 
            // lblOldLicenseId
            // 
            lblOldLicenseId.AutoSize = true;
            lblOldLicenseId.Location = new Point(150, 35);
            lblOldLicenseId.Name = "lblOldLicenseId";
            lblOldLicenseId.Size = new Size(17, 15);
            lblOldLicenseId.TabIndex = 7;
            lblOldLicenseId.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 35);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 6;
            label6.Text = "Old License Id:";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Location = new Point(700, 35);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(17, 15);
            lblApplicationFees.TabIndex = 5;
            lblApplicationFees.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(594, 35);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 4;
            label5.Text = "Application Fees:";
            // 
            // lblReplacedLicenseId
            // 
            lblReplacedLicenseId.AutoSize = true;
            lblReplacedLicenseId.Location = new Point(414, 35);
            lblReplacedLicenseId.Name = "lblReplacedLicenseId";
            lblReplacedLicenseId.Size = new Size(17, 15);
            lblReplacedLicenseId.TabIndex = 3;
            lblReplacedLicenseId.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(291, 35);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 2;
            label4.Text = "Replaced License Id:";
            // 
            // FrmReplaceLostOrDamagedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 595);
            Controls.Add(gbApplicationInfoForLicenseReplacment);
            Controls.Add(lnkShowNewLicenseInfo);
            Controls.Add(lnkShowLicenseHistory);
            Controls.Add(btnIssueReplacment);
            Controls.Add(label1);
            Controls.Add(gbReplacmentFor);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "FrmReplaceLostOrDamagedLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Replacement or Damaged License";
            gbReplacmentFor.ResumeLayout(false);
            gbReplacmentFor.PerformLayout();
            gbApplicationInfoForLicenseReplacment.ResumeLayout(false);
            gbApplicationInfoForLicenseReplacment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Local_Licenses.CtrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox gbReplacmentFor;
        private RadioButton rbLostLicense;
        private RadioButton rbDamagedLicense;
        private Label label1;
        private Button btnIssueReplacment;
        private LinkLabel lnkShowNewLicenseInfo;
        private LinkLabel lnkShowLicenseHistory;
        private GroupBox gbApplicationInfoForLicenseReplacment;
        private Label lblReplacedLicenseId;
        private Label label4;
        private Label lblApplicationFees;
        private Label label5;
        private Label lblOldLicenseId;
        private Label label6;
        private Label lblCreatedBy;
        private Label label7;
    }
}