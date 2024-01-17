using DVLD.Licenses;
using DVLD.People;
using DVLD_Buisness;
using System.Data;

namespace DVLD.Drivers
{
    public partial class FrmManageDrivers : Form
    {
        private static DataTable _dtAllDrivers = Driver.get();
        private DataTable _dtDrivers = _dtAllDrivers.DefaultView.ToTable(false, "Driver Id", "Person Id", "National Number", "Full Name", "Date", "Active Licenses");

        public FrmManageDrivers()
        {
            InitializeComponent();
            fillDrivers();
            txtFilter.Visible = false;
        }

        private void FrmManageDrivers_Load(object sender, EventArgs e) => setDgvColumns();

        private void fillDrivers()
        {
            _dtAllDrivers = Driver.get();
            _dtDrivers = _dtAllDrivers.DefaultView.ToTable(false, "Driver Id", "Person Id", "National Number", "Full Name", "Date", "Active Licenses");

            dgvDrivers.DataSource = _dtDrivers;
            setDgvColumns();
            lblRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void setDgvColumns()
        {
            dgvDrivers.DataSource = _dtDrivers;
            lblRecords.Text = dgvDrivers.Rows.Count.ToString();
            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver Id";
                dgvDrivers.Columns[0].Width = 80;

                dgvDrivers.Columns[1].HeaderText = "Person Id";
                dgvDrivers.Columns[1].Width = 100;


                dgvDrivers.Columns[2].HeaderText = "National Number";
                dgvDrivers.Columns[2].Width = 150;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 180;

                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 160;

                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 110;
            }
        }

        ////////////////////////////////////////////// Events //////////////////////////////
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) => txtFilter.Visible = true;

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Driver Id" || cbFilter.Text == "Person Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbFilter.Text switch
            {
                "Driver Id" => "Driver Id",
                "Person Id" => "Person Id",
                "National Number" => "National Number",
                "Full Name" => "Full Name",
                "Date" => "Date",
                "Active Licenses" => "Active Licenses",
                _ => "None",
            };

            if (txtFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lblRecords.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "Driver Id")
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else if (filterColumn == "Person Id")
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, txtFilter.Text.Trim());

            lblRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = int.Parse(dgvDrivers.CurrentRow.Cells[1].Value.ToString());

            FrmShowPersonInfo frmShowPersonInfo = new(personId, string.Empty);
            frmShowPersonInfo.ShowDialog();
            fillDrivers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = int.Parse(dgvDrivers.CurrentRow.Cells[1].Value.ToString());
            FrmShowPersonLicenseHistory frmShowPersonLicenseHistory = new(personId);
            frmShowPersonLicenseHistory.ShowDialog();
            fillDrivers();
        }
    }
}