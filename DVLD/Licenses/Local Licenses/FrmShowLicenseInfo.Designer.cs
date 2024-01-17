namespace DVLD.Licenses.Local_Licenses
{
    partial class FrmShowLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowLicenseInfo));
            ctrlDriverLicenseInfo1 = new CustomControls.Local_Licenses.CtrlDriverLicenseInfo();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Location = new Point(3, 140);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1167, 325);
            ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(541, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(496, 127);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 10;
            label1.Text = "Driver License Info";
            // 
            // FrmShowLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 477);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlDriverLicenseInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmShowLicenseInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "License Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Local_Licenses.CtrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}