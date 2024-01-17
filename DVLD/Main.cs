using DVLD.Applications.Application_Types;
using DVLD.Applications.International_License;
using DVLD.Applications.Local_Driving_License;
using DVLD.Applications.Renew_Local_License;
using DVLD.Applications.ReplaceLostOrDamagedLicense;
using DVLD.Applications.Rlease_Detained_License;
using DVLD.Drivers;
using DVLD.Helpers;
using DVLD.Licenses.Detain_License;
using DVLD.Login;
using DVLD.Tests;
using DVLD.Users;

namespace DVLD
{
    public partial class Main : Form
    {
        private readonly FrmLogin _frmLogin;
        public Main(FrmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditUser frmAddEditPerson = new();
            frmAddEditPerson.ShowDialog();
        }

        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePeople frmManagePeople = new();
            frmManagePeople.ShowDialog();
        }

        private void SignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggedUser.Logout();
            Close();
            _frmLogin.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmManageUsers = new();
            frmManageUsers.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowUserInfo frmShowUserInfo = new(LoggedUser.User.Id);
            frmShowUserInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new(LoggedUser.User.Id);
            frmChangePassword.ShowDialog();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageApplicationTypes frmManageApplicationTypes = new();
            frmManageApplicationTypes.ShowDialog();
        }

        private void manageTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageTestTypes frmManageTestTypes = new();
            frmManageTestTypes.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateLocalDrivingLicesnseApplication frmAddUpdateLocalDrivingLicesnseApplication = new();
            frmAddUpdateLocalDrivingLicesnseApplication.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageLocalDrivingLicesnseApplications frmManageLocalDrivingLicesnseApplications = new();
            frmManageLocalDrivingLicesnseApplications.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageLocalDrivingLicesnseApplications frmManageLocalDrivingLicesnseApplications = new();
            frmManageLocalDrivingLicesnseApplications.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRenewLocalDrivingLicenseApplication frmRenewLocalDrivingLicenseApplication = new();
            frmRenewLocalDrivingLicenseApplication.ShowDialog();
        }

        private void replacmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReplaceLostOrDamagedLicenseApplication frmReplaceLostOrDamagedLicenseApplication = new();
            frmReplaceLostOrDamagedLicenseApplication.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageDrivers frmManageDrivers = new();
            frmManageDrivers.ShowDialog();
        }

        private void detailLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetainLicenseApplication frmDetainLicenseApplication = new();
            frmDetainLicenseApplication.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReleaseDetainedLicenseApplication frmReleaseDetainedLicenseApplication = new();
            frmReleaseDetainedLicenseApplication.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageDetainedLicenses frmListDetainedLicenses = new();
            frmListDetainedLicenses.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewInternationalLicenseApplication frmNewInternationalLicenseApplication = new();
            frmNewInternationalLicenseApplication.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageInternationalLicesnseApplications frmManageInternationalLicesnseApplications = new();
            frmManageInternationalLicesnseApplications.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageApplicationTypes frmManageApplicationTypes = new();
            frmManageApplicationTypes.ShowDialog();
        }
    }
}