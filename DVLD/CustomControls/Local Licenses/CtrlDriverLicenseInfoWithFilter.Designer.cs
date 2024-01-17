namespace DVLD.CustomControls.Local_Licenses
{
    partial class CtrlDriverLicenseInfoWithFilter
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
            components = new System.ComponentModel.Container();
            ctrlDriverLicenseInfo1 = new CtrlDriverLicenseInfo();
            gbFilter = new GroupBox();
            btnSearchLicense = new Button();
            txtLicenseId = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Location = new Point(3, 63);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1179, 309);
            ctrlDriverLicenseInfo1.TabIndex = 10;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnSearchLicense);
            gbFilter.Controls.Add(txtLicenseId);
            gbFilter.Controls.Add(label1);
            gbFilter.Location = new Point(606, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(567, 83);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnSearchLicense
            // 
            btnSearchLicense.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchLicense.Location = new Point(337, 32);
            btnSearchLicense.Name = "btnSearchLicense";
            btnSearchLicense.Size = new Size(58, 23);
            btnSearchLicense.TabIndex = 4;
            btnSearchLicense.Text = "Search";
            btnSearchLicense.UseVisualStyleBackColor = true;
            btnSearchLicense.Click += btnSearchLicense_Click;
            // 
            // txtLicenseId
            // 
            txtLicenseId.Location = new Point(122, 33);
            txtLicenseId.Name = "txtLicenseId";
            txtLicenseId.Size = new Size(199, 23);
            txtLicenseId.TabIndex = 0;
            txtLicenseId.KeyPress += txtLicenseId_KeyPress;
            txtLicenseId.Validating += txtLicenseId_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "License Id:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CtrlDriverLicenseInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrlDriverLicenseInfo1);
            Name = "CtrlDriverLicenseInfoWithFilter";
            Size = new Size(1200, 374);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CtrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private GroupBox gbFilter;
        private TextBox txtLicenseId;
        private Label label1;
        private Button btnSearchLicense;
        private ErrorProvider errorProvider1;
    }
}
