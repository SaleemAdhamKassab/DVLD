using DVLD_Buisness;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Tests
{
    public partial class FrmScheduleTest : Form
    {
        public FrmScheduleTest(int ldlaId, enTestType testType, int testAppointmentId = -1, int retakeTestId = -1)
        {
            InitializeComponent();

            int lastFailedTestId = Test.getLastFailedId(ldlaId, (byte)testType);
            ctrlScheduleTest1.loadInfo(ldlaId, testType, testAppointmentId, lastFailedTestId);
        }
    }
}
