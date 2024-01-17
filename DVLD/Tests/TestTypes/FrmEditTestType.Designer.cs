namespace DVLD.Tests
{
    partial class FrmEditTestType
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
            errorProviderEditTestTypes = new ErrorProvider(components);
            btnSave = new Button();
            numericUpDownFees = new NumericUpDown();
            label3 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            lblApplicationTypeId = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderEditTestTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFees).BeginInit();
            SuspendLayout();
            // 
            // errorProviderEditTestTypes
            // 
            errorProviderEditTestTypes.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 171);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numericUpDownFees
            // 
            numericUpDownFees.Location = new Point(100, 116);
            numericUpDownFees.Name = "numericUpDownFees";
            numericUpDownFees.Size = new Size(163, 23);
            numericUpDownFees.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 124);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 11;
            label3.Text = "Fees:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(100, 41);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(163, 69);
            txtTitle.TabIndex = 10;
            txtTitle.Validating += validateEmptyTextBox;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 41);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = "Title:";
            // 
            // lblApplicationTypeId
            // 
            lblApplicationTypeId.AutoSize = true;
            lblApplicationTypeId.Location = new Point(100, 9);
            lblApplicationTypeId.Name = "lblApplicationTypeId";
            lblApplicationTypeId.Size = new Size(17, 15);
            lblApplicationTypeId.TabIndex = 8;
            lblApplicationTypeId.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 7;
            label1.Text = "Id:";
            // 
            // FrmEditTestType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 205);
            Controls.Add(btnSave);
            Controls.Add(numericUpDownFees);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(lblApplicationTypeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmEditTestType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Test Type";
            ((System.ComponentModel.ISupportInitialize)errorProviderEditTestTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProviderEditTestTypes;
        private Button btnSave;
        private NumericUpDown numericUpDownFees;
        private Label label3;
        private TextBox txtTitle;
        private Label label2;
        private Label lblApplicationTypeId;
        private Label label1;
    }
}