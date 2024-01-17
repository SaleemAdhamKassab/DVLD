using static DVLD.Helpers.ConstantValues;

namespace DVLD.Tests
{
    public partial class FrmTakeTest : Form
    {
        public FrmTakeTest(int ldla, int testAppointmentId, enTestType testType)
        {
            InitializeComponent();
            ctrlTakeTest1.loadInfo(ldla, testAppointmentId, testType);
        }
    }
}