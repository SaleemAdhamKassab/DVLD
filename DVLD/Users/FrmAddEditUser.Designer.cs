namespace DVLD.Users
{
    partial class FrmAddEditUser
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
            tabControlAddUpdateUser = new TabControl();
            tabPageUserPersonalInfo = new TabPage();
            btnAssignToUser = new Button();
            personCardWithFilter1 = new People.Controls.CtrlPersonCardWithFilter();
            tabPageLogin = new TabPage();
            btnSave = new Button();
            chkIsActive = new CheckBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblUserId = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProviderAddEditUser = new ErrorProvider(components);
            tabControlAddUpdateUser.SuspendLayout();
            tabPageUserPersonalInfo.SuspendLayout();
            tabPageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddEditUser).BeginInit();
            SuspendLayout();
            // 
            // tabControlAddUpdateUser
            // 
            tabControlAddUpdateUser.Controls.Add(tabPageUserPersonalInfo);
            tabControlAddUpdateUser.Controls.Add(tabPageLogin);
            tabControlAddUpdateUser.Location = new Point(24, 37);
            tabControlAddUpdateUser.Name = "tabControlAddUpdateUser";
            tabControlAddUpdateUser.SelectedIndex = 0;
            tabControlAddUpdateUser.Size = new Size(630, 500);
            tabControlAddUpdateUser.TabIndex = 6;
            tabControlAddUpdateUser.SelectedIndexChanged += tabControlAddNewUser_SelectedIndexChanged;
            // 
            // tabPageUserPersonalInfo
            // 
            tabPageUserPersonalInfo.Controls.Add(btnAssignToUser);
            tabPageUserPersonalInfo.Controls.Add(personCardWithFilter1);
            tabPageUserPersonalInfo.Location = new Point(4, 24);
            tabPageUserPersonalInfo.Name = "tabPageUserPersonalInfo";
            tabPageUserPersonalInfo.Padding = new Padding(3);
            tabPageUserPersonalInfo.Size = new Size(622, 472);
            tabPageUserPersonalInfo.TabIndex = 0;
            tabPageUserPersonalInfo.Text = "Personal Info";
            tabPageUserPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnAssignToUser
            // 
            btnAssignToUser.Image = Properties.Resources.Next;
            btnAssignToUser.ImageAlign = ContentAlignment.MiddleRight;
            btnAssignToUser.Location = new Point(510, 419);
            btnAssignToUser.Name = "btnAssignToUser";
            btnAssignToUser.Size = new Size(75, 38);
            btnAssignToUser.TabIndex = 7;
            btnAssignToUser.Text = "Next";
            btnAssignToUser.TextAlign = ContentAlignment.MiddleLeft;
            btnAssignToUser.UseVisualStyleBackColor = true;
            btnAssignToUser.Click += BtnNext_Click;
            // 
            // personCardWithFilter1
            // 
            personCardWithFilter1.Location = new Point(6, 6);
            personCardWithFilter1.Name = "personCardWithFilter1";
            personCardWithFilter1.Size = new Size(588, 407);
            personCardWithFilter1.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            tabPageLogin.Controls.Add(btnSave);
            tabPageLogin.Controls.Add(chkIsActive);
            tabPageLogin.Controls.Add(txtConfirmPassword);
            tabPageLogin.Controls.Add(txtPassword);
            tabPageLogin.Controls.Add(txtUserName);
            tabPageLogin.Controls.Add(lblUserId);
            tabPageLogin.Controls.Add(label5);
            tabPageLogin.Controls.Add(label4);
            tabPageLogin.Controls.Add(label3);
            tabPageLogin.Controls.Add(label2);
            tabPageLogin.Location = new Point(4, 24);
            tabPageLogin.Name = "tabPageLogin";
            tabPageLogin.Padding = new Padding(3);
            tabPageLogin.Size = new Size(622, 472);
            tabPageLogin.TabIndex = 1;
            tabPageLogin.Text = "Login Info";
            tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(302, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(277, 229);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(70, 19);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(277, 180);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(100, 23);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.Validating += TxtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(277, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            txtPassword.Validating += ValidateEmptyTextBox;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(277, 101);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 2;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(277, 65);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(17, 15);
            lblUserId.TabIndex = 1;
            lblUserId.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(105, 188);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 0;
            label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(105, 147);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(105, 109);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 0;
            label3.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(105, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "User Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 5;
            label1.Text = "Add New User";
            // 
            // errorProviderAddEditUser
            // 
            errorProviderAddEditUser.ContainerControl = this;
            // 
            // FrmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(659, 540);
            Controls.Add(tabControlAddUpdateUser);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmAddEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddEditUser";
            Load += FrmAddEditUser_Load;
            tabControlAddUpdateUser.ResumeLayout(false);
            tabPageUserPersonalInfo.ResumeLayout(false);
            tabPageLogin.ResumeLayout(false);
            tabPageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddEditUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControlAddUpdateUser;
        private TabPage tabPageUserPersonalInfo;
        private TabPage tabPageLogin;
        private People.Controls.CtrlPersonCardWithFilter personCardWithFilter1;
        private Label label1;
        private Button btnAssignToUser;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblUserId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSave;
        private CheckBox chkIsActive;
        private ErrorProvider errorProviderAddEditUser;
    }
}