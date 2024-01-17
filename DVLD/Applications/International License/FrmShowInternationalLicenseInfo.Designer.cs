namespace DVLD.Applications.International_License
{
    partial class FrmShowInternationalLicenseInfo
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
            ctrlPersonCard1 = new People.Controls.CtrlPersonCard();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            lblInternationalLicenseId = new Label();
            lblLicenseId = new Label();
            label4 = new Label();
            lblIssueDate = new Label();
            label5 = new Label();
            lblExpirationDate = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(12, 37);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(589, 296);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 25);
            label1.TabIndex = 15;
            label1.Text = "Driver International License Info";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblExpirationDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblIssueDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblLicenseId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblInternationalLicenseId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 326);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 100);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "International License Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 35);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 0;
            label2.Text = "International License Id:";
            // 
            // lblInternationalLicenseId
            // 
            lblInternationalLicenseId.AutoSize = true;
            lblInternationalLicenseId.Location = new Point(175, 35);
            lblInternationalLicenseId.Name = "lblInternationalLicenseId";
            lblInternationalLicenseId.Size = new Size(17, 15);
            lblInternationalLicenseId.TabIndex = 1;
            lblInternationalLicenseId.Text = "??";
            // 
            // lblLicenseId
            // 
            lblLicenseId.AutoSize = true;
            lblLicenseId.Location = new Point(175, 62);
            lblLicenseId.Name = "lblLicenseId";
            lblLicenseId.Size = new Size(17, 15);
            lblLicenseId.TabIndex = 3;
            lblLicenseId.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 62);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 2;
            label4.Text = "License Id:";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(396, 35);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(17, 15);
            lblIssueDate.TabIndex = 5;
            lblIssueDate.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(294, 35);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Issue Date:";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Location = new Point(396, 62);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(17, 15);
            lblExpirationDate.TabIndex = 7;
            lblExpirationDate.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(294, 62);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 6;
            label6.Text = "Expiration Date:";
            // 
            // FrmShowInternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(ctrlPersonCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmShowInternationalLicenseInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "International License";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private People.Controls.CtrlPersonCard ctrlPersonCard1;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblInternationalLicenseId;
        private Label label2;
        private Label lblLicenseId;
        private Label label4;
        private Label lblExpirationDate;
        private Label label6;
        private Label lblIssueDate;
        private Label label5;
    }
}