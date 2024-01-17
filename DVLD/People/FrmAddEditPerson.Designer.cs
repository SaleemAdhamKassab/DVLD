namespace DVLD
{
    partial class FrmAddEditPerson
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
            groupBox1 = new GroupBox();
            lnkSetImage = new LinkLabel();
            btnSave = new Button();
            btnClose2 = new Button();
            txtAddress = new TextBox();
            cbCountries = new ComboBox();
            pbProfile = new PictureBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dtpDateOfBirth = new DateTimePicker();
            txtLastName = new TextBox();
            txtSecondName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtNationalNumber = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblPersonId = new Label();
            label3 = new Label();
            lblTitle = new Label();
            setImageDialog = new OpenFileDialog();
            errorProviderAddEditPerson = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddEditPerson).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lnkSetImage);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnClose2);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(cbCountries);
            groupBox1.Controls.Add(pbProfile);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtSecondName);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNationalNumber);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(4, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 299);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lnkSetImage
            // 
            lnkSetImage.AutoSize = true;
            lnkSetImage.Location = new Point(508, 148);
            lnkSetImage.Name = "lnkSetImage";
            lnkSetImage.Size = new Size(59, 15);
            lnkSetImage.TabIndex = 12;
            lnkSetImage.TabStop = true;
            lnkSetImage.Text = "Set Image";
            lnkSetImage.LinkClicked += LnkSetImage_LinkClicked;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(410, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClose2
            // 
            btnClose2.Location = new Point(329, 268);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(75, 23);
            btnClose2.TabIndex = 14;
            btnClose2.Text = "Close";
            btnClose2.UseVisualStyleBackColor = true;
            btnClose2.Click += BtnClose2_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(85, 173);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 78);
            txtAddress.TabIndex = 11;
            txtAddress.Validating += ValidateEmptyTextBox;
            // 
            // cbCountries
            // 
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(298, 135);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(187, 23);
            cbCountries.TabIndex = 10;
            // 
            // pbProfile
            // 
            pbProfile.Image = Properties.Resources.defaultProfileImage1;
            pbProfile.Location = new Point(508, 19);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(124, 126);
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfile.TabIndex = 7;
            pbProfile.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(143, 100);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 7;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(85, 100);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 6;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(311, 54);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(174, 23);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(364, 19);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 3;
            txtLastName.Validating += ValidateEmptyTextBox;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(225, 19);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.PlaceholderText = "Second";
            txtSecondName.Size = new Size(121, 23);
            txtSecondName.TabIndex = 2;
            txtSecondName.Validating += ValidateEmptyTextBox;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(298, 99);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(187, 23);
            txtPhone.TabIndex = 8;
            txtPhone.Validating += ValidateEmptyTextBox;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(85, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 9;
            txtEmail.Validating += TxtEmail_Validating;
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.Location = new Point(85, 54);
            txtNationalNumber.Name = "txtNationalNumber";
            txtNationalNumber.Size = new Size(121, 23);
            txtNationalNumber.TabIndex = 4;
            txtNationalNumber.Validating += TxtNationalNumber_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(85, 19);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 60);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 3;
            label6.Text = "Date Of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(230, 102);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 3;
            label8.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(230, 143);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 3;
            label10.Text = "Country";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 173);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 3;
            label11.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 143);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 3;
            label9.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 104);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 3;
            label7.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 60);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 3;
            label5.Text = "National No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 27);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Location = new Point(70, 33);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(29, 15);
            lblPersonId.TabIndex = 6;
            lblPersonId.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 33);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Person Id:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(249, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 25);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Add New Person";
            // 
            // setImageDialog
            // 
            setImageDialog.FileName = "openFileDialog1";
            // 
            // errorProviderAddEditPerson
            // 
            errorProviderAddEditPerson.ContainerControl = this;
            // 
            // FrmAddEditPerson
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose2;
            ClientSize = new Size(654, 358);
            Controls.Add(groupBox1);
            Controls.Add(lblPersonId);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmAddEditPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Person";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAddEditPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel lnkSetImage;
        private Button btnSave;
        private TextBox txtAddress;
        private ComboBox cbCountries;
        private PictureBox pbProfile;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtLastName;
        private TextBox txtSecondName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtNationalNumber;
        private TextBox txtFirstName;
        private Label label6;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label lblPersonId;
        private Label label3;
        private Label lblTitle;
        private OpenFileDialog setImageDialog;
        private ErrorProvider errorProviderAddEditPerson;
        private Button btnClose2;
    }
}