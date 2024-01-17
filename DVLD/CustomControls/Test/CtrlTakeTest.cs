using DVLD.Helpers;
using DVLD.Tests;
using DVLD_Buisness;
using Sahred.Dtos;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.CustomControls.Test
{
    public partial class CtrlTakeTest : UserControl
    {
        public CtrlTakeTest() => InitializeComponent();

        private LocalDrivingLicesnseApplication _localDrivingLicesnseApplication = new();

        private TestAppointment _testAppointment = new();

        private DVLD_Buisness.Test _test = new();

        private enFormMode _formMode = enFormMode.Update;

        private enTestType _testType;

        public TestDto getTestDto() => new()
        {
            Result = rbPass.Checked,
            Notes = txtNotes.Text,
            TestAppointmentId = _testAppointment.Id,
            CreatedByUserId = LoggedUser.User.Id
        };

        public void disableResultGb() => gpResult.Enabled = false;

        public void loadInfo(int ldla, int testAppointmentId, enTestType testType)
        {
            _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(ldla), _localDrivingLicesnseApplication);
            _testAppointment = MappingProfiles.TestAppointmentDtoToTestAppointment(TestAppointment.get(testAppointmentId), _testAppointment);
            ctrlScheduleAndTakeTestSharedControls1.loadInfo(_localDrivingLicesnseApplication, testType, _testAppointment);
            _testType = testType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            int insetedTestId = DVLD_Buisness.Test.post(getTestDto());

            if (insetedTestId != -1)
            {
                _test = MappingProfiles.TestDtoToTest(DVLD_Buisness.Test.get(insetedTestId), _test);
                lblTestId.Text = insetedTestId.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableResultGb();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}