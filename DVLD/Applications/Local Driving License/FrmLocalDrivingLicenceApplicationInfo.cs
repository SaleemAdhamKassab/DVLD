namespace DVLD.Applications.Local_Driving_License
{
    public partial class FrmLocalDrivingLicenseApplicationInfo : Form
    {
        public FrmLocalDrivingLicenseApplicationInfo(int id)
        {
            InitializeComponent();
            ctrlDrivingLicenseApplicationInfo1.loadDrivingLicenseApplicationInfo(id);
        }
    }
}
