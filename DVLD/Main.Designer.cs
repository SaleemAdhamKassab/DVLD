namespace DVLD
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMainMenue = new MenuStrip();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicenToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replacmentToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            typeToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseApplicationToolStripMenuItem = new ToolStripMenuItem();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageDetainedLicensesToolStripMenuItem = new ToolStripMenuItem();
            detailLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestsToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signToolStripMenuItem = new ToolStripMenuItem();
            msMainMenue.SuspendLayout();
            SuspendLayout();
            // 
            // msMainMenue
            // 
            msMainMenue.Items.AddRange(new ToolStripItem[] { applicationsToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountSettingsToolStripMenuItem });
            msMainMenue.Location = new Point(0, 0);
            msMainMenue.Name = "msMainMenue";
            msMainMenue.Size = new Size(1003, 24);
            msMainMenue.TabIndex = 0;
            msMainMenue.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicenToolStripMenuItem, typeToolStripMenuItem, detainLicensesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestsToolStripMenuItem });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(85, 20);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicenToolStripMenuItem
            // 
            drivingLicenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replacmentToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicenToolStripMenuItem.Name = "drivingLicenToolStripMenuItem";
            drivingLicenToolStripMenuItem.Size = new Size(213, 22);
            drivingLicenToolStripMenuItem.Text = "Driving Licenses Service";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(290, 22);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(183, 22);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(183, 22);
            internationalLicenseToolStripMenuItem.Text = "International License";
            internationalLicenseToolStripMenuItem.Click += internationalLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(290, 22);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // replacmentToolStripMenuItem
            // 
            replacmentToolStripMenuItem.Name = "replacmentToolStripMenuItem";
            replacmentToolStripMenuItem.Size = new Size(290, 22);
            replacmentToolStripMenuItem.Text = "Replacment for Lost or Damaged License";
            replacmentToolStripMenuItem.Click += replacmentToolStripMenuItem_Click;
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(290, 22);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            retakeTestToolStripMenuItem.Click += retakeTestToolStripMenuItem_Click;
            // 
            // typeToolStripMenuItem
            // 
            typeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseToolStripMenuItem, internationalLicenseApplicationToolStripMenuItem });
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(213, 22);
            typeToolStripMenuItem.Text = "Manage Applications";
            typeToolStripMenuItem.Click += typeToolStripMenuItem_Click;
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            localDrivingLicenseToolStripMenuItem.Size = new Size(249, 22);
            localDrivingLicenseToolStripMenuItem.Text = "Local Driving License Application";
            localDrivingLicenseToolStripMenuItem.Click += localDrivingLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            internationalLicenseApplicationToolStripMenuItem.Size = new Size(249, 22);
            internationalLicenseApplicationToolStripMenuItem.Text = "International License Application";
            internationalLicenseApplicationToolStripMenuItem.Click += internationalLicenseApplicationToolStripMenuItem_Click;
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainedLicensesToolStripMenuItem, detailLicenseToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(213, 22);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            manageDetainedLicensesToolStripMenuItem.Size = new Size(214, 22);
            manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            manageDetainedLicensesToolStripMenuItem.Click += manageDetainedLicensesToolStripMenuItem_Click;
            // 
            // detailLicenseToolStripMenuItem
            // 
            detailLicenseToolStripMenuItem.Name = "detailLicenseToolStripMenuItem";
            detailLicenseToolStripMenuItem.Size = new Size(214, 22);
            detailLicenseToolStripMenuItem.Text = "Detain License";
            detailLicenseToolStripMenuItem.Click += detailLicenseToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(214, 22);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(213, 22);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestsToolStripMenuItem
            // 
            manageTestsToolStripMenuItem.Name = "manageTestsToolStripMenuItem";
            manageTestsToolStripMenuItem.Size = new Size(213, 22);
            manageTestsToolStripMenuItem.Text = "Manage Test Type";
            manageTestsToolStripMenuItem.Click += manageTestsToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(55, 20);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += PeopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(55, 20);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(47, 20);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signToolStripMenuItem });
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(109, 20);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(168, 22);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(168, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signToolStripMenuItem
            // 
            signToolStripMenuItem.Name = "signToolStripMenuItem";
            signToolStripMenuItem.Size = new Size(168, 22);
            signToolStripMenuItem.Text = "Sign Out";
            signToolStripMenuItem.Click += SignToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1003, 436);
            Controls.Add(msMainMenue);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = msMainMenue;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            msMainMenue.ResumeLayout(false);
            msMainMenue.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMainMenue;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem accountSettingsToolStripMenuItem;
        private ToolStripMenuItem signToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem typeToolStripMenuItem;
        private ToolStripMenuItem manageTestsToolStripMenuItem;
        private ToolStripMenuItem drivingLicenToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem replacmentToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem detailLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
    }
}