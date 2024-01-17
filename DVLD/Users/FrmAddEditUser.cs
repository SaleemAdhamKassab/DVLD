using DVLD.Helpers;
using DVLD_Buisness;
using Sahred.Dtos;
using System.ComponentModel;

namespace DVLD.Users
{
    public partial class FrmAddEditUser : Form
    {
        private User _user = new();

        public FrmAddEditUser() => InitializeComponent();
        public FrmAddEditUser(int personId)
        {
            InitializeComponent();
            _user = MappingProfiles.UserDtoToUser(User.Get(personId, 0), _user);
            personCardWithFilter1.loadPersonInfo(_user.Person.Id);
        }

        private void FrmAddEditUser_Load(object sender, EventArgs e) => tabPageLoginStatus(false);

        private void tabPageLoginStatus(bool status) => tabControlAddUpdateUser.TabPages["tabPageLogin"].Enabled = status;

        private void selectPersonAlarmMessage() => MessageBox.Show("Please select a Person", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void _resetLoginInfoTab()
        {
            lblUserId.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = false;
        }

        private void _fillUserInfo()
        {

            lblUserId.Text = _user.Id.ToString();
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.Password;
            txtConfirmPassword.Text = _user.Password;

            if (_user.IsActive)
                chkIsActive.Checked = true;
            else
                chkIsActive.Checked = false;
        }

        /////////////////////////// Events //////////////////////////////////
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderAddEditUser.SetError(Temp, "This field is required!");
                return;
            }
            else
                errorProviderAddEditUser.SetError(Temp, null);
        }

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProviderAddEditUser.SetError(txtConfirmPassword, "Passwords do not match!");
                return;
            }
            else
                errorProviderAddEditUser.SetError(txtConfirmPassword, null);
        }

        private void tabControlAddNewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            _resetLoginInfoTab();

            if (personCardWithFilter1.SelectedPerson is null)
            {
                selectPersonAlarmMessage();
                return;
            }
            else if (User.IsExists(personCardWithFilter1.SelectedPerson.Id))
            {
                UserDto userDto = User.Get(personCardWithFilter1.SelectedPerson.Id, 0);
                _user = MappingProfiles.UserDtoToUser(userDto, _user);
                _fillUserInfo();
                tabPageLoginStatus(true);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_user.UserName != txtUserName.Text && User.IsUserNameExists(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderAddEditUser.SetError(txtUserName, "Username is already used!");
                return;
            }
            else
                errorProviderAddEditUser.SetError(txtUserName, null);
        }

        ////////////////////////////////////////////////////////////////////

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (personCardWithFilter1.SelectedPerson is null)
            {
                selectPersonAlarmMessage();
                return;
            }

            if (User.IsExists(personCardWithFilter1.SelectedPerson.Id))
                MessageBox.Show($"Selected person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tabPageLoginStatus(true);
                tabControlAddUpdateUser.SelectTab("tabPageLogin");
                txtUserName.Focus();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserDto userdto = new()
            {
                UserName = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                IsActive = chkIsActive.Checked,
                PersonId = personCardWithFilter1.SelectedPerson.Id
            };

            if (_user.Id == 0)
                User.Add(userdto);
            else
                User.Update(userdto);

            _user = MappingProfiles.UserDtoToUser(User.Get(personCardWithFilter1.SelectedPerson.Id, 0), _user);
            lblUserId.Text = _user.Id.ToString();
            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}