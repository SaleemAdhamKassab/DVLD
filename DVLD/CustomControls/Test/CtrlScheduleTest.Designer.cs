namespace DVLD.CustomControls
{
    partial class CtrlScheduleTest
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
            ctrlScheduleAndTakeTestSharedControls1 = new CtrlScheduleAndTakeTestSharedControls();
            gbRetakeTest = new GroupBox();
            lblTotalFees = new Label();
            label4 = new Label();
            lblRetakeAppFees = new Label();
            label1 = new Label();
            btnSave = new Button();
            gbRetakeTest.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlScheduleAndTakeTestSharedControls1
            // 
            ctrlScheduleAndTakeTestSharedControls1.Location = new Point(3, 3);
            ctrlScheduleAndTakeTestSharedControls1.Name = "ctrlScheduleAndTakeTestSharedControls1";
            ctrlScheduleAndTakeTestSharedControls1.Size = new Size(340, 460);
            ctrlScheduleAndTakeTestSharedControls1.TabIndex = 0;
            // 
            // gbRetakeTest
            // 
            gbRetakeTest.Controls.Add(lblTotalFees);
            gbRetakeTest.Controls.Add(label4);
            gbRetakeTest.Controls.Add(lblRetakeAppFees);
            gbRetakeTest.Controls.Add(label1);
            gbRetakeTest.Location = new Point(27, 469);
            gbRetakeTest.Name = "gbRetakeTest";
            gbRetakeTest.Size = new Size(300, 87);
            gbRetakeTest.TabIndex = 1;
            gbRetakeTest.TabStop = false;
            gbRetakeTest.Text = "Retake Test";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(131, 56);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(17, 15);
            lblTotalFees.TabIndex = 5;
            lblTotalFees.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 56);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "Total Fees: ";
            // 
            // lblRetakeAppFees
            // 
            lblRetakeAppFees.AutoSize = true;
            lblRetakeAppFees.Location = new Point(131, 31);
            lblRetakeAppFees.Name = "lblRetakeAppFees";
            lblRetakeAppFees.Size = new Size(17, 15);
            lblRetakeAppFees.TabIndex = 1;
            lblRetakeAppFees.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Retake App Fees: ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(252, 562);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CtrlScheduleTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(gbRetakeTest);
            Controls.Add(ctrlScheduleAndTakeTestSharedControls1);
            Name = "CtrlScheduleTest";
            Size = new Size(348, 594);
            gbRetakeTest.ResumeLayout(false);
            gbRetakeTest.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CtrlScheduleAndTakeTestSharedControls ctrlScheduleAndTakeTestSharedControls1;
        private GroupBox gbRetakeTest;
        private Button btnSave;
        private Label lblRetakeAppFees;
        private Label label1;
        private Label lblTotalFees;
        private Label label4;
    }
}
