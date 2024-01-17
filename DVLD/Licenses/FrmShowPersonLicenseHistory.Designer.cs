namespace DVLD.Licenses
{
    partial class FrmShowPersonLicenseHistory
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
            ctrlDriverLicenses1 = new CustomControls.Licenses.CtrlDriverLicenses();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(-2, 37);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(589, 296);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(194, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 15;
            label1.Text = "License History";
            // 
            // ctrlDriverLicenses1
            // 
            ctrlDriverLicenses1.Location = new Point(1, 329);
            ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.Size = new Size(586, 242);
            ctrlDriverLicenses1.TabIndex = 16;
            // 
            // FrmShowPersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 575);
            Controls.Add(ctrlDriverLicenses1);
            Controls.Add(label1);
            Controls.Add(ctrlPersonCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmShowPersonLicenseHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "License History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private People.Controls.CtrlPersonCard ctrlPersonCard1;
        private Label label1;
        private CustomControls.Licenses.CtrlDriverLicenses ctrlDriverLicenses1;
    }
}