using DVLD.Helpers;
using DVLD.Licenses.Local_Licenses;
using DVLD_Buisness;
using Sahred.Dtos;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Applications.Rlease_Detained_License
{
    public partial class FrmReleaseDetainedLicenseApplication : Form
    {
        public int _detainedId = -1;

        public FrmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
            lnkShowNewLicenseInfo.Enabled = false;
            btnRelease.Enabled = false;
        }

        public FrmReleaseDetainedLicenseApplication(int licenseId)
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.SelectedLicense = MappingProfiles.LicenseDtoToLicense(License.get(licenseId), ctrlDriverLicenseInfoWithFilter1.SelectedLicense);
            lnkShowNewLicenseInfo.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.loadLicenseInfo(licenseId);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        ///////////////////////////////////  Events //////////////////////////////////////
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int selectedLicenseId = obj;

            if (!DetainedLicense.isLicenseDetained(selectedLicenseId))
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetainedLicenseDto detainedLicenseDto = DetainedLicense.getByLicenseId(selectedLicenseId);
            _detainedId = detainedLicenseDto.Id;
            lblLicenseId.Text = detainedLicenseDto.LicenseId.ToString();
            lblDetainId.Text = detainedLicenseDto.Id.ToString();
            lblApplicationFees.Text = ApplicationType.get((byte)enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString("0.00");
            lblFineFees.Text = detainedLicenseDto.FineFees.ToString("0.00");
            lblTotalFees.Text = (int.Parse(detainedLicenseDto.FineFees.ToString()) + decimal.Parse(lblApplicationFees.Text)).ToString("0.00");
            lblCreatedBy.Text = LoggedUser.User.UserName;

            btnRelease.Enabled = true;
        }

        private void lnkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frmShowLicenseInfo = new(ctrlDriverLicenseInfoWithFilter1.SelectedLicense.Id);
            frmShowLicenseInfo.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////////
        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (ctrlDriverLicenseInfoWithFilter1.releaseDetainedLicense(_detainedId))
            {
                MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApplicationId.Text = ctrlDriverLicenseInfoWithFilter1.InsertedDetainedLicenseId.ToString();
                btnRelease.Enabled = false;
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                lnkShowNewLicenseInfo.Enabled = true;
            }
            else
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
