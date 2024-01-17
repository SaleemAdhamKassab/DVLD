using DVLD.Helpers;
using DVLD.Licenses.Local_Licenses;
using DVLD_Buisness;
using Sahred.Dtos;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Applications.International_License
{
    public partial class FrmNewInternationalLicenseApplication : Form
    {
        public FrmNewInternationalLicenseApplication()
        {
            InitializeComponent();
            btnIssue.Enabled = false;
            lnkShowNewLicenseInfo.Enabled = false;
            fillApplicationInfo();
        }

        private void fillApplicationInfo()
        {
            lblFees.Text = ApplicationType.get((byte)enApplicationType.NewInternationalLicense).Fees.ToString("0.00");
            lblExpirationDate.Text = DateTime.UtcNow.AddYears(LicenseClass.get((byte)enLicenseClass.class3).DefaultValidityLength).ToShortDateString();
            lblCreatedBy.Text = LoggedUser.User.UserName;
        }

        //////////////////////////// Events ////////////////////////////////////
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int licenseId = obj;

            if (License.get(licenseId).LicenseClassId != (byte)enLicenseClass.class3)
            {
                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InternationalLicense.getActiveLicenseIdByDriverId(ctrlDriverLicenseInfoWithFilter1.SelectedLicense.DriverId))
            {
                MessageBox.Show("Person already has an active international license for this Local driving license", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnIssue.Enabled = true;
        }

        private void lnkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowInternationalLicenseInfo frmShowInternationalLicenseInfo = new(ctrlDriverLicenseInfoWithFilter1.InsertedInternationalLicenseId);
            frmShowInternationalLicenseInfo.ShowDialog();
        }

        ///////////////////////////////////////////////////////////////////////
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            InternationalLicensesDto internationalLicensesDto = ctrlDriverLicenseInfoWithFilter1.makeLicenseInternational();

            if (internationalLicensesDto is not null)
            {
                lblILApplicationId.Text = ctrlDriverLicenseInfoWithFilter1.InsertedNewApplicationId.ToString();
                lblILLicenseId.Text = ctrlDriverLicenseInfoWithFilter1.InsertedInternationalLicenseId.ToString();
                MessageBox.Show("International License Issued Successfully with ID=" + ctrlDriverLicenseInfoWithFilter1.InsertedInternationalLicenseId, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssue.Enabled = false;
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                lnkShowNewLicenseInfo.Enabled = true;
            }
            else
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}