using DVLD.Helpers;
using DVLD.Properties;
using DVLD_Buisness;
using System.Data;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Tests
{
    public partial class FrmListTestAppointments : Form
    {

        private LocalDrivingLicesnseApplication _localDrivingLicesnseApplication;

        private static enTestType _testType = enTestType.Vision;


        //private static DataTable _dtAllTestAppointmentsPerType = TestAppointment.getTestAppointments(_ldlaId, (byte)_testType);

        //private DataTable _dtTestAppointmentsPerType = _dtAllTestAppointmentsPerType.Rows.Count > 0 ? _dtAllTestAppointmentsPerType.DefaultView.ToTable(false, "ID", "Date", "Paid Fees", "Is Active") : null;

        private static DataTable _dtAllTestAppointmentsPerType = null;

        private DataTable _dtTestAppointmentsPerType = null;


        public FrmListTestAppointments(int ldaId, enTestType testType)
        {
            InitializeComponent();

            _dtAllTestAppointmentsPerType = TestAppointment.getTestAppointments(ldaId, (byte)testType);
            _dtTestAppointmentsPerType = _dtAllTestAppointmentsPerType.Rows.Count > 0 ? _dtAllTestAppointmentsPerType.DefaultView.ToTable(false, "ID", "Date", "Paid Fees", "Is Active") : null;
            _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(ldaId), _localDrivingLicesnseApplication);
            ctrlDrivingLicenseApplicationInfo1.loadDrivingLicenseApplicationInfo(ldaId);
            _testType = testType;


            switch (testType)
            {
                case enTestType.Vision:
                    pbTestType.Image = Resources.VisionTest;
                    lblTestTypeTitle.Text = "Vision Test Appointments";
                    break;

                case enTestType.Written:
                    pbTestType.Image = Resources.writtenTest;
                    lblTestTypeTitle.Text = "Written Test Appointments";
                    break;

                case enTestType.Street:
                    pbTestType.Image = Resources.driving_test_512;
                    lblTestTypeTitle.Text = "Street Test Appointments";
                    break;
            }
        }

        private void setDgvColumns()
        {
            dgvAppointmentsPerTest.DataSource = _dtTestAppointmentsPerType;
            lblRecords.Text = dgvAppointmentsPerTest.Rows.Count.ToString();
            if (dgvAppointmentsPerTest.Rows.Count > 0)
            {

                dgvAppointmentsPerTest.Columns[0].HeaderText = "ID";
                dgvAppointmentsPerTest.Columns[0].Width = 80;

                dgvAppointmentsPerTest.Columns[1].HeaderText = "Date";
                dgvAppointmentsPerTest.Columns[1].Width = 150;


                dgvAppointmentsPerTest.Columns[2].HeaderText = "Paid Fees";
                dgvAppointmentsPerTest.Columns[2].Width = 120;

                dgvAppointmentsPerTest.Columns[3].HeaderText = "Is Active";
                dgvAppointmentsPerTest.Columns[3].Width = 100;
            }
        }

        private void FrmListTestAppointments_Load(object sender, EventArgs e) => setDgvColumns();

        /////////////////////////////////// Events ///////////////////////////////////////////

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string isActiveTest = dgvAppointmentsPerTest.CurrentRow.Cells[3].Value.ToString();

            if ("No" == isActiveTest)
            {
                MessageBox.Show("You can't retake test for InActive Appointment, Please reschedule a new test Appointment and pay the needed additional fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int testAppointmentId = int.Parse(dgvAppointmentsPerTest.CurrentRow.Cells[0].Value.ToString());

            FrmTakeTest frmTakeTest = new(_localDrivingLicesnseApplication.Id, testAppointmentId, _testType);
            frmTakeTest.ShowDialog();
            fillTestsPerType();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string isActiveTest = dgvAppointmentsPerTest.CurrentRow.Cells[3].Value.ToString();

            if ("No" == isActiveTest)
            {
                MessageBox.Show("You cann't Edit InActive Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int testAppointmentId = int.Parse(dgvAppointmentsPerTest.CurrentRow.Cells[0].Value.ToString());

            FrmScheduleTest frmScheduleTest = new(_localDrivingLicesnseApplication.Id, _testType, testAppointmentId);
            frmScheduleTest.ShowDialog();

            fillTestsPerType();
        }

        ///////////////////////////////////////////////////////////////////////////////////////

        public void fillTestsPerType()
        {
            _dtAllTestAppointmentsPerType = TestAppointment.getTestAppointments(_localDrivingLicesnseApplication.Id, (byte)_testType);
            _dtTestAppointmentsPerType = _dtAllTestAppointmentsPerType.Rows.Count > 0 ? _dtAllTestAppointmentsPerType.DefaultView.ToTable(false, "Id", "Date", "Paid Fees", "Is Active") : null;
            dgvAppointmentsPerTest.DataSource = _dtTestAppointmentsPerType;
            setDgvColumns();
            lblRecords.Text = dgvAppointmentsPerTest.Rows.Count.ToString();
        }

        /////////////////////////////////////////////////////////////////////////////////////
        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            if (_localDrivingLicesnseApplication.isThereAnActiveScheduledTest(_localDrivingLicesnseApplication.Id, (byte)_testType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_localDrivingLicesnseApplication.isPassedTestBefore(_localDrivingLicesnseApplication.Id, (byte)_testType))
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmScheduleTest frmScheduleTest = new(_localDrivingLicesnseApplication.Id, _testType);
            frmScheduleTest.ShowDialog();

            fillTestsPerType();
        }
    }
}