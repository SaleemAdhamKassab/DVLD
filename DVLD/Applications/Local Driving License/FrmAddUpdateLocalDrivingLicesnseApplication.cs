using DVLD.Helpers;
using DVLD_Buisness;
using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class FrmAddUpdateLocalDrivingLicesnseApplication : Form
    {
        private LocalDrivingLicesnseApplication _localDrivingLicesnseApplication = new();

        private enFormMode _formMode = enFormMode.Add;

        public FrmAddUpdateLocalDrivingLicesnseApplication() => InitializeComponent();

        public FrmAddUpdateLocalDrivingLicesnseApplication(int ldaId)
        {
            InitializeComponent();
            _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(ldaId), _localDrivingLicesnseApplication);
            enableUpdateMode();
        }

        private void enableUpdateMode()
        {
            tabPageApplicationInfoStatus(true);
            _formMode = enFormMode.Update;
            Text = "Update Local Driving License Application";
            ctrlPersonCardWithFilter1.loadPersonInfo(_localDrivingLicesnseApplication.Person.Id);
            ctrlPersonCardWithFilter1.disableFilterArea();
            cbLicenseClass.Text = _localDrivingLicesnseApplication.LicenseClass.Name;
            lblLocalDrivingLicebseApplicationId.Text = _localDrivingLicesnseApplication.ApplicationId.ToString();
            lblLocalDrivingLicebseApplicationId.Text = _localDrivingLicesnseApplication.Id.ToString();
        }

        private void FrmAddUpdateLocalDrivingLicesnseApplication_Load(object sender, EventArgs e)
        {
            _fillLicensesClass();
            lblApplicationFees.Text = ApplicationType.get((int)enApplicationType.NewDrivingLicense).Fees.ToString(".00");
            tabPageApplicationInfoStatus(false);
        }

        private void _fillLicensesClass()
        {
            DataTable licensesClass = LicenseClass.get();

            foreach (DataRow LicenseClass in licensesClass.Rows)
                cbLicenseClass.Items.Add(LicenseClass["Name"]);
        }

        private void tabPageApplicationInfoStatus(bool status) => tabControl.TabPages["tabPageApplicationInfo"].Enabled = status;

        ////////////////////////////// Events////////////////////////////////

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.SelectedPerson is null)
            {
                MessageBox.Show("Please select a Person", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabPageApplicationInfoStatus(true);
            tabControl.SelectTab("tabPageApplicationInfo");

        }

        //private void FrmAddUpdateLocalDrivingLicesnseApplication_Activated(object sender, EventArgs e) => ctrlPersonCardWithFilter1.filterFocus();

        //////////////////////////////////////////////////////////////////////

        private void btnSave_Click(object sender, EventArgs e)
        {
            int licenseClassId = LicenseClass.getLicenseClassInfoByClassName(cbLicenseClass.Text).Id;
            int licenseClassMinimumAllowedAge = LicenseClass.getMinimumAllowedAgeForLicenseClass(licenseClassId);
            int personAge = (int)(DateTime.Now - ctrlPersonCardWithFilter1.SelectedPerson.DateOfBirth).TotalDays / 365;

            if (personAge < licenseClassMinimumAllowedAge)
            {
                MessageBox.Show($"Not Allowed Age, Minimum Allowed Age for [{cbLicenseClass.Text}] is: {licenseClassMinimumAllowedAge} years", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }

            int activeApplicationID = DVLD_Buisness.Application.getActiveApplicationIDForLicenseClass(ctrlPersonCardWithFilter1.SelectedPerson.Id, (int)ConstantValues.enApplicationType.NewDrivingLicense, licenseClassId);

            if (activeApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + activeApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }

            if (License.isLicenseExistByPersonID(ctrlPersonCardWithFilter1.SelectedPerson.Id, licenseClassId))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationDto applicationDto = new()
            {
                Status = 1,
                LastStatusDate = DateTime.Now,
                Fees = (int)enApplicationServicesFees.NewLocalDrivingLicenseService,
                PersonId = ctrlPersonCardWithFilter1.SelectedPerson.Id,
                CreatedByUserId = LoggedUser.User.Id,
                ApplicationTypeId = (int)enApplicationType.NewDrivingLicense,
            };


            if (_formMode == enFormMode.Add)
            {
                int insertedApplicationId = DVLD_Buisness.Application.post(applicationDto);
                LocalDrivingLicesnseApplication.post(insertedApplicationId, licenseClassId);
                _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(insertedApplicationId, true), _localDrivingLicesnseApplication);
            }
            else
            {
                LocalDrivingLicesnseApplication.put(_localDrivingLicesnseApplication.ApplicationId, licenseClassId);
                _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(_localDrivingLicesnseApplication.ApplicationId, true), _localDrivingLicesnseApplication);
            }

            lblLocalDrivingLicebseApplicationId.Text = _localDrivingLicesnseApplication.Application.Id.ToString();
            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}