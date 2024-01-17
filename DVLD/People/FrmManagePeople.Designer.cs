namespace DVLD
{
    partial class FrmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagePeople));
            btnAddPerson = new Button();
            dgvPeople = new DataGridView();
            cmsPeople = new ContextMenuStrip(components);
            detailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblPeopleRecords = new Label();
            cbFilter = new ComboBox();
            label3 = new Label();
            txtFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            cmsPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackgroundImage = Properties.Resources.Add_Person_40;
            btnAddPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPerson.Location = new Point(1139, 101);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(38, 29);
            btnAddPerson.TabIndex = 0;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += BtnAddPerson_Click;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToOrderColumns = true;
            dgvPeople.BackgroundColor = Color.White;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = cmsPeople;
            dgvPeople.Location = new Point(12, 132);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowTemplate.Height = 25;
            dgvPeople.Size = new Size(1165, 215);
            dgvPeople.TabIndex = 1;
            // 
            // cmsPeople
            // 
            cmsPeople.Items.AddRange(new ToolStripItem[] { detailsToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            cmsPeople.Name = "cmsPeople";
            cmsPeople.Size = new Size(181, 92);
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(180, 22);
            detailsToolStripMenuItem.Text = "Show Details";
            detailsToolStripMenuItem.Click += DetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.People_400;
            pictureBox1.Location = new Point(495, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(470, 101);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 3;
            label1.Text = "Manage People";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 367);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "#Records:";
            // 
            // lblPeopleRecords
            // 
            lblPeopleRecords.AutoSize = true;
            lblPeopleRecords.Location = new Point(89, 367);
            lblPeopleRecords.Name = "lblPeopleRecords";
            lblPeopleRecords.Size = new Size(0, 15);
            lblPeopleRecords.TabIndex = 5;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Person Id", "National No.", "First Name", "Second Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cbFilter.Location = new Point(74, 101);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 6;
            cbFilter.SelectedIndexChanged += CbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Filter By:";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(201, 101);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(173, 23);
            txtFilter.TabIndex = 8;
            txtFilter.TextChanged += TxtFilter_TextChanged;
            txtFilter.KeyPress += TxtFilter_KeyPress;
            // 
            // FrmManagePeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 391);
            Controls.Add(txtFilter);
            Controls.Add(label3);
            Controls.Add(cbFilter);
            Controls.Add(lblPeopleRecords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvPeople);
            Controls.Add(btnAddPerson);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmManagePeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += FrmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            cmsPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPerson;
        private DataGridView dgvPeople;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblPeopleRecords;
        private ContextMenuStrip cmsPeople;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ComboBox cbFilter;
        private Label label3;
        private TextBox txtFilter;
        private ToolStripMenuItem detailsToolStripMenuItem;
    }
}