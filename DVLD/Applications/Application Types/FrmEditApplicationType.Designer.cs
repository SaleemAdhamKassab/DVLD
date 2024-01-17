namespace DVLD.Applications.Application_Types
{
    partial class FrmEditApplicationType
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
            label1 = new Label();
            lblApplicationTypeId = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            numericUpDownFees = new NumericUpDown();
            btnSave = new Button();
            errorProviderUpdateApplicationType = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownFees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUpdateApplicationType).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // lblApplicationTypeId
            // 
            lblApplicationTypeId.AutoSize = true;
            lblApplicationTypeId.Location = new Point(101, 21);
            lblApplicationTypeId.Name = "lblApplicationTypeId";
            lblApplicationTypeId.Size = new Size(38, 15);
            lblApplicationTypeId.TabIndex = 1;
            lblApplicationTypeId.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(101, 53);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(163, 69);
            txtTitle.TabIndex = 3;
            txtTitle.Validating += validateEmptyTextBox;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Fees:";
            // 
            // numericUpDownFees
            // 
            numericUpDownFees.Location = new Point(101, 128);
            numericUpDownFees.Name = "numericUpDownFees";
            numericUpDownFees.Size = new Size(163, 23);
            numericUpDownFees.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(189, 183);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProviderUpdateApplicationType
            // 
            errorProviderUpdateApplicationType.ContainerControl = this;
            // 
            // FrmEditApplicationType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 218);
            Controls.Add(btnSave);
            Controls.Add(numericUpDownFees);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(lblApplicationTypeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmEditApplicationType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Application Type";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFees).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUpdateApplicationType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblApplicationTypeId;
        private Label label2;
        private TextBox txtTitle;
        private Label label3;
        private NumericUpDown numericUpDownFees;
        private Button btnSave;
        private ErrorProvider errorProviderUpdateApplicationType;
    }
}