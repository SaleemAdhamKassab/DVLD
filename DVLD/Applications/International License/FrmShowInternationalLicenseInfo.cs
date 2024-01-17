using DVLD_Buisness;
using Sahred.Dtos;

namespace DVLD.Applications.International_License
{
    public partial class FrmShowInternationalLicenseInfo : Form
    {

        private InternationalLicensesDto _internationalLicensesDto = new();

        private void fillInternationalLicenseInfo()
        {
            lblInternationalLicenseId.Text = _internationalLicensesDto.Id.ToString();
            lblLicenseId.Text = _internationalLicensesDto.IssuedUsingLocalLicenseId.ToString();
            lblIssueDate.Text = _internationalLicensesDto.IssueDate.ToString();
            lblExpirationDate.Text = _internationalLicensesDto.ExpirationDate.ToString();
        }

        public FrmShowInternationalLicenseInfo(int internationalLicenseId)
        {
            InitializeComponent();
            _internationalLicensesDto = InternationalLicense.get(internationalLicenseId);
            fillInternationalLicenseInfo();
            int personId = Driver.get(_internationalLicensesDto.DriverId,-1).PersonId;

            ctrlPersonCard1.LoadPersonInfo(personId);
        }
    }
}
