namespace DVLD.Applications.Local_Driving_License
{
    partial class FrmLocalDrivingLicenseApplicationInfo
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
            ctrlDrivingLicenseApplicationInfo1 = new CtrlDrivingLicenseApplicationInfo();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(12, 12);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(561, 468);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // FrmLocalDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 475);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmLocalDrivingLicenseApplicationInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Driving License Application Info";
            ResumeLayout(false);
        }

        #endregion

        private CtrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
    }
}