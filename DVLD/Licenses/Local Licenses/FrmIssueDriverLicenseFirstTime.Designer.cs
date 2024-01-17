namespace DVLD.Licenses.Local_Licenses
{
    partial class FrmIssueDriverLicenseFirstTime
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
            ctrlDrivingLicenseApplicationInfo1 = new Applications.Local_Driving_License.CtrlDrivingLicenseApplicationInfo();
            label1 = new Label();
            txtNotes = new TextBox();
            btnIssue = new Button();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(12, 12);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(518, 471);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 486);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(34, 504);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(466, 76);
            txtNotes.TabIndex = 2;
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(425, 592);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(75, 23);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // FrmIssueDriverLicenseFirstTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 627);
            Controls.Add(btnIssue);
            Controls.Add(txtNotes);
            Controls.Add(label1);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmIssueDriverLicenseFirstTime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Driver License For The First Time";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.Local_Driving_License.CtrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Label label1;
        private TextBox txtNotes;
        private Button btnIssue;
    }
}