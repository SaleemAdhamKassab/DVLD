using DVLD.Helpers;
using DVLD_Buisness;
using Sahred.Dtos;
using System.ComponentModel;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.CustomControls.Local_Licenses
{
    public partial class CtrlDriverLicenseInfoWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        public DVLD_Buisness.License SelectedLicense = new();

        public int InsertedLicense { get; private set; } = -1;

        public int InsertedDetainedLicenseId { get; private set; } = -1;

        public int InsertedNewApplicationId { get; set; } = -1;

        public int InsertedInternationalLicenseId { get; set; } = -1;

        private bool _filterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _filterEnabled;
            }
            set
            {
                _filterEnabled = value;
                gbFilter.Enabled = _filterEnabled;
            }
        }

        public CtrlDriverLicenseInfoWithFilter() => InitializeComponent();




        ///////////////////////////////// Events ///////////////////////////////////
        private void txtLicenseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)13)
                btnSearchLicense.PerformClick();
        }

        private void txtLicenseId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseId.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseId, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtLicenseId, null);
            }
        }

        public void txtLicenceIdFocus() => txtLicenseId.Focus();


        ///////////////////////////////////////////////////////////

        public void loadLicenseInfo(int licenseId)
        {
            ctrlDriverLicenseInfo1.loadInfo(licenseId);

            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(licenseId);
        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseId.Focus();
                return;
            }

            SelectedLicense = MappingProfiles.LicenseDtoToLicense(DVLD_Buisness.License.get(int.Parse(txtLicenseId.Text)), SelectedLicense);

            if (SelectedLicense.Id == 0)
            {
                MessageBox.Show($"Invalid Licence Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!SelectedLicense.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadLicenseInfo(SelectedLicense.Id);
        }

        public LicenseDto renewLicense(string notes)
        {
            ApplicationDto applicationDto = new()
            {
                PersonId = SelectedLicense.Application.PersonId,
                Date = DateTime.UtcNow,
                ApplicationTypeId = (byte)enApplicationType.RenewDrivingLicense,
                Status = (byte)enApplicationStatus.Completed,
                LastStatusDate = DateTime.UtcNow,
                Fees = (byte)enApplicationServicesFees.RenewDrivingLicense,
                CreatedByUserId = LoggedUser.User.Id
            };

            int insertedNewApplicationId = DVLD_Buisness.Application.post(applicationDto);

            if (insertedNewApplicationId == -1)
                return null;


            LicenseDto licenseDto = new()
            {
                ApplicationId = insertedNewApplicationId,
                DriverId = SelectedLicense.DriverId,
                LicenseClassId = SelectedLicense.LicenseClassId,
                IssueDate = DateTime.UtcNow,
                ExpirationDate = DateTime.Now.AddYears(SelectedLicense.LicenseClass.DefaultValidityLength),
                Notes = notes,
                PaidFees = SelectedLicense.LicenseClass.Fees,
                IsActive = true,
                IssueReason = (byte)enIssueReason.Renew,
                CreatedByUserId = LoggedUser.User.Id

            };

            int insertedLicense = DVLD_Buisness.License.post(licenseDto);
            InsertedLicense = insertedLicense;

            if (insertedLicense == -1)
                return null;

            DVLD_Buisness.License.deactivateOldLicense(SelectedLicense.Id);

            return licenseDto;
        }

        public LicenseDto replaceLicense(enApplicationType applicationType)
        {
            decimal applicationFees = applicationType == enApplicationType.ReplaceLostDrivingLicense ? 10 : 5;
            enIssueReason issueReson = applicationType == enApplicationType.ReplaceLostDrivingLicense ? enIssueReason.ReplacementForLost : enIssueReason.ReplacementForDamaged;

            ApplicationDto applicationDto = new()
            {
                PersonId = SelectedLicense.Application.PersonId,
                Date = DateTime.UtcNow,
                ApplicationTypeId = (byte)applicationType,
                Status = (byte)enApplicationStatus.Completed,
                LastStatusDate = DateTime.UtcNow,
                Fees = applicationFees,
                CreatedByUserId = LoggedUser.User.Id
            };

            int insertedNewApplicationId = DVLD_Buisness.Application.post(applicationDto);

            if (insertedNewApplicationId == -1)
                return null;

            LicenseDto licenseDto = new()
            {
                ApplicationId = insertedNewApplicationId,
                DriverId = SelectedLicense.DriverId,
                LicenseClassId = SelectedLicense.LicenseClassId,
                IssueDate = DateTime.UtcNow,
                ExpirationDate = DateTime.Now.AddYears(SelectedLicense.LicenseClass.DefaultValidityLength),
                Notes = applicationType == enApplicationType.ReplaceLostDrivingLicense ? "Replacement For Lost Driving License" : "Replacement For Damaged Driving License",
                PaidFees = 0,
                IsActive = true,
                IssueReason = (byte)issueReson,
                CreatedByUserId = LoggedUser.User.Id
            };

            int insertedLicense = DVLD_Buisness.License.post(licenseDto);
            InsertedLicense = insertedLicense;

            if (insertedLicense == -1)
                return null;

            DVLD_Buisness.License.deactivateOldLicense(SelectedLicense.Id);

            return licenseDto;
        }

        public DetainedLicenseDto Detain(decimal fineFees)
        {
            DetainedLicenseDto detainedLicenseDto = new()
            {
                Date = DateTime.UtcNow,
                FineFees = fineFees,
                LicenseId = SelectedLicense.Id,
                CreatedByUserId = LoggedUser.User.Id,
                ApplicationId = SelectedLicense.ApplicationId,
                ReleaseDate = null
            };

            int insertedDetainedLicenseId = DetainedLicense.post(detainedLicenseDto);

            if (insertedDetainedLicenseId == -1)
                return null;

            InsertedDetainedLicenseId = insertedDetainedLicenseId;
            return detainedLicenseDto;
        }

        public bool releaseDetainedLicense(int detainedId)
        {
            ApplicationDto applicationDto = new()
            {
                PersonId = SelectedLicense.Application.PersonId,
                Date = DateTime.UtcNow,
                ApplicationTypeId = (byte)enApplicationType.ReleaseDetainedDrivingLicsense,
                Status = (byte)enApplicationStatus.Completed,
                LastStatusDate = DateTime.UtcNow,
                Fees = ApplicationType.get((byte)enApplicationType.ReleaseDetainedDrivingLicsense).Fees,
                CreatedByUserId = LoggedUser.User.Id
            };

            int insertedNewApplicationId = DVLD_Buisness.Application.post(applicationDto);
            InsertedDetainedLicenseId = insertedNewApplicationId;

            if (insertedNewApplicationId == -1)
                return false;

            if (DetainedLicense.releaseLicense(detainedId, insertedNewApplicationId, LoggedUser.User.Id))
                return true;

            return false;
        }

        public InternationalLicensesDto makeLicenseInternational()
        {
            ApplicationDto applicationDto = new()
            {
                PersonId = SelectedLicense.Application.PersonId,
                Date = DateTime.UtcNow,
                ApplicationTypeId = (byte)enApplicationType.NewInternationalLicense,
                Status = (byte)enApplicationStatus.Completed,
                LastStatusDate = DateTime.UtcNow,
                Fees = ApplicationType.get((byte)enApplicationType.NewInternationalLicense).Fees,
                CreatedByUserId = LoggedUser.User.Id
            };

            int insertedNewApplicationId = DVLD_Buisness.Application.post(applicationDto);
            InsertedNewApplicationId = insertedNewApplicationId;

            if (insertedNewApplicationId == -1)
                return null;

            InternationalLicensesDto internationalLicensesDto = new()
            {
                IssueDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow.AddYears((byte)enInternationalValidityLength.OneYear),
                IsActive = true,
                ApplicationId = insertedNewApplicationId,
                DriverId = SelectedLicense.DriverId,
                IssuedUsingLocalLicenseId = SelectedLicense.Id,
                CreatedByUserID = LoggedUser.User.Id
            };

            int insertedInternationalLicenseId = InternationalLicense.post(internationalLicensesDto);
            if (insertedInternationalLicenseId == -1)
                return null;

            InsertedInternationalLicenseId = insertedInternationalLicenseId;
            return internationalLicensesDto;
        }
    }
}