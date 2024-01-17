namespace DVLD.People
{
    partial class FrmShowPersonInfo
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
            personCard1 = new Controls.CtrlPersonCard();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(209, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(131, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Person Details";
            // 
            // personCard1
            // 
            personCard1.Location = new Point(-1, 37);
            personCard1.Name = "personCard1";
            personCard1.Size = new Size(589, 296);
            personCard1.TabIndex = 7;
            // 
            // FrmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 327);
            Controls.Add(personCard1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmShowPersonInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person's Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Controls.CtrlPersonCard personCard1;
    }
}