using DVLD_Buisness;
using DVLD_DataAccess;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using static Sahred.Helper;

namespace DVLD
{
    public partial class FrmAddEditPerson : Form
    {
        private Person _person = new();

        ///////////// Delegate to return Person Id to caller form after add it in database/////////
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonId);
        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        //////////////////////////////////////////////////////////////////////////////////////////


        public FrmAddEditPerson()
        {
            InitializeComponent();
            _formAddMode();
        }

        public FrmAddEditPerson(int personId)
        {
            InitializeComponent();
            _person = Person.Get(personId, string.Empty);
            _person.Mode = EnMode.Update;
            _fillCountriesInComoboBox();
            _fillEditPersonForm();
            _formUpdateMode();
        }


        private void _formAddMode()
        {
            Text = "Add New Person";
            label3.Visible = false;
            lblPersonId.Visible = false;
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            rbMale.Checked = true;
            _fillCountriesInComoboBox();
        }

        private void _formUpdateMode()
        {
            Text = "Edit Person";
            lblTitle.Text = $"Edit {_person.FirstName} Profile";
            lnkSetImage.Text = "Update Image";
            lblPersonId.Text = _person.Id.ToString();
            label3.Text = "Person Id: ";
            label3.Show();
            lblPersonId.Text = _person.Id.ToString();
            lblPersonId.Show();
        }

        private void _fillEditPersonForm()
        {
            txtNationalNumber.Text = _person.NationalNumber;
            txtFirstName.Text = _person.FirstName;
            txtSecondName.Text = _person.SecondName;
            txtLastName.Text = _person.LastName;
            dtpDateOfBirth.Text = _person.DateOfBirth.ToString();
            txtEmail.Text = _person.Email;
            txtPhone.Text = _person.Phone;
            txtAddress.Text = _person.Address;

            cbCountries.Text = Country.CountryName(_person.CountryId);

            if (_person.Gender == (short)EnGendor.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (!string.IsNullOrEmpty(_person.ImagePath))
                pbProfile.ImageLocation = _person.ImagePath;
        }

        private void _mappingPersonInfo()
        {
            _person.CountryId = Country.CountryId(cbCountries.Text);
            _person.NationalNumber = txtNationalNumber.Text.Trim();
            _person.FirstName = txtFirstName.Text.Trim();
            _person.SecondName = txtSecondName.Text.Trim();
            _person.LastName = txtLastName.Text.Trim();
            _person.DateOfBirth = dtpDateOfBirth.Value;
            _person.Email = txtEmail.Text.Trim();
            _person.Phone = txtPhone.Text.Trim();
            _person.Address = txtAddress.Text.Trim();

            if (rbMale.Checked)
                _person.Gender = (short)EnGendor.Male;
            else
                _person.Gender = (short)EnGendor.Female;

            if (pbProfile.ImageLocation != null)
                _person.ImagePath = pbProfile.ImageLocation;
            else
                _person.ImagePath = "";
        }

        private void _fillCountriesInComoboBox()
        {
            DataTable countries = Country.Get();

            foreach (DataRow country in countries.Rows)
                cbCountries.Items.Add(country["Name"]);

            cbCountries.SelectedItem = DefaultCountry;
        }

        private bool _isValidEmailAddress(string email)
        {
            var regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");

            return regex.IsMatch(email);
        }

        private bool _handlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_person.ImagePath != pbProfile.ImageLocation)
            {
                if (_person.ImagePath != null)
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbProfile.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbProfile.ImageLocation.ToString();

                    if (CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbProfile.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }


        /////////////////////////////////// Events /////////////////////////////////

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderAddEditPerson.SetError(Temp, "This field is required!");
                return;
            }
            else
            {
                errorProviderAddEditPerson.SetError(Temp, null);
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !_isValidEmailAddress(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderAddEditPerson.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
                errorProviderAddEditPerson.SetError(txtEmail, null);
        }

        private void TxtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderAddEditPerson.SetError(txtNationalNumber, "This field is required!");
                return;
            }
            else
                errorProviderAddEditPerson.SetError(txtNationalNumber, null);


            if (txtNationalNumber.Text.Trim() != _person.NationalNumber && Person.IsNationalNumberExists(txtNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderAddEditPerson.SetError(txtNationalNumber, "National Number is used for another person!");
            }
            else
                errorProviderAddEditPerson.SetError(txtNationalNumber, null);

        }

        private void LnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setImageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            setImageDialog.FilterIndex = 1;
            setImageDialog.RestoreDirectory = true;

            if (setImageDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = setImageDialog.FileName;
                pbProfile.Load(selectedFilePath);
            }
        }

        ///////////////////////////////////////////////////////////////////////////

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pbProfile.ImageLocation == null)
            {
                MessageBox.Show("Profile Image is Required!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_handlePersonImage())
                return;

            _mappingPersonInfo();

            if (_person.Save)
            {
                _formUpdateMode();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to send data back (_person.Id) to the caller form.
                DataBack?.Invoke(this, _person.Id);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnClose2_Click(object sender, EventArgs e) => Close();
    }
}