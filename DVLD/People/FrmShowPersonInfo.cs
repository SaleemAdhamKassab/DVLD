namespace DVLD.People
{
    public partial class FrmShowPersonInfo : Form
    {
        public FrmShowPersonInfo(int personId, string nationalNumber)
        {
            InitializeComponent();
            personCard1.LoadPersonInfo(personId, nationalNumber);
        }
    }
}