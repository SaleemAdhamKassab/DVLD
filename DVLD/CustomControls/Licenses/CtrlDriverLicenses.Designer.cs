namespace DVLD.CustomControls.Licenses
{
    partial class CtrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlDriverLicenses));
            tabControl1 = new TabControl();
            tabPageLocal = new TabPage();
            lblLocalHistoryRecords = new Label();
            label2 = new Label();
            dgvLocalLicenses = new DataGridView();
            tabPageInternational = new TabPage();
            dgvInternationalLicenses = new DataGridView();
            lblInternationalRecords = new Label();
            label3 = new Label();
            cmsLocalLicenseHistory = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPageLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).BeginInit();
            tabPageInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            cmsLocalLicenseHistory.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLocal);
            tabControl1.Controls.Add(tabPageInternational);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(576, 220);
            tabControl1.TabIndex = 1;
            // 
            // tabPageLocal
            // 
            tabPageLocal.Controls.Add(lblLocalHistoryRecords);
            tabPageLocal.Controls.Add(label2);
            tabPageLocal.Controls.Add(dgvLocalLicenses);
            tabPageLocal.Location = new Point(4, 24);
            tabPageLocal.Name = "tabPageLocal";
            tabPageLocal.Padding = new Padding(3);
            tabPageLocal.Size = new Size(568, 192);
            tabPageLocal.TabIndex = 0;
            tabPageLocal.Text = "Local";
            tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // lblLocalHistoryRecords
            // 
            lblLocalHistoryRecords.AutoSize = true;
            lblLocalHistoryRecords.Location = new Point(77, 169);
            lblLocalHistoryRecords.Name = "lblLocalHistoryRecords";
            lblLocalHistoryRecords.Size = new Size(0, 15);
            lblLocalHistoryRecords.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 169);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "#Records:";
            // 
            // dgvLocalLicenses
            // 
            dgvLocalLicenses.AllowUserToAddRows = false;
            dgvLocalLicenses.AllowUserToDeleteRows = false;
            dgvLocalLicenses.AllowUserToOrderColumns = true;
            dgvLocalLicenses.BackgroundColor = Color.White;
            dgvLocalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalLicenses.ContextMenuStrip = cmsLocalLicenseHistory;
            dgvLocalLicenses.Location = new Point(9, 15);
            dgvLocalLicenses.Name = "dgvLocalLicenses";
            dgvLocalLicenses.ReadOnly = true;
            dgvLocalLicenses.RowTemplate.Height = 25;
            dgvLocalLicenses.Size = new Size(544, 151);
            dgvLocalLicenses.TabIndex = 2;
            // 
            // tabPageInternational
            // 
            tabPageInternational.Controls.Add(dgvInternationalLicenses);
            tabPageInternational.Controls.Add(lblInternationalRecords);
            tabPageInternational.Controls.Add(label3);
            tabPageInternational.Location = new Point(4, 24);
            tabPageInternational.Name = "tabPageInternational";
            tabPageInternational.Padding = new Padding(3);
            tabPageInternational.Size = new Size(568, 192);
            tabPageInternational.TabIndex = 1;
            tabPageInternational.Text = "International";
            tabPageInternational.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AllowUserToOrderColumns = true;
            dgvInternationalLicenses.BackgroundColor = Color.White;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.Location = new Point(9, 15);
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.ReadOnly = true;
            dgvInternationalLicenses.RowTemplate.Height = 25;
            dgvInternationalLicenses.Size = new Size(544, 151);
            dgvInternationalLicenses.TabIndex = 13;
            // 
            // lblInternationalRecords
            // 
            lblInternationalRecords.AutoSize = true;
            lblInternationalRecords.Location = new Point(77, 169);
            lblInternationalRecords.Name = "lblInternationalRecords";
            lblInternationalRecords.Size = new Size(0, 15);
            lblInternationalRecords.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 169);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 11;
            label3.Text = "#Records:";
            // 
            // cmsLocalLicenseHistory
            // 
            cmsLocalLicenseHistory.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            cmsLocalLicenseHistory.Name = "cmsLocalLicenseHistory";
            cmsLocalLicenseHistory.Size = new Size(181, 48);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseInfoToolStripMenuItem.Image");
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(180, 22);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // CtrlDriverLicenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "CtrlDriverLicenses";
            Size = new Size(586, 230);
            tabControl1.ResumeLayout(false);
            tabPageLocal.ResumeLayout(false);
            tabPageLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).EndInit();
            tabPageInternational.ResumeLayout(false);
            tabPageInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            cmsLocalLicenseHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageLocal;
        private Label lblLocalHistoryRecords;
        private Label label2;
        private DataGridView dgvLocalLicenses;
        private TabPage tabPageInternational;
        private Label lblInternationalRecords;
        private Label label3;
        private DataGridView dgvInternationalLicenses;
        private ContextMenuStrip cmsLocalLicenseHistory;
        private ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
