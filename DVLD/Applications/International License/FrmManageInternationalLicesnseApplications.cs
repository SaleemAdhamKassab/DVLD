using DVLD.Licenses;
using DVLD.People;
using DVLD_Buisness;
using System.Data;

namespace DVLD.Applications.International_License
{
    public partial class FrmManageInternationalLicesnseApplications : Form
    {
        private static DataTable _dtAllInternationalLicenses = InternationalLicense.get();

        private DataTable _dtInternationalLicenses = _dtAllInternationalLicenses.Rows.Count > 0 ? _dtAllInternationalLicenses.DefaultView.ToTable(false, "International License Id", "Application Id", "Driver Id", "License Id", "Issue Date", "Expiration Date", "Is Active") : null;

        public FrmManageInternationalLicesnseApplications()
        {
            InitializeComponent();
            fillInternationalLicenses();
        }

        private void FrmManageInternationalLicesnseApplications_Load(object sender, EventArgs e) => setDgvLocalDrivingLicenseApplication();

        private void fillInternationalLicenses()
        {
            _dtAllInternationalLicenses = InternationalLicense.get();
            _dtInternationalLicenses = _dtAllInternationalLicenses.Rows.Count > 0 ? _dtAllInternationalLicenses.DefaultView.ToTable(false, "International License Id", "Application Id", "Driver Id", "License Id", "Issue Date", "Expiration Date", "Is Active") : null;
            dgvInternationalLicenses.DataSource = _dtInternationalLicenses;
            setDgvLocalDrivingLicenseApplication();
            lblRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void setDgvLocalDrivingLicenseApplication()
        {
            dgvInternationalLicenses.DataSource = _dtInternationalLicenses;
            cbFilter.SelectedIndex = 0;
            lblRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "International License Id";
                dgvInternationalLicenses.Columns[0].Width = 160;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application Id";
                dgvInternationalLicenses.Columns[1].Width = 110;


                dgvInternationalLicenses.Columns[2].HeaderText = "Driver Id";
                dgvInternationalLicenses.Columns[2].Width = 90;

                dgvInternationalLicenses.Columns[3].HeaderText = "License Id";
                dgvInternationalLicenses.Columns[3].Width = 90;


                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 130;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 130;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 90;
            }
        }

        /////////////////////////////////////////////// Events ////////////////////////////////////////

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.Rows.Count == 0)
                return;

            //Map Selected Filter to real Column name 
            string filterColumn = cbFilter.Text switch
            {
                "International License Id" => "International License Id",


                _ => "None",
            };

            if (txtFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtInternationalLicenses.DefaultView.RowFilter = "";
                lblRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "International License Id")
                _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else
                _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, txtFilter.Text.Trim());

            lblRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "International License Id" || cbFilter.Text == "Application Id" || cbFilter.Text == "Driver Id" || cbFilter.Text == "License Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            FrmNewInternationalLicenseApplication frmNewInternationalLicenseApplication = new();
            frmNewInternationalLicenseApplication.ShowDialog();
            fillInternationalLicenses();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int driverId = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            int personId = Driver.get(driverId, -1).PersonId;

            FrmShowPersonInfo frmShowPersonInfo = new(personId, string.Empty);
            frmShowPersonInfo.ShowDialog();
            fillInternationalLicenses();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int internationalLicenseId = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            FrmShowInternationalLicenseInfo frm = new(internationalLicenseId);
            frm.ShowDialog();
            fillInternationalLicenses();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int driverId = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            int personId = Driver.get(driverId).PersonId;
            FrmShowPersonLicenseHistory frm = new(personId);
            frm.ShowDialog();
            fillInternationalLicenses();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
    }
}