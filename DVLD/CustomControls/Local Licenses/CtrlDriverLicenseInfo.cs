using DVLD.Helpers;
using DVLD_Buisness;

namespace DVLD.CustomControls.Local_Licenses
{
    public partial class CtrlDriverLicenseInfo : UserControl
    {
        private License _license = new();

        public CtrlDriverLicenseInfo() => InitializeComponent();

        private string getIssueReason(byte reasonId)
        {
            switch (reasonId)
            {
                case 1:
                    return "FirstTime";
                case 2:
                    return "Renew";
                case 3:
                    return "Replacement for Damaged";
                case 4:
                    return "Replacement for Lost";
                default:
                    return "invalid reason Id";
            }
        }

        private void fillDriverLicenseInf()
        {
            lblClass.Text = _license.LicenseClass.Name;
            lblDriverId.Text = _license.DriverId.ToString();
            lblLicenseId.Text = _license.Id.ToString();
            lblIsActive.Text = _license.IsActive ? "Yes" : "No";
            txtNotes.Text = string.IsNullOrEmpty(_license.Notes) ? "No Notes" : _license.Notes;
            lblIssueReason.Text = getIssueReason(_license.IssueReason);
            lblIssueDate.Text = _license.IssueDate.ToString();
            lblExpirationDate.Text = _license.ExpirationDate.ToString();
            lblIsDetained.Text = DetainedLicense.isLicenseDetained(_license.Id) ? "Yes" : "No";
        }

        public void loadInfo(int licenceId)
        {
            _license = MappingProfiles.LicenseDtoToLicense(License.get(licenceId), _license);
            ctrlPersonCard1.LoadPersonInfo(_license.Application.Person.Id);
            fillDriverLicenseInf();
        }
    }
}