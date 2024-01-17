namespace DVLD.Tests
{
    partial class FrmListTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListTestAppointments));
            pbTestType = new PictureBox();
            lblTestTypeTitle = new Label();
            lblRecords = new Label();
            label2 = new Label();
            dgvAppointmentsPerTest = new DataGridView();
            cmsAppointment = new ContextMenuStrip(components);
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnAddNewAppointment = new Button();
            ctrlDrivingLicenseApplicationInfo1 = new Applications.Local_Driving_License.CtrlDrivingLicenseApplicationInfo();
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbTestType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentsPerTest).BeginInit();
            cmsAppointment.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbTestType
            // 
            pbTestType.BorderStyle = BorderStyle.FixedSingle;
            pbTestType.Image = Properties.Resources.VisionTest;
            pbTestType.Location = new Point(167, 22);
            pbTestType.Name = "pbTestType";
            pbTestType.Size = new Size(167, 125);
            pbTestType.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestType.TabIndex = 1;
            pbTestType.TabStop = false;
            // 
            // lblTestTypeTitle
            // 
            lblTestTypeTitle.AutoSize = true;
            lblTestTypeTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTestTypeTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTestTypeTitle.Location = new Point(144, 163);
            lblTestTypeTitle.Name = "lblTestTypeTitle";
            lblTestTypeTitle.Size = new Size(224, 25);
            lblTestTypeTitle.TabIndex = 7;
            lblTestTypeTitle.Text = "Vision Test Appointments";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(77, 225);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(17, 15);
            lblRecords.TabIndex = 15;
            lblRecords.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 225);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 14;
            label2.Text = "Records:";
            // 
            // dgvAppointmentsPerTest
            // 
            dgvAppointmentsPerTest.AllowUserToAddRows = false;
            dgvAppointmentsPerTest.AllowUserToDeleteRows = false;
            dgvAppointmentsPerTest.BackgroundColor = Color.White;
            dgvAppointmentsPerTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointmentsPerTest.ContextMenuStrip = cmsAppointment;
            dgvAppointmentsPerTest.Location = new Point(16, 60);
            dgvAppointmentsPerTest.Name = "dgvAppointmentsPerTest";
            dgvAppointmentsPerTest.ReadOnly = true;
            dgvAppointmentsPerTest.RowTemplate.Height = 25;
            dgvAppointmentsPerTest.Size = new Size(490, 152);
            dgvAppointmentsPerTest.TabIndex = 13;
            // 
            // cmsAppointment
            // 
            cmsAppointment.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            cmsAppointment.Name = "cmsAppointment";
            cmsAppointment.Size = new Size(181, 70);
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = (Image)resources.GetObject("takeTestToolStripMenuItem.Image");
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(180, 22);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddNewAppointment);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblRecords);
            groupBox1.Controls.Add(dgvAppointmentsPerTest);
            groupBox1.Location = new Point(23, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 243);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointments";
            // 
            // btnAddNewAppointment
            // 
            btnAddNewAppointment.BackgroundImage = (Image)resources.GetObject("btnAddNewAppointment.BackgroundImage");
            btnAddNewAppointment.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewAppointment.Location = new Point(459, 22);
            btnAddNewAppointment.Name = "btnAddNewAppointment";
            btnAddNewAppointment.Size = new Size(47, 32);
            btnAddNewAppointment.TabIndex = 16;
            btnAddNewAppointment.UseVisualStyleBackColor = true;
            btnAddNewAppointment.Click += btnAddNewAppointment_Click;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(572, 12);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(518, 471);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 17;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // FrmListTestAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 491);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Controls.Add(groupBox1);
            Controls.Add(lblTestTypeTitle);
            Controls.Add(pbTestType);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "FrmListTestAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointments";
            Load += FrmListTestAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)pbTestType).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentsPerTest).EndInit();
            cmsAppointment.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbTestType;
        private Label lblTestTypeTitle;
        private Label lblRecords;
        private Label label2;
        private DataGridView dgvAppointmentsPerTest;
        private GroupBox groupBox1;
        private Button btnAddNewAppointment;
        //private Applications.Local_Driving_License.CtrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Applications.Local_Driving_License.CtrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private ContextMenuStrip cmsAppointment;
        private ToolStripMenuItem takeTestToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}