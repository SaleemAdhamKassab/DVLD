namespace DVLD.Applications.Local_Driving_License
{
    partial class FrmAddUpdateLocalDrivingLicesnseApplication
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
            tabControl = new TabControl();
            tabPagePersonalInfo = new TabPage();
            btnNext = new Button();
            ctrlPersonCardWithFilter1 = new People.Controls.CtrlPersonCardWithFilter();
            tabPageApplicationInfo = new TabPage();
            btnSave = new Button();
            lblApplicationFees = new Label();
            label6 = new Label();
            cbLicenseClass = new ComboBox();
            label5 = new Label();
            lblLocalDrivingLicebseApplicationId = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabPagePersonalInfo.SuspendLayout();
            tabPageApplicationInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPagePersonalInfo);
            tabControl.Controls.Add(tabPageApplicationInfo);
            tabControl.Location = new Point(12, 48);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(612, 499);
            tabControl.TabIndex = 0;
            // 
            // tabPagePersonalInfo
            // 
            tabPagePersonalInfo.Controls.Add(btnNext);
            tabPagePersonalInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tabPagePersonalInfo.Location = new Point(4, 24);
            tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            tabPagePersonalInfo.Padding = new Padding(3);
            tabPagePersonalInfo.Size = new Size(604, 471);
            tabPagePersonalInfo.TabIndex = 0;
            tabPagePersonalInfo.Text = "Personal Info";
            tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Image = Properties.Resources.Next;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(515, 416);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 38);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.MiddleLeft;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.Location = new Point(6, 16);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(598, 415);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tabPageApplicationInfo
            // 
            tabPageApplicationInfo.Controls.Add(btnSave);
            tabPageApplicationInfo.Controls.Add(lblApplicationFees);
            tabPageApplicationInfo.Controls.Add(label6);
            tabPageApplicationInfo.Controls.Add(cbLicenseClass);
            tabPageApplicationInfo.Controls.Add(label5);
            tabPageApplicationInfo.Controls.Add(lblLocalDrivingLicebseApplicationId);
            tabPageApplicationInfo.Controls.Add(label2);
            tabPageApplicationInfo.Location = new Point(4, 24);
            tabPageApplicationInfo.Name = "tabPageApplicationInfo";
            tabPageApplicationInfo.Padding = new Padding(3);
            tabPageApplicationInfo.Size = new Size(604, 471);
            tabPageApplicationInfo.TabIndex = 1;
            tabPageApplicationInfo.Text = "Application Info";
            tabPageApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(323, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 33);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Location = new Point(208, 154);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(17, 15);
            lblApplicationFees.TabIndex = 7;
            lblApplicationFees.Text = "??";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(74, 154);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 6;
            label6.Text = "Application Fees:";
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(208, 104);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(207, 23);
            cbLicenseClass.TabIndex = 5;
            cbLicenseClass.Text = "Class 3 - Ordinary driving license";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(74, 112);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "License Class";
            // 
            // lblLocalDrivingLicebseApplicationId
            // 
            lblLocalDrivingLicebseApplicationId.AutoSize = true;
            lblLocalDrivingLicebseApplicationId.Location = new Point(208, 66);
            lblLocalDrivingLicebseApplicationId.Name = "lblLocalDrivingLicebseApplicationId";
            lblLocalDrivingLicebseApplicationId.Size = new Size(17, 15);
            lblLocalDrivingLicebseApplicationId.TabIndex = 1;
            lblLocalDrivingLicebseApplicationId.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 66);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 0;
            label2.Text = "D.L.Application Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 25);
            label1.TabIndex = 9;
            label1.Text = "New Local Driving License Application";
            // 
            // FrmAddUpdateLocalDrivingLicesnseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 559);
            Controls.Add(label1);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmAddUpdateLocalDrivingLicesnseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Local Driving License Application";
            //Activated += FrmAddUpdateLocalDrivingLicesnseApplication_Activated;
            Load += FrmAddUpdateLocalDrivingLicesnseApplication_Load;
            tabControl.ResumeLayout(false);
            tabPagePersonalInfo.ResumeLayout(false);
            tabPageApplicationInfo.ResumeLayout(false);
            tabPageApplicationInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPagePersonalInfo;
        private TabPage tabPageApplicationInfo;
        private Label label1;
        private People.Controls.CtrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Button btnNext;
        private Label label2;
        private Label lblApplicationFees;
        private Label label6;
        private ComboBox cbLicenseClass;
        private Label label5;
        private Label lblLocalDrivingLicebseApplicationId;
        private Button btnSave;
    }
}