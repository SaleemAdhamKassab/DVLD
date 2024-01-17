using DVLD.Helpers;
using DVLD_Buisness;
using Sahred.Dtos;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.CustomControls
{
    public partial class CtrlScheduleTest : UserControl
    {
        public CtrlScheduleTest()
        {
            InitializeComponent();
            gbRetakeTest.Enabled = false;
        }

        private LocalDrivingLicesnseApplication _localDrivingLicesnseApplication = new();

        private enTestType _testType;

        private int _testAppointmantId = -1;

        private enFormMode _formMode = enFormMode.Add;

        private decimal _testFees = 0;

        private decimal _retakeTestFees = 0;


        public void loadInfo(int ldla, enTestType testType, int testAppointmentId = -1, int lastFailedTestId = 0)
        {
            _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(ldla), _localDrivingLicesnseApplication);
            ctrlScheduleAndTakeTestSharedControls1.loadInfo(_localDrivingLicesnseApplication, testType, null);
            _testType = testType;
            _testFees = TestType.getTestTypeFees((byte)testType);

            if (-1 != testAppointmentId)
            {
                _testAppointmantId = testAppointmentId;
                _formMode = enFormMode.Update;
            }

            if (lastFailedTestId != 0)
            {
                decimal testFees = TestType.getTestTypeFees((byte)testType);
                _retakeTestFees = ApplicationType.get((byte)enApplicationType.RetakeTest).Fees;

                lblRetakeAppFees.Text = _retakeTestFees.ToString(".00");
                lblTotalFees.Text = (_retakeTestFees + testFees).ToString(".00");

                gbRetakeTest.Enabled = true;
            }
        }

        ///////////////////////////////////////////////////////////////////////////
        private void btnSave_Click(object sender, EventArgs e)
        {
            TestAppointmentDto testAppointmentDto = new()
            {
                Date = ctrlScheduleAndTakeTestSharedControls1.getTestAppointment(),
                PaidFees = _testFees + _retakeTestFees,
                IsLocked = false,
                TestTypeId = (int)_testType,
                LocalDrivingLicenseApplicationId = _localDrivingLicesnseApplication.Id,
                CreatedByUserId = LoggedUser.User.Id
            };

            if (enFormMode.Add == _formMode)
                TestAppointment.post(testAppointmentDto);
            else if (enFormMode.Update == _formMode)
                TestAppointment.put(testAppointmentDto);
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
            ctrlScheduleAndTakeTestSharedControls1.disableTestAppointmentDateInputs();
        }
    }
}