using DVLD.Properties;
using DVLD_Buisness;
using Microsoft.VisualBasic;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.CustomControls
{
    public partial class CtrlScheduleAndTakeTestSharedControls : UserControl
    {
        private LocalDrivingLicesnseApplication _localDrivingLicesnseApplication = new();

        private enTestType _testType = enTestType.Vision;

        private TestAppointment _testAppointment = new();

        private enTestMode _testMode;

        public CtrlScheduleAndTakeTestSharedControls() => InitializeComponent();

        private void CtrlScheduleTest_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            DateTime lastTestDate = TestAppointment.getLastTestDate(_localDrivingLicesnseApplication.Id);
            dtpDate.MinDate = _testMode == enTestMode.ScheduleTest ? lastTestDate.AddDays(1) : lastTestDate;

            lblUserMessage.Hide();
        }


        private void fillInfo(enTestMode mode)
        {
            if (mode == enTestMode.ScheduleTest)
                lblTitle.Text = $"Schedule {_testType} Test";
            else
            {
                _testMode = mode;
                lblTitle.Text = $"Take {_testType} Test";
                dtpDate.Value = _testAppointment.Date;
                dtpTime.Value.AddHours(_testAppointment.Date.Hour);
                dtpTime.Value.AddMinutes(_testAppointment.Date.Minute);
                disableTestAppointmentDateInputs();
            }


            lblDLAppId.Text = _localDrivingLicesnseApplication.Id.ToString();
            lblDClass.Text = _localDrivingLicesnseApplication.LicenseClass.Name;
            lblName.Text = $"{_localDrivingLicesnseApplication.Person.FirstName} {_localDrivingLicesnseApplication.Person.SecondName} {_localDrivingLicesnseApplication.Person.LastName}";
            lblTrial.Text = TestAppointment.getTotalTrialsPerTest(_localDrivingLicesnseApplication.Id, (byte)_testType).ToString();
            lblFees.Text = TestType.getTestTypeFees((byte)_testType).ToString("0.00");
        }

        //////////////////////////////////////////////////////////////////////

        public DateTime getTestAppointment() => dtpDate.Value;

        public void disableTestAppointmentDateInputs()
        {
            dtpDate.Enabled = false;
            dtpTime.Enabled = false;
        }

        public void loadInfo(LocalDrivingLicesnseApplication localDrivingLicesnseApplication, enTestType testType, TestAppointment testAppointment)
        {
            _localDrivingLicesnseApplication = localDrivingLicesnseApplication;
            _testType = testType;
            _testAppointment = testAppointment;

            if (_testType == enTestType.Written)
                pbTest.Image = Resources.writtenTest;
            else if (_testType == enTestType.Street)
                pbTest.Image = Resources.streetTest;



            if (testAppointment is null)
                fillInfo(enTestMode.ScheduleTest);
            else
                fillInfo(enTestMode.TakeTest);
        }
    }
}