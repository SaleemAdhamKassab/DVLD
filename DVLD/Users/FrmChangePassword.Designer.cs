namespace DVLD.Users
{
    partial class FrmChangePassword
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ctrlUserCard1 = new Controls.CtrlUserCard();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnChangePassword = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            errorProviderChangePassword = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderChangePassword).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 6;
            label1.Text = "Change Password";
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(12, 37);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(595, 442);
            ctrlUserCard1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 37);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 8;
            label2.Text = "Current Password:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChangePassword);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtCurrentPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 460);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 126);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Password";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(432, 93);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(115, 23);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(158, 94);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(132, 23);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(158, 65);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(132, 23);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(158, 34);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(132, 23);
            txtCurrentPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 97);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 10;
            label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 68);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 9;
            label3.Text = "New Password:";
            // 
            // errorProviderChangePassword
            // 
            errorProviderChangePassword.ContainerControl = this;
            // 
            // FrmChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 598);
            Controls.Add(groupBox1);
            Controls.Add(ctrlUserCard1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderChangePassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Controls.CtrlUserCard ctrlUserCard1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtCurrentPassword;
        private Label label4;
        private Label label3;
        private Button btnChangePassword;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private ErrorProvider errorProviderChangePassword;
    }
}