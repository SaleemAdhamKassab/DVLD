namespace DVLD.Users
{
    partial class FrmShowUserInfo
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
            lblTitle = new Label();
            ctrlUserCard1 = new Controls.CtrlUserCard();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(243, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 25);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "User Details";
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(12, 37);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(625, 442);
            ctrlUserCard1.TabIndex = 8;
            // 
            // FrmShowUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 480);
            Controls.Add(ctrlUserCard1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmShowUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User's  Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Controls.CtrlUserCard ctrlUserCard1;
    }
}