using DVLD.Helpers;
using DVLD_Buisness;
using Sahred.Dtos;
using System.ComponentModel;

namespace DVLD.Licenses.Local_Licenses
{
    public partial class FrmIssueDriverLicenseFirstTime : Form
    {
        private LocalDrivingLicesnseApplication _localDrivingLicesnseApplication = new();

        public FrmIssueDriverLicenseFirstTime(int ldlaId)
        {
            InitializeComponent();
            _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(ldlaId), _localDrivingLicesnseApplication);
            ctrlDrivingLicenseApplicationInfo1.loadDrivingLicenseApplicationInfo(ldlaId);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            DriverDto driverDto = new()
            {
                Date = DateTime.UtcNow,
                PersonId = _localDrivingLicesnseApplication.Person.Id,
                CreatedByUserId = LoggedUser.User.Id
            };

            int insertedDriverId = Driver.post(driverDto);

            if (insertedDriverId != -1)
            {
                LicenseDto licenseDto = new()
                {
                    IssueDate = DateTime.UtcNow,
                    ExpirationDate = DateTime.UtcNow.AddYears(_localDrivingLicesnseApplication.LicenseClass.DefaultValidityLength),
                    Notes = txtNotes.Text,
                    PaidFees = _localDrivingLicesnseApplication.LicenseClass.Fees,
                    IsActive = true,
                    IssueReason = 1,
                    ApplicationId = _localDrivingLicesnseApplication.Application.Id,
                    LicenseClassId = _localDrivingLicesnseApplication.LicenseClass.Id,
                    CreatedByUserId = LoggedUser.User.Id,
                    DriverId = insertedDriverId
                };

                int insertedLicenseId = DVLD_Buisness.License.post(licenseDto);

                if (insertedLicenseId != -1)
                    MessageBox.Show("License Issued Successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssue.Enabled = false;
                txtNotes.Enabled = false;
            }
            else
                MessageBox.Show("License Was not Issued ! ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}