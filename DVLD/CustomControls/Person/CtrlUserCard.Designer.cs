namespace DVLD.Users.Controls
{
    partial class CtrlUserCard
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
            ctrlPersonCard1 = new People.Controls.CtrlPersonCard();
            gbLoginInformation = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblUserId = new Label();
            lblUserName = new Label();
            lblIsActive = new Label();
            gbLoginInformation.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(3, 3);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(589, 296);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbLoginInformation
            // 
            gbLoginInformation.Controls.Add(lblIsActive);
            gbLoginInformation.Controls.Add(lblUserName);
            gbLoginInformation.Controls.Add(lblUserId);
            gbLoginInformation.Controls.Add(label3);
            gbLoginInformation.Controls.Add(label2);
            gbLoginInformation.Controls.Add(label1);
            gbLoginInformation.Location = new Point(19, 292);
            gbLoginInformation.Name = "gbLoginInformation";
            gbLoginInformation.Size = new Size(563, 123);
            gbLoginInformation.TabIndex = 1;
            gbLoginInformation.TabStop = false;
            gbLoginInformation.Text = "Login Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "User Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 61);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 90);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 1;
            label3.Text = "Is Active:";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(136, 31);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(17, 15);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "??";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(136, 61);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(17, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "??";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(136, 90);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(17, 15);
            lblIsActive.TabIndex = 4;
            lblIsActive.Text = "??";
            // 
            // CtrlUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbLoginInformation);
            Controls.Add(ctrlPersonCard1);
            Name = "CtrlUserCard";
            Size = new Size(625, 442);
            gbLoginInformation.ResumeLayout(false);
            gbLoginInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.CtrlPersonCard ctrlPersonCard1;
        private GroupBox gbLoginInformation;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblIsActive;
        private Label lblUserName;
        private Label lblUserId;
    }
}
