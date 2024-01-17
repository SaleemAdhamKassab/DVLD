namespace DVLD.Applications.International_License
{
    partial class FrmManageInternationalLicesnseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageInternationalLicesnseApplications));
            btnNewApplication = new Button();
            txtFilter = new TextBox();
            label3 = new Label();
            cbFilter = new ComboBox();
            lblRecords = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvInternationalLicenses = new DataGridView();
            cmsInternationalLicense = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            cmsInternationalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnNewApplication
            // 
            btnNewApplication.BackgroundImage = (Image)resources.GetObject("btnNewApplication.BackgroundImage");
            btnNewApplication.BackgroundImageLayout = ImageLayout.Zoom;
            btnNewApplication.Location = new Point(802, 127);
            btnNewApplication.Name = "btnNewApplication";
            btnNewApplication.Size = new Size(42, 39);
            btnNewApplication.TabIndex = 26;
            btnNewApplication.UseVisualStyleBackColor = true;
            btnNewApplication.Click += btnNewApplication_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(279, 143);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(173, 23);
            txtFilter.TabIndex = 25;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 143);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 24;
            label3.Text = "Filter By:";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "International License Id", "Application Id", "Driver Id", "License Id" });
            cbFilter.Location = new Point(91, 143);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(182, 23);
            cbFilter.TabIndex = 23;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(95, 401);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(0, 15);
            lblRecords.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 401);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 21;
            label2.Text = "#Records:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(247, 104);
            label1.Name = "label1";
            label1.Size = new Size(368, 25);
            label1.TabIndex = 20;
            label1.Text = "International License Applications";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AllowUserToOrderColumns = true;
            dgvInternationalLicenses.BackgroundColor = Color.White;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.ContextMenuStrip = cmsInternationalLicense;
            dgvInternationalLicenses.Location = new Point(27, 172);
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.ReadOnly = true;
            dgvInternationalLicenses.RowTemplate.Height = 25;
            dgvInternationalLicenses.Size = new Size(817, 215);
            dgvInternationalLicenses.TabIndex = 18;
            // 
            // cmsInternationalLicense
            // 
            cmsInternationalLicense.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cmsInternationalLicense.Name = "cmsInternationalLicense";
            cmsInternationalLicense.Size = new Size(226, 92);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showPersonDetailsToolStripMenuItem.Image");
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(225, 22);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseDetailsToolStripMenuItem.Image");
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(225, 22);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(465, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 44);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image");
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(225, 22);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // FrmManageInternationalLicesnseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 428);
            Controls.Add(pictureBox2);
            Controls.Add(btnNewApplication);
            Controls.Add(txtFilter);
            Controls.Add(label3);
            Controls.Add(cbFilter);
            Controls.Add(lblRecords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvInternationalLicenses);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "FrmManageInternationalLicesnseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage International Licesnse Applications";
            Load += FrmManageInternationalLicesnseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            cmsInternationalLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewApplication;
        private TextBox txtFilter;
        private Label label3;
        private ComboBox cbFilter;
        private Label lblRecords;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvInternationalLicenses;
        private PictureBox pictureBox2;
        private ContextMenuStrip cmsInternationalLicense;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}