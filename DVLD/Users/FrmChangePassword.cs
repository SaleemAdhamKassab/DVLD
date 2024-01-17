using DVLD.Helpers;
using DVLD_Buisness;
using System.ComponentModel;

namespace DVLD.Users
{
    public partial class FrmChangePassword : Form
    {
        private User _user = new();
        public FrmChangePassword(int userId)
        {
            InitializeComponent();
            _user = MappingProfiles.UserDtoToUser(User.Get(0, userId), _user);
            ctrlUserCard1.loadUserInfo(userId);
        }


        /////////////////////////////// Events ////////////////////////////////

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProviderChangePassword.SetError(txtConfirmPassword, "Passwords do not match!");
                return;
            }
            else
                errorProviderChangePassword.SetError(txtConfirmPassword, null);
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderChangePassword.SetError(txtNewPassword, "This field is required!");
                return;
            }
            else
            {
                errorProviderChangePassword.SetError(txtNewPassword, null);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCurrentPassword.Text != _user.Password)
            {
                MessageBox.Show("Current password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (User.changePassword(_user.Id, txtNewPassword.Text.Trim()))
                MessageBox.Show("Password Updated Successfully", "Success Update passoword", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
