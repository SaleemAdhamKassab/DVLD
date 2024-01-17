namespace DVLD.Tests
{
    partial class FrmScheduleTest
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
            ctrlScheduleTest1 = new CustomControls.CtrlScheduleTest();
            SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.Location = new Point(12, 12);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new Size(348, 618);
            ctrlScheduleTest1.TabIndex = 0;
            // 
            // FrmScheduleTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 635);
            Controls.Add(ctrlScheduleTest1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "FrmScheduleTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Test";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CtrlScheduleTest ctrlScheduleTest1;
    }
}