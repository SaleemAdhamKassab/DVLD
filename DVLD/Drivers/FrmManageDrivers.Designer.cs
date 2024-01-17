namespace DVLD.Drivers
{
    partial class FrmManageDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageDrivers));
            dgvDrivers = new DataGridView();
            cmsDrivers = new ContextMenuStrip(components);
            detailsToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            txtFilter = new TextBox();
            label3 = new Label();
            cbFilter = new ComboBox();
            lblRecords = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            cmsDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AllowUserToOrderColumns = true;
            dgvDrivers.BackgroundColor = Color.White;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.ContextMenuStrip = cmsDrivers;
            dgvDrivers.Location = new Point(12, 186);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.RowTemplate.Height = 25;
            dgvDrivers.Size = new Size(819, 215);
            dgvDrivers.TabIndex = 10;
            // 
            // cmsDrivers
            // 
            cmsDrivers.Items.AddRange(new ToolStripItem[] { detailsToolStripMenuItem, deleteToolStripMenuItem });
            cmsDrivers.Name = "cmsPeople";
            cmsDrivers.Size = new Size(226, 70);
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(225, 22);
            detailsToolStripMenuItem.Text = "Show Person Info";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(225, 22);
            deleteToolStripMenuItem.Text = "Show Person License History";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(201, 155);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(173, 23);
            txtFilter.TabIndex = 17;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "Filter By:";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Driver Id", "Person Id", "National Number", "Full Name" });
            cbFilter.Location = new Point(74, 155);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 15;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Location = new Point(85, 416);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(0, 15);
            lblRecords.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 416);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 13;
            label2.Text = "#Records:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(356, 114);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 12;
            label1.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(383, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FrmManageDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 451);
            Controls.Add(dgvDrivers);
            Controls.Add(txtFilter);
            Controls.Add(label3);
            Controls.Add(cbFilter);
            Controls.Add(lblRecords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmManageDrivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Drivers";
            Load += FrmManageDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            cmsDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrivers;
        private ContextMenuStrip cmsDrivers;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TextBox txtFilter;
        private Label label3;
        private ComboBox cbFilter;
        private Label lblRecords;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}