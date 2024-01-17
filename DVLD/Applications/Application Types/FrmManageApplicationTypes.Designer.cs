namespace DVLD.Applications.Application_Types
{
    partial class FrmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageApplicationTypes));
            dgvApplicationTypes = new DataGridView();
            cmsApplicationTypes = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblApplicationTypeRecords = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            cmsApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AllowUserToOrderColumns = true;
            dgvApplicationTypes.BackgroundColor = Color.White;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.ContextMenuStrip = cmsApplicationTypes;
            dgvApplicationTypes.Location = new Point(47, 152);
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dgvApplicationTypes.RowTemplate.Height = 25;
            dgvApplicationTypes.Size = new Size(458, 170);
            dgvApplicationTypes.TabIndex = 7;
            // 
            // cmsApplicationTypes
            // 
            cmsApplicationTypes.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            cmsApplicationTypes.Name = "cmsApplicationTypes";
            cmsApplicationTypes.Size = new Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(94, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(133, 104);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 8;
            label1.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_64;
            pictureBox1.Location = new Point(226, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblApplicationTypeRecords
            // 
            lblApplicationTypeRecords.AutoSize = true;
            lblApplicationTypeRecords.Location = new Point(118, 346);
            lblApplicationTypeRecords.Name = "lblApplicationTypeRecords";
            lblApplicationTypeRecords.Size = new Size(38, 15);
            lblApplicationTypeRecords.TabIndex = 11;
            lblApplicationTypeRecords.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 346);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 10;
            label2.Text = "#Records:";
            // 
            // FrmManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 415);
            Controls.Add(lblApplicationTypeRecords);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvApplicationTypes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmManageApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application Types";
            Load += FrmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            cmsApplicationTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvApplicationTypes;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblApplicationTypeRecords;
        private Label label2;
        private ContextMenuStrip cmsApplicationTypes;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}