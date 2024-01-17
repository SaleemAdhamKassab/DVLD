namespace DVLD.CustomControls.Test
{
    partial class CtrlTakeTest
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
            label1 = new Label();
            lblTestId = new Label();
            gpResult = new GroupBox();
            btnSave = new Button();
            label2 = new Label();
            txtNotes = new TextBox();
            label3 = new Label();
            rbFail = new RadioButton();
            rbPass = new RadioButton();
            ctrlScheduleAndTakeTestSharedControls1 = new CtrlScheduleAndTakeTestSharedControls();
            gpResult.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 466);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Test Id:";
            // 
            // lblTestId
            // 
            lblTestId.AutoSize = true;
            lblTestId.Location = new Point(130, 469);
            lblTestId.Name = "lblTestId";
            lblTestId.Size = new Size(79, 15);
            lblTestId.TabIndex = 2;
            lblTestId.Text = "Not Taken Yet";
            // 
            // gpResult
            // 
            gpResult.Controls.Add(btnSave);
            gpResult.Controls.Add(label2);
            gpResult.Controls.Add(txtNotes);
            gpResult.Controls.Add(label3);
            gpResult.Controls.Add(rbFail);
            gpResult.Controls.Add(rbPass);
            gpResult.Location = new Point(12, 487);
            gpResult.Name = "gpResult";
            gpResult.Size = new Size(340, 147);
            gpResult.TabIndex = 5;
            gpResult.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(255, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 54);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(78, 51);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(251, 59);
            txtNotes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 28);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Result:";
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Checked = true;
            rbFail.Location = new Point(153, 26);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(43, 19);
            rbFail.TabIndex = 3;
            rbFail.TabStop = true;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Location = new Point(78, 26);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(48, 19);
            rbPass.TabIndex = 2;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // ctrlScheduleAndTakeTestSharedControls1
            // 
            ctrlScheduleAndTakeTestSharedControls1.Location = new Point(12, 3);
            ctrlScheduleAndTakeTestSharedControls1.Name = "ctrlScheduleAndTakeTestSharedControls1";
            ctrlScheduleAndTakeTestSharedControls1.Size = new Size(340, 460);
            ctrlScheduleAndTakeTestSharedControls1.TabIndex = 6;
            // 
            // CtrlTakeTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlScheduleAndTakeTestSharedControls1);
            Controls.Add(gpResult);
            Controls.Add(lblTestId);
            Controls.Add(label1);
            Name = "CtrlTakeTest";
            Size = new Size(373, 637);
            gpResult.ResumeLayout(false);
            gpResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTestId;
        private GroupBox gpResult;
        private Button btnSave;
        private Label label2;
        private TextBox txtNotes;
        private Label label3;
        private RadioButton rbFail;
        private RadioButton rbPass;
        private CtrlScheduleAndTakeTestSharedControls ctrlScheduleAndTakeTestSharedControls1;
    }
}
