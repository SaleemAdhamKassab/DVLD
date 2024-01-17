namespace DVLD.Licenses.Detain_License
{
    partial class FrmDetainLicenseApplication
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
            gbDetainInfo = new GroupBox();
            numericUpDownFineFees = new NumericUpDown();
            label6 = new Label();
            lblCreatedBy = new Label();
            label5 = new Label();
            lblDetainId = new Label();
            label2 = new Label();
            btnDetain = new Button();
            lnkShowNewLicenseInfo = new LinkLabel();
            lnkShowLicenseHistory = new LinkLabel();
            gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFineFees).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(1, 3);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1200, 374);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(184, 37);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 4;
            label1.Text = "Detain License";
            // 
            // gbDetainInfo
            // 
            gbDetainInfo.Controls.Add(numericUpDownFineFees);
            gbDetainInfo.Controls.Add(label6);
            gbDetainInfo.Controls.Add(lblCreatedBy);
            gbDetainInfo.Controls.Add(label5);
            gbDetainInfo.Controls.Add(lblDetainId);
            gbDetainInfo.Controls.Add(label2);
            gbDetainInfo.Location = new Point(30, 374);
            gbDetainInfo.Name = "gbDetainInfo";
            gbDetainInfo.Size = new Size(1149, 87);
            gbDetainInfo.TabIndex = 5;
            gbDetainInfo.TabStop = false;
            gbDetainInfo.Text = "Detain Info";
            // 
            // numericUpDownFineFees
            // 
            numericUpDownFineFees.Location = new Point(864, 29);
            numericUpDownFineFees.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownFineFees.Name = "numericUpDownFineFees";
            numericUpDownFineFees.Size = new Size(120, 23);
            numericUpDownFineFees.TabIndex = 7;
            numericUpDownFineFees.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(779, 37);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 6;
            label6.Text = "Fine Fees:";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Location = new Point(506, 37);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(17, 15);
            lblCreatedBy.TabIndex = 5;
            lblCreatedBy.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(429, 37);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Created By:";
            // 
            // lblDetainId
            // 
            lblDetainId.AutoSize = true;
            lblDetainId.Location = new Point(183, 37);
            lblDetainId.Name = "lblDetainId";
            lblDetainId.Size = new Size(17, 15);
            lblDetainId.TabIndex = 1;
            lblDetainId.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 37);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Detain Id:";
            // 
            // btnDetain
            // 
            btnDetain.Location = new Point(1104, 473);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(75, 23);
            btnDetain.TabIndex = 6;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // lnkShowNewLicenseInfo
            // 
            lnkShowNewLicenseInfo.AutoSize = true;
            lnkShowNewLicenseInfo.Location = new Point(167, 481);
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
            lnkShowLicenseHistory.Location = new Point(30, 481);
            lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            lnkShowLicenseHistory.Size = new Size(119, 15);
            lnkShowLicenseHistory.TabIndex = 14;
            lnkShowLicenseHistory.TabStop = true;
            lnkShowLicenseHistory.Text = "Show License History";
            // 
            // FrmDetainLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 508);
            Controls.Add(lnkShowNewLicenseInfo);
            Controls.Add(lnkShowLicenseHistory);
            Controls.Add(btnDetain);
            Controls.Add(gbDetainInfo);
            Controls.Add(label1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmDetainLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detain License";
            gbDetainInfo.ResumeLayout(false);
            gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFineFees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Local_Licenses.CtrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private Label label1;
        private GroupBox gbDetainInfo;
        private Label label2;
        private Label lblDetainId;
        private Label lblCreatedBy;
        private Label label5;
        private NumericUpDown numericUpDownFineFees;
        private Label label6;
        private Button btnDetain;
        private LinkLabel lnkShowNewLicenseInfo;
        private LinkLabel lnkShowLicenseHistory;
    }
}