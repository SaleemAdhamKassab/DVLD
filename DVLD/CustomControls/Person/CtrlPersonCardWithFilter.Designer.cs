namespace DVLD.People.Controls
{
    partial class CtrlPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPersonCardWithFilter));
            personCard1 = new CtrlPersonCard();
            gbFilter = new GroupBox();
            btnAddPerson = new Button();
            btnSearchPerson = new Button();
            cbFilter = new ComboBox();
            txtFilter = new TextBox();
            label1 = new Label();
            errorProviderPersonCardWithFilter = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderPersonCardWithFilter).BeginInit();
            SuspendLayout();
            // 
            // personCard1
            // 
            personCard1.Location = new Point(3, 104);
            personCard1.Name = "personCard1";
            personCard1.Size = new Size(586, 290);
            personCard1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddPerson);
            gbFilter.Controls.Add(btnSearchPerson);
            gbFilter.Controls.Add(cbFilter);
            gbFilter.Controls.Add(txtFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.Location = new Point(18, 21);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(561, 77);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackgroundImage = (Image)resources.GetObject("btnAddPerson.BackgroundImage");
            btnAddPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPerson.Location = new Point(407, 30);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(30, 23);
            btnAddPerson.TabIndex = 3;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += BtnAddPerson_Click;
            // 
            // btnSearchPerson
            // 
            btnSearchPerson.BackgroundImage = Properties.Resources.SearchPerson1;
            btnSearchPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchPerson.Location = new Point(371, 30);
            btnSearchPerson.Name = "btnSearchPerson";
            btnSearchPerson.Size = new Size(30, 23);
            btnSearchPerson.TabIndex = 3;
            btnSearchPerson.UseVisualStyleBackColor = true;
            btnSearchPerson.Click += BtnSearch_Click;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "National No.", "Person Id" });
            cbFilter.Location = new Point(82, 30);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 2;
            cbFilter.Text = "National No.";
            cbFilter.SelectedIndexChanged += CbFilter_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(220, 30);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(132, 23);
            txtFilter.TabIndex = 1;
            txtFilter.KeyPress += TxtFilter_KeyPress;
            txtFilter.Validating += TxtFilter_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 0;
            label1.Text = "Find By";
            // 
            // errorProviderPersonCardWithFilter
            // 
            errorProviderPersonCardWithFilter.ContainerControl = this;
            // 
            // CtrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(personCard1);
            Name = "CtrlPersonCardWithFilter";
            Size = new Size(598, 415);
            Load += PersonCardWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderPersonCardWithFilter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CtrlPersonCard personCard1;
        private GroupBox gbFilter;
        private ComboBox cbFilter;
        private TextBox txtFilter;
        private Label label1;
        private Button btnSearchPerson;
        private ErrorProvider errorProviderPersonCardWithFilter;
        private Button btnAddPerson;
    }
}
