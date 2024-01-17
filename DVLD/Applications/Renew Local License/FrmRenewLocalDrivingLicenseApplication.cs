using DVLD.Helpers;
using DVLD.Licenses.Local_Licenses;
using DVLD_Buisness;
using Sahred.Dtos;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Applications.Renew_Local_License
{
    public partial class FrmRenewLocalDrivingLicenseApplication : Form
    {
        public FrmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.txtLicenceIdFocus();
            btnRenewLicense.Enabled = false;
            lnkShowNewLicenseInfo.Enabled = false;
            fillApplicationNewLicenseInfo();
        }

        private void fillApplicationNewLicenseInfo()
        {
            lblIssueDate.Text = DateTime.UtcNow.ToString();
            lblExpirationDate.Text = "???";
            lblAppFees.Text = ApplicationType.get((byte)enApplicationType.RenewDrivingLicense).Fees.ToString();
            lblCreatedBy.Text = LoggedUser.User.UserName.ToString();
        }



        ///////////////////// Events ////////////////////////////////
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lblOldLicenseId.Text = SelectedLicenseID.ToString();

            if (SelectedLicenseID == -1)
                return;

            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.LicenseClass.DefaultValidityLength;
            lblExpirationDate.Text = DateTime.Now.AddYears(DefaultValidityLength).ToString();
            lblLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.LicenseClass.Fees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblAppFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.Notes;

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicense.ExpirationDate > DateTime.UtcNow)
            {
                MessageBox.Show("Selected License is not yet expired, It will expire on: " + ctrlDriverLicenseInfoWithFilter1.SelectedLicense.ExpirationDate
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
                txtNotes.Enabled = false;
                return;
            }


            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicense.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
                txtNotes.Enabled = false;
                return;
            }

            btnRenewLicense.Enabled = true;
        }

        private void lnkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frmShowLicenseInfo = new(ctrlDriverLicenseInfoWithFilter1.InsertedLicense);
            frmShowLicenseInfo.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////
        private void btnRenewLicense_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            LicenseDto licenseDto = ctrlDriverLicenseInfoWithFilter1.renewLicense(txtNotes.Text);

            if (licenseDto is null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRLAppId.Text = licenseDto.ApplicationId.ToString();

            lblRenewedLicenseId.Text = ctrlDriverLicenseInfoWithFilter1.InsertedLicense.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + ctrlDriverLicenseInfoWithFilter1.InsertedLicense.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenewLicense.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lnkShowNewLicenseInfo.Enabled = true;
        }
    }
}
