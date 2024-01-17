using DVLD.People;
using DVLD_Buisness;
using DVLD_DataAccess;
using System.Data;

namespace DVLD
{
    public partial class FrmManagePeople : Form
    {
        private static DataTable _dtAllPeople = Person.Get();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "Person Id", "National No.", "First Name", "Second Name", "Last Name", "Gender", "Date Of Birth", "Nationality", "Phone", "Email");
        
        public FrmManagePeople()
        {
            InitializeComponent();
            FillPeople();
            txtFilter.Visible = false;
        }

        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            lblPeopleRecords.Text = dgvPeople.Rows.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person Id";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Last Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Gender";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Date Of Birth";
                dgvPeople.Columns[6].Width = 140;

                dgvPeople.Columns[7].HeaderText = "Nationality";
                dgvPeople.Columns[7].Width = 120;


                dgvPeople.Columns[8].HeaderText = "Phone";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Email";
                dgvPeople.Columns[9].Width = 170;
            }
        }

        private void FillPeople()
        {
            _dtAllPeople = Person.Get();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "Person Id", "National No.", "First Name", "Second Name", "Last Name", "Gender", "Date Of Birth", "Nationality", "Phone", "Email");

            dgvPeople.DataSource = _dtPeople;
            lblPeopleRecords.Text = dgvPeople.Rows.Count.ToString();
        }



        ////////////////////////////// Events ////////////////////////////////

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = int.Parse(dgvPeople.CurrentRow.Cells[1].Value.ToString());

            FrmAddEditPerson frmAddEditPerson = new(personId);
            frmAddEditPerson.ShowDialog();
            FillPeople();
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e) => txtFilter.Visible = true;

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            //Map Selected Filter to real Column name 
            string filterColumn = cbFilter.Text switch
            {
                "Person Id" => "Person Id",
                "National No." => "National No.",
                "First Name" => "First Name",
                "Second Name" => "Second Name",
                "Last Name" => "Last Name",
                "Nationality" => "Nationality",
                "Gender" => "Gender",
                "Phone" => "Phone",
                "Email" => "Email",
                _ => "None",
            };

            if (txtFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblPeopleRecords.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "Person Id")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, txtFilter.Text.Trim());

            lblPeopleRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = int.Parse(dgvPeople.CurrentRow.Cells[0].Value.ToString());

            if (User.IsExists(personId))
            {
                MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string personName = dgvPeople.CurrentRow.Cells[3].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete Person [{personName}]",
                                "Confirm Delete",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Person.Delete(personId);
                FillPeople();
            }
            else
                MessageBox.Show("Person was not deleted because it has data linked to it.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int persinId = (int)dgvPeople.CurrentRow.Cells[0].Value;

            FrmShowPersonInfo frmShowPersonInfo = new(persinId, string.Empty);
            frmShowPersonInfo.ShowDialog();
            FillPeople();
        }

        /////////////////////////////////////////////////////////////////////

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPerson frmAddEditPerson = new();
            frmAddEditPerson.ShowDialog();
            FillPeople();
        }
    }
}