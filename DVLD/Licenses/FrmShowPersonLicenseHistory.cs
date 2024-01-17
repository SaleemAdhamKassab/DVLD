namespace DVLD.Licenses
{
    public partial class FrmShowPersonLicenseHistory : Form
    {
        public FrmShowPersonLicenseHistory(int personId)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(personId);
            ctrlDriverLicenses1.loadInfoByPersonId(personId);
        }
    }
}
