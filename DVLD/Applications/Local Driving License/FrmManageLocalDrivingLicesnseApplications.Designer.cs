namespace DVLD.Applications.Local_Driving_License
{
    partial class FrmManageLocalDrivingLicesnseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageLocalDrivingLicesnseApplications));
            txtFilter = new TextBox();
            label3 = new Label();
            cbFilter = new ComboBox();
            lblRecords = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvLocalDrivingLicenseApplication = new DataGridView();
            cms = new ContextMenuStrip(components);
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            sechduleTestsToolStripMenuItem = new ToolStripMenuItem();
            sechduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            sechduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            sechduleStreetToolStripMenuItem = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            btnAddLDLA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplication).BeginInit();
            cms.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(203, 143);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(173, 23);
            txtFilter.TabIndex = 16;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 143);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 15;
            label3.Text = "Filter By:";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "ID", "Driving Class", "National No.", "Full Name", "Status" });
            cbFilter.Location = new Point(76, 143);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 14;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(80, 401);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(0, 15);
            lblRecords.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 401);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 12;
            label2.Text = "#Records:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(263, 104);
            label1.Name = "label1";
            label1.Size = new Size(363, 25);
            label1.TabIndex = 11;
            label1.Text = "Local Driving License Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dgvLocalDrivingLicenseApplication
            // 
            dgvLocalDrivingLicenseApplication.AllowUserToAddRows = false;
            dgvLocalDrivingLicenseApplication.AllowUserToDeleteRows = false;
            dgvLocalDrivingLicenseApplication.AllowUserToOrderColumns = true;
            dgvLocalDrivingLicenseApplication.BackgroundColor = Color.White;
            dgvLocalDrivingLicenseApplication.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenseApplication.ContextMenuStrip = cms;
            dgvLocalDrivingLicenseApplication.Location = new Point(12, 172);
            dgvLocalDrivingLicenseApplication.Name = "dgvLocalDrivingLicenseApplication";
            dgvLocalDrivingLicenseApplication.ReadOnly = true;
            dgvLocalDrivingLicenseApplication.RowTemplate.Height = 25;
            dgvLocalDrivingLicenseApplication.Size = new Size(931, 215);
            dgvLocalDrivingLicenseApplication.TabIndex = 9;
            // 
            // cms
            // 
            cms.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, editApplicationToolStripMenuItem, deleteToolStripMenuItem, cancelApplicationToolStripMenuItem, sechduleTestsToolStripMenuItem, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseToolStripMenuItem });
            cms.Name = "cms";
            cms.Size = new Size(246, 180);
            cms.Opening += cms_Opening;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(245, 22);
            showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            showApplicationDetailsToolStripMenuItem.Click += showApplicationDetailsToolStripMenuItem_Click;
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Image = Properties.Resources.edit_32;
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(245, 22);
            editApplicationToolStripMenuItem.Text = "Edit Application";
            editApplicationToolStripMenuItem.Click += editApplicationToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(245, 22);
            deleteToolStripMenuItem.Text = "Delete Application";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Image = (Image)resources.GetObject("cancelApplicationToolStripMenuItem.Image");
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(245, 22);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // sechduleTestsToolStripMenuItem
            // 
            sechduleTestsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sechduleVisionTestToolStripMenuItem, sechduleWrittenTestToolStripMenuItem, sechduleStreetToolStripMenuItem });
            sechduleTestsToolStripMenuItem.Image = (Image)resources.GetObject("sechduleTestsToolStripMenuItem.Image");
            sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            sechduleTestsToolStripMenuItem.Size = new Size(245, 22);
            sechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // sechduleVisionTestToolStripMenuItem
            // 
            sechduleVisionTestToolStripMenuItem.Image = Properties.Resources.VisionTest;
            sechduleVisionTestToolStripMenuItem.Name = "sechduleVisionTestToolStripMenuItem";
            sechduleVisionTestToolStripMenuItem.Size = new Size(187, 22);
            sechduleVisionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            sechduleVisionTestToolStripMenuItem.Click += sechduleVisionTestToolStripMenuItem_Click;
            // 
            // sechduleWrittenTestToolStripMenuItem
            // 
            sechduleWrittenTestToolStripMenuItem.Image = Properties.Resources.writtenTest;
            sechduleWrittenTestToolStripMenuItem.Name = "sechduleWrittenTestToolStripMenuItem";
            sechduleWrittenTestToolStripMenuItem.Size = new Size(187, 22);
            sechduleWrittenTestToolStripMenuItem.Text = "Sechdule Written Test";
            sechduleWrittenTestToolStripMenuItem.Click += sechduleWrittenTestToolStripMenuItem_Click;
            // 
            // sechduleStreetToolStripMenuItem
            // 
            sechduleStreetToolStripMenuItem.Image = Properties.Resources.streetTest;
            sechduleStreetToolStripMenuItem.Name = "sechduleStreetToolStripMenuItem";
            sechduleStreetToolStripMenuItem.Size = new Size(187, 22);
            sechduleStreetToolStripMenuItem.Text = "Sechdule Street Test";
            sechduleStreetToolStripMenuItem.Click += sechduleStreetToolStripMenuItem_Click;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = (Image)resources.GetObject("issueDrivingLicenseFirstTimeToolStripMenuItem.Image");
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(245, 22);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseToolStripMenuItem.Image");
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(245, 22);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // btnAddLDLA
            // 
            btnAddLDLA.BackgroundImage = (Image)resources.GetObject("btnAddLDLA.BackgroundImage");
            btnAddLDLA.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddLDLA.Location = new Point(901, 127);
            btnAddLDLA.Name = "btnAddLDLA";
            btnAddLDLA.Size = new Size(42, 39);
            btnAddLDLA.TabIndex = 17;
            btnAddLDLA.UseVisualStyleBackColor = true;
            btnAddLDLA.Click += btnAddLDLA_Click;
            // 
            // FrmManageLocalDrivingLicesnseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 437);
            Controls.Add(btnAddLDLA);
            Controls.Add(txtFilter);
            Controls.Add(label3);
            Controls.Add(cbFilter);
            Controls.Add(lblRecords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvLocalDrivingLicenseApplication);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "FrmManageLocalDrivingLicesnseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Local Driving Licesnse Applications";
            Load += FrmManageLocalDrivingLicesnseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplication).EndInit();
            cms.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Label label3;
        private ComboBox cbFilter;
        private Label lblRecords;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvLocalDrivingLicenseApplication;
        private Button btnAddLDLA;
        private ContextMenuStrip cms;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private ToolStripMenuItem sechduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem sechduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem sechduleVisionTToolStripMenuItem;
        private ToolStripMenuItem sechduleStreetToolStripMenuItem;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
    }
}