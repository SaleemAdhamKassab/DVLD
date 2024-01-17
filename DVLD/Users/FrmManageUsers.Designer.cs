namespace DVLD.Users
{
    partial class FrmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageUsers));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            cmsUsers = new ContextMenuStrip(components);
            detailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblUserRecords = new Label();
            txtFilter = new TextBox();
            label3 = new Label();
            cbFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            cmsUsers.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.manageUsers;
            pictureBox1.Location = new Point(316, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(295, 104);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 4;
            label1.Text = "Manage Users";
            // 
            // btnAddUser
            // 
            btnAddUser.BackgroundImage = Properties.Resources.Add_Person_40;
            btnAddUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddUser.Location = new Point(687, 141);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(35, 24);
            btnAddUser.TabIndex = 5;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += BtnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToOrderColumns = true;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = cmsUsers;
            dgvUsers.Location = new Point(25, 171);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(697, 215);
            dgvUsers.TabIndex = 6;
            // 
            // cmsUsers
            // 
            cmsUsers.Items.AddRange(new ToolStripItem[] { detailsToolStripMenuItem, editToolStripMenuItem, changePasswordToolStripMenuItem, deleteToolStripMenuItem });
            cmsUsers.Name = "cmsUsers";
            cmsUsers.Size = new Size(181, 114);
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(180, 22);
            detailsToolStripMenuItem.Text = "Show Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = (Image)resources.GetObject("changePasswordToolStripMenuItem.Image");
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(180, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Disable";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 404);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "#Records:";
            // 
            // lblUserRecords
            // 
            lblUserRecords.AutoSize = true;
            lblUserRecords.Location = new Point(93, 404);
            lblUserRecords.Name = "lblUserRecords";
            lblUserRecords.Size = new Size(38, 15);
            lblUserRecords.TabIndex = 8;
            lblUserRecords.Text = "label3";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(214, 141);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(173, 23);
            txtFilter.TabIndex = 11;
            txtFilter.TextChanged += TxtFilter_TextChanged;
            txtFilter.KeyPress += TxtFilter_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 141);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 10;
            label3.Text = "Filter By:";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "User Id", "Person Id", "Full Name", "User Name", "Is Active" });
            cbFilter.Location = new Point(87, 141);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 9;
            cbFilter.SelectedIndexChanged += CbFilter_SelectedIndexChanged;
            // 
            // FrmManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 432);
            Controls.Add(txtFilter);
            Controls.Add(label3);
            Controls.Add(cbFilter);
            Controls.Add(lblUserRecords);
            Controls.Add(label2);
            Controls.Add(dgvUsers);
            Controls.Add(btnAddUser);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "FrmManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Load += FrmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            cmsUsers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAddUser;
        private DataGridView dgvUsers;
        private Label label2;
        private Label lblUserRecords;
        private TextBox txtFilter;
        private Label label3;
        private ComboBox cbFilter;
        private ContextMenuStrip cmsUsers;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}