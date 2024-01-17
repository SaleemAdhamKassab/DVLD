using DVLD.Helpers;
using DVLD.Licenses.Local_Licenses;
using DVLD_Buisness;
using Sahred.Dtos;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    public partial class FrmReplaceLostOrDamagedLicenseApplication : Form
    {
        public FrmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
            btnIssueReplacment.Enabled = false;
            lnkShowNewLicenseInfo.Enabled = false;
        }

        private void fillApplicationInfoForLicenseReplacment(enApplicationType applicationType)
        {
            lblApplicationFees.Text = ApplicationType.get((byte)applicationType).Fees.ToString("0.00");
            lblOldLicenseId.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.Id.ToString();
            lblCreatedBy.Text = LoggedUser.User.UserName;
            btnIssueReplacment.Enabled = true;
        }

        ///////////////////// Events ////////////////////////////////

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e) => fillApplicationInfoForLicenseReplacment(enApplicationType.ReplaceDamagedDrivingLicense);

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e) => fillApplicationInfoForLicenseReplacment(enApplicationType.ReplaceLostDrivingLicense);

        private void lnkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frmShowLicenseInfo = new(ctrlDriverLicenseInfoWithFilter1.InsertedLicense);
            frmShowLicenseInfo.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////

        private void btnIssueReplacment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            enApplicationType applicationType = rbDamagedLicense.Checked ? enApplicationType.ReplaceDamagedDrivingLicense : enApplicationType.ReplaceLostDrivingLicense;

            LicenseDto licenseDto = ctrlDriverLicenseInfoWithFilter1.replaceLicense(applicationType);

            if (licenseDto is null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblReplacedLicenseId.Text = ctrlDriverLicenseInfoWithFilter1.InsertedLicense.ToString();

            MessageBox.Show("Licensed Renewed Successfully with ID=" + ctrlDriverLicenseInfoWithFilter1.InsertedLicense.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacment.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            gbReplacmentFor.Enabled = false;
            lnkShowNewLicenseInfo.Enabled = true;
        }
    }
}
