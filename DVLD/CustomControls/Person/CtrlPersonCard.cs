using DVLD_Buisness;
using DVLD_DataAccess;
using static Sahred.Helper;

namespace DVLD.People.Controls
{
    public partial class CtrlPersonCard : UserControl
    {
        public Person SelectedPerson { get; private set; }
        public int PersonId { get; private set; }

        public CtrlPersonCard() => InitializeComponent();

        public void LoadPersonInfo(int personId, string nationalNumber = "")
        {
            SelectedPerson = Person.Get(personId, nationalNumber);

            if (SelectedPerson.Id == 0)
            {
                MessageBox.Show($"Invalid Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillPersonCard();
        }

        private void FillPersonCard()
        {
            lblPersonId.Text = SelectedPerson.Id.ToString();
            lblName.Text = $"{SelectedPerson.FirstName} {SelectedPerson.SecondName} {SelectedPerson.LastName}";
            lblNationalNo.Text = SelectedPerson.NationalNumber;
            if (SelectedPerson.Gender == (short)EnGendor.Male)
                lblGendor.Text = EnGendor.Male.ToString();
            else
                lblGendor.Text = EnGendor.Female.ToString();
            if (!string.IsNullOrEmpty(SelectedPerson.Email))
                lblEmail.Text = SelectedPerson.Email;
            lblAddress.Text = SelectedPerson.Address;
            lblDateOfBirth.Text = SelectedPerson.DateOfBirth.ToString();
            lblPhone.Text = SelectedPerson.Phone;
            lblCountry.Text = CountryData.CountryName(SelectedPerson.CountryId);
            pbProfileImage.ImageLocation = SelectedPerson.ImagePath;
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedPerson is not null)
            {
                FrmAddEditPerson frmAddEditPerson = new(SelectedPerson.Id);
                frmAddEditPerson.ShowDialog();
                SelectedPerson = Person.Get(SelectedPerson.Id, string.Empty);
                FillPersonCard();
            }
            else
                MessageBox.Show("Please select a Person", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}