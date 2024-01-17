namespace DVLD.Tests
{
    partial class FrmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageTestTypes));
            dgvTestTypes = new DataGridView();
            lblTestTypesRecords = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cmsManageTestTypes = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cmsManageTestTypes.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AllowUserToOrderColumns = true;
            dgvTestTypes.BackgroundColor = Color.White;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.ContextMenuStrip = cmsManageTestTypes;
            dgvTestTypes.Location = new Point(12, 149);
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dgvTestTypes.RowTemplate.Height = 25;
            dgvTestTypes.Size = new Size(549, 215);
            dgvTestTypes.TabIndex = 2;
            // 
            // lblTestTypesRecords
            // 
            lblTestTypesRecords.AutoSize = true;
            lblTestTypesRecords.Location = new Point(80, 387);
            lblTestTypesRecords.Name = "lblTestTypesRecords";
            lblTestTypesRecords.Size = new Size(0, 15);
            lblTestTypesRecords.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 387);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "#Records:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(188, 102);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 8;
            label1.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(251, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cmsManageTestTypes
            // 
            cmsManageTestTypes.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            cmsManageTestTypes.Name = "cmsManageTestTypes";
            cmsManageTestTypes.Size = new Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // FrmManageTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 416);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblTestTypesRecords);
            Controls.Add(label2);
            Controls.Add(dgvTestTypes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmManageTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Test Types";
            Load += FrmManageTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cmsManageTestTypes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTestTypes;
        private Label lblTestTypesRecords;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ContextMenuStrip cmsManageTestTypes;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}