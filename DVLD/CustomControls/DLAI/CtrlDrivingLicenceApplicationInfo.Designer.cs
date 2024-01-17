namespace DVLD.Applications.Local_Driving_License
{
    partial class CtrlDrivingLicenseApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnShowLicenseInfo = new Button();
            lblPassedTests = new Label();
            label4 = new Label();
            lblAppliedForLicense = new Label();
            label3 = new Label();
            lblDlAppId = new Label();
            label1 = new Label();
            ctrlApplicationBasicInfo1 = new SharedUserControls.CtrlApplicationBasicInfo();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowLicenseInfo);
            groupBox1.Controls.Add(lblPassedTests);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblAppliedForLicense);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblDlAppId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driving License Application Info";
            // 
            // btnShowLicenseInfo
            // 
            btnShowLicenseInfo.Location = new Point(332, 121);
            btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            btnShowLicenseInfo.Size = new Size(127, 23);
            btnShowLicenseInfo.TabIndex = 7;
            btnShowLicenseInfo.Text = "Show License Info";
            btnShowLicenseInfo.UseVisualStyleBackColor = true;
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.Location = new Point(144, 121);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(17, 15);
            lblPassedTests.TabIndex = 6;
            lblPassedTests.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 121);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 5;
            label4.Text = "Passed Tests:";
            // 
            // lblAppliedForLicense
            // 
            lblAppliedForLicense.AutoSize = true;
            lblAppliedForLicense.Location = new Point(144, 80);
            lblAppliedForLicense.Name = "lblAppliedForLicense";
            lblAppliedForLicense.Size = new Size(17, 15);
            lblAppliedForLicense.TabIndex = 3;
            lblAppliedForLicense.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Applied For License:";
            // 
            // lblDlAppId
            // 
            lblDlAppId.AutoSize = true;
            lblDlAppId.Location = new Point(144, 42);
            lblDlAppId.Name = "lblDlAppId";
            lblDlAppId.Size = new Size(17, 15);
            lblDlAppId.TabIndex = 1;
            lblDlAppId.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "D.L.App.Id:";
            // 
            // ctrlApplicationBasicInfo1
            // 
            ctrlApplicationBasicInfo1.Location = new Point(3, 196);
            ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            ctrlApplicationBasicInfo1.Size = new Size(512, 259);
            ctrlApplicationBasicInfo1.TabIndex = 1;
            // 
            // CtrlDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlApplicationBasicInfo1);
            Controls.Add(groupBox1);
            Name = "CtrlDrivingLicenseApplicationInfo";
            Size = new Size(518, 471);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAppliedForLicense;
        private Label label3;
        private Label lblDlAppId;
        private Label label1;
        private Label lblPassedTests;
        private Label label4;
        private Button btnShowLicenseInfo;
        private SharedUserControls.CtrlApplicationBasicInfo ctrlApplicationBasicInfo1;
    }
}
