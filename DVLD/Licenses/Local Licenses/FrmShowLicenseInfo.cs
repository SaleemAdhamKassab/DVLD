namespace DVLD.Licenses.Local_Licenses
{
    public partial class FrmShowLicenseInfo : Form
    {
        public FrmShowLicenseInfo(int licenceId)
        {
            InitializeComponent();
            ctrlDriverLicenseInfo1.loadInfo(licenceId);
        }
    }
}
