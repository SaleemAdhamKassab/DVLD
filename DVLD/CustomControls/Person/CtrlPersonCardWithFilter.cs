using DVLD_Buisness;
using System.ComponentModel;

namespace DVLD.People.Controls
{
    public partial class CtrlPersonCardWithFilter : UserControl
    {
        public int PersonId { get { return personCard1.PersonId; } }
        public Person SelectedPerson { get { return personCard1.SelectedPerson; } }


        public CtrlPersonCardWithFilter() => InitializeComponent();

        private void PersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Focus();
        }

        private void _searchPerson()
        {
            if (cbFilter.Text == "Person Id")
                personCard1.LoadPersonInfo(int.Parse(txtFilter.Text));
            else
                personCard1.LoadPersonInfo(-1, txtFilter.Text);
        }


        //////////////////////// Events ////////////////////////
        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void TxtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderPersonCardWithFilter.SetError(txtFilter, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProviderPersonCardWithFilter.SetError(txtFilter, null);
            }
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        ///////////////////////////////////////////////////////

        public void filterFocus() => txtFilter.Focus();

        public void loadPersonInfo(int personId)
        {
            personCard1.LoadPersonInfo(personId, string.Empty);
            txtFilter.Text = personId.ToString();
        }

        public void disableFilterArea()
        {
            cbFilter.Text = "Person Id";
            txtFilter.Text = personCard1.SelectedPerson.Id.ToString();
            gbFilter.Enabled = false;
        }





        private void DataBackWithPersonIdEvent(object sender, int personId)
        {
            // Handle the data received
            cbFilter.SelectedIndex = 1;
            txtFilter.Text = personId.ToString();
            personCard1.LoadPersonInfo(personId);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _searchPerson();
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPerson frmAddEditPerson = new();
            frmAddEditPerson.DataBack += DataBackWithPersonIdEvent; // Subscribe to the event
            frmAddEditPerson.ShowDialog();
        }
    }
}