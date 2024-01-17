using DVLD.Helpers;
using DVLD.Licenses.Local_Licenses;
using DVLD_Buisness;
using Sahred.Dtos;

namespace DVLD.Licenses.Detain_License
{
    public partial class FrmDetainLicenseApplication : Form
    {
        public FrmDetainLicenseApplication()
        {
            InitializeComponent();
            lnkShowNewLicenseInfo.Enabled = false;
            lblCreatedBy.Text = LoggedUser.User.UserName;
        }

        private void lnkShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frmShowLicenseInfo = new(ctrlDriverLicenseInfoWithFilter1.SelectedLicense.Id);
            frmShowLicenseInfo.ShowDialog();
        }

        ///////////////////////////////////////////////////////
        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (DetainedLicense.isLicenseDetained(ctrlDriverLicenseInfoWithFilter1.SelectedLicense.Id))
            {
                MessageBox.Show("The selected License has already been detained!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            DetainedLicenseDto detainedLicenseDto = ctrlDriverLicenseInfoWithFilter1.Detain(numericUpDownFineFees.Value);

            if (detainedLicenseDto is null)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainId.Text = ctrlDriverLicenseInfoWithFilter1.InsertedDetainedLicenseId.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + ctrlDriverLicenseInfoWithFilter1.InsertedDetainedLicenseId, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            numericUpDownFineFees.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.Enabled = false;
            lnkShowNewLicenseInfo.Enabled = true;
        }
    }
}