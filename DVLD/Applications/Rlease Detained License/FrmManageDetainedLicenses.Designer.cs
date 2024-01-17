namespace DVLD.Applications.Rlease_Detained_License
{
    partial class FrmManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageDetainedLicenses));
            btnReleaseDetainedLicense = new Button();
            txtFilter = new TextBox();
            label3 = new Label();
            cbFilter = new ComboBox();
            lblRecords = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvManageDetainedLicenses = new DataGridView();
            cmsManageDetainedLicense = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            btnDetainLicense = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageDetainedLicenses).BeginInit();
            cmsManageDetainedLicense.SuspendLayout();
            SuspendLayout();
            // 
            // btnReleaseDetainedLicense
            // 
            btnReleaseDetainedLicense.BackgroundImage = (Image)resources.GetObject("btnReleaseDetainedLicense.BackgroundImage");
            btnReleaseDetainedLicense.BackgroundImageLayout = ImageLayout.Zoom;
            btnReleaseDetainedLicense.Location = new Point(1021, 137);
            btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            btnReleaseDetainedLicense.Size = new Size(42, 39);
            btnReleaseDetainedLicense.TabIndex = 26;
            btnReleaseDetainedLicense.UseVisualStyleBackColor = true;
            btnReleaseDetainedLicense.Click += btnReleaseDetainedLicense_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(227, 153);
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
            label3.Location = new Point(38, 153);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 24;
            label3.Text = "Filter By:";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Detained Id", "Release Application Id", "National Number", "Full Name" });
            cbFilter.Location = new Point(100, 153);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 23;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(104, 411);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(0, 15);
            lblRecords.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 411);
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
            label1.Location = new Point(425, 104);
            label1.Name = "label1";
            label1.Size = new Size(298, 25);
            label1.TabIndex = 20;
            label1.Text = "Manage Detained Licenses";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // dgvManageDetainedLicenses
            // 
            dgvManageDetainedLicenses.AllowUserToAddRows = false;
            dgvManageDetainedLicenses.AllowUserToDeleteRows = false;
            dgvManageDetainedLicenses.AllowUserToOrderColumns = true;
            dgvManageDetainedLicenses.BackgroundColor = Color.White;
            dgvManageDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageDetainedLicenses.ContextMenuStrip = cmsManageDetainedLicense;
            dgvManageDetainedLicenses.Location = new Point(36, 182);
            dgvManageDetainedLicenses.Name = "dgvManageDetainedLicenses";
            dgvManageDetainedLicenses.ReadOnly = true;
            dgvManageDetainedLicenses.RowTemplate.Height = 25;
            dgvManageDetainedLicenses.Size = new Size(1087, 215);
            dgvManageDetainedLicenses.TabIndex = 18;
            // 
            // cmsManageDetainedLicense
            // 
            cmsManageDetainedLicense.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            cmsManageDetainedLicense.Name = "cmsManageDetainedLicense";
            cmsManageDetainedLicense.Size = new Size(226, 92);
            cmsManageDetainedLicense.Opening += cmsManageDetainedLicense_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
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
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image");
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(225, 22);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = (Image)resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image");
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(225, 22);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // btnDetainLicense
            // 
            btnDetainLicense.BackgroundImage = (Image)resources.GetObject("btnDetainLicense.BackgroundImage");
            btnDetainLicense.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetainLicense.Location = new Point(1081, 137);
            btnDetainLicense.Name = "btnDetainLicense";
            btnDetainLicense.Size = new Size(42, 39);
            btnDetainLicense.TabIndex = 27;
            btnDetainLicense.UseVisualStyleBackColor = true;
            btnDetainLicense.Click += btnDetainLicense_Click;
            // 
            // FrmManageDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 450);
            Controls.Add(btnDetainLicense);
            Controls.Add(btnReleaseDetainedLicense);
            Controls.Add(txtFilter);
            Controls.Add(label3);
            Controls.Add(cbFilter);
            Controls.Add(lblRecords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvManageDetainedLicenses);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmManageDetainedLicenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Detained Licenses";
            Load += FrmManageDetainedLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageDetainedLicenses).EndInit();
            cmsManageDetainedLicense.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReleaseDetainedLicense;
        private TextBox txtFilter;
        private Label label3;
        private ComboBox cbFilter;
        private Label lblRecords;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvManageDetainedLicenses;
        private ContextMenuStrip cmsManageDetainedLicense;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private Button btnDetainLicense;
    }
}