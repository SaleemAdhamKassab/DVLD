using DVLD.Helpers;
using DVLD_Buisness;

namespace DVLD.Users.Controls
{
    public partial class CtrlUserCard : UserControl
    {
        public User SelectedUser = new();
        public CtrlUserCard() => InitializeComponent();

        private void mappingUserInfo()
        {
            lblUserId.Text = SelectedUser.Id.ToString();
            lblUserName.Text = SelectedUser.UserName;
            lblIsActive.Text = SelectedUser.IsActive.ToString();
        }

        public void loadUserInfo(int userId)
        {
            SelectedUser = MappingProfiles.UserDtoToUser(User.Get(0,userId), SelectedUser);
            ctrlPersonCard1.LoadPersonInfo(SelectedUser.Person.Id);
            mappingUserInfo();
        }
    }
}