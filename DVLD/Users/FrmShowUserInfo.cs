namespace DVLD.Users
{
    public partial class FrmShowUserInfo : Form
    {
        public FrmShowUserInfo(int userId)
        {
            InitializeComponent();
            ctrlUserCard1.loadUserInfo(userId);
        }
    }
}