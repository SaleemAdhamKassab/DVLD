using DVLD.Helpers;
using DVLD_Buisness;
using DVLD_DataAccess;
using Sahred;
using Sahred.Dtos;

namespace DVLD.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            GetStoredCredential();
        }

        private void GetStoredCredential()
        {
            if (new FileInfo(Helper.CookiesFilePath).Length > 0)
            {
                string cookies = File.ReadAllText(Helper.CookiesFilePath);
                int seperatorIndex = cookies.IndexOf(Helper.CookiesFileSeperator);
                txtUserName.Text = cookies[..seperatorIndex];
                txtPassword.Text = cookies[(seperatorIndex + 2)..];
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UserDto userDto = User.Get(0,0,txtUserName.Text, txtPassword.Text);

            if (userDto.UserName is not null)
            {
                User user = new();
                user = MappingProfiles.UserDtoToUser(userDto, user);

                if (!user.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using StreamWriter writer = new(Helper.CookiesFilePath);
                if (chkRememberMe.Checked)
                {
                    writer.Flush();
                    writer.Write($"{user.UserName}, {user.Password}");
                }
                else
                {
                    txtUserName.Clear();
                    txtPassword.Clear();
                    writer.Flush();
                }


                LoggedUser.User = user;
                Main main = new(this);
                Hide();
                main.ShowDialog();
            }
            else
                MessageBox.Show("Invalid Username or Password", "Wrong Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}