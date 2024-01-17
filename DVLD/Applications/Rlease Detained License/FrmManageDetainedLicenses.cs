using DVLD.Licenses;
using DVLD.Licenses.Detain_License;
using DVLD.Licenses.Local_Licenses;
using DVLD.People;
using DVLD_Buisness;
using System.Data;

namespace DVLD.Applications.Rlease_Detained_License
{
    public partial class FrmManageDetainedLicenses : Form
    {
        private static DataTable _dtAllDetainedLicenses = DetainedLicense.get();

        private DataTable _dtDetainedLicenses = _dtAllDetainedLicenses.Rows.Count > 0 ? _dtAllDetainedLicenses.DefaultView.ToTable(false, "Detained Id", "License Id", "Detained Date", "Is Relesed", "Fine Fees", "Release Date", "National Number", "Full Name", "Release Application Id") : null;

        public FrmManageDetainedLicenses()
        {
            InitializeComponent();
            fillDetainedLicenses();
            txtFilter.Visible = false;
        }

        private void FrmManageDetainedLicenses_Load(object sender, EventArgs e) => setDgvLocalDrivingLicenseApplication();

        private void setDgvLocalDrivingLicenseApplication()
        {
            dgvManageDetainedLicenses.DataSource = _dtDetainedLicenses;
            cbFilter.SelectedIndex = 0;
            lblRecords.Text = dgvManageDetainedLicenses.Rows.Count.ToString();

            if (dgvManageDetainedLicenses.Rows.Count > 0)
            {
                dgvManageDetainedLicenses.Columns[0].HeaderText = "Detained Id";
                dgvManageDetainedLicenses.Columns[0].Width = 100;

                dgvManageDetainedLicenses.Columns[1].HeaderText = "License Id";
                dgvManageDetainedLicenses.Columns[1].Width = 90;


                dgvManageDetainedLicenses.Columns[2].HeaderText = "Detained Date";
                dgvManageDetainedLicenses.Columns[2].Width = 130;

                dgvManageDetainedLicenses.Columns[3].HeaderText = "Is Relesed";
                dgvManageDetainedLicenses.Columns[3].Width = 90;


                dgvManageDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvManageDetainedLicenses.Columns[4].Width = 100;

                dgvManageDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvManageDetainedLicenses.Columns[5].Width = 130;

                dgvManageDetainedLicenses.Columns[6].HeaderText = "National Number";
                dgvManageDetainedLicenses.Columns[6].Width = 150;

                dgvManageDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvManageDetainedLicenses.Columns[7].Width = 150;

                dgvManageDetainedLicenses.Columns[8].HeaderText = "Release Application Id";
                dgvManageDetainedLicenses.Columns[8].Width = 150;
            }
        }

        private void fillDetainedLicenses()
        {
            _dtAllDetainedLicenses = DetainedLicense.get();
            _dtDetainedLicenses = _dtAllDetainedLicenses.Rows.Count > 0 ? _dtAllDetainedLicenses.DefaultView.ToTable(false, "Detained Id", "License Id", "Detained Date", "Is Relesed", "Fine Fees", "Release Date", "National Number", "Full Name", "Release Application Id") : null;
            dgvManageDetainedLicenses.DataSource = _dtDetainedLicenses;
            setDgvLocalDrivingLicenseApplication();
            lblRecords.Text = dgvManageDetainedLicenses.Rows.Count.ToString();
        }


        /////////////////////////////////////////////// Events ////////////////////////////////////////
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            if (dgvManageDetainedLicenses.Rows.Count== 0)
                return;

            //Map Selected Filter to real Column name 
            string filterColumn = cbFilter.Text switch
            {
                "Detained Id" => "Detained Id",
                "Release Application Id" => "Release Application Id",
                "National Number" => "National Number",
                "Full Name" => "Full Name",
                "Status" => "Status",
                _ => "None",
            };

            if (txtFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                lblRecords.Text = dgvManageDetainedLicenses.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "Detained Id" || filterColumn == "Release Application Id")
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, txtFilter.Text.Trim());

            lblRecords.Text = dgvManageDetainedLicenses.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) => txtFilter.Visible = true;

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Detained Id" || cbFilter.Text == "Release Application Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseId = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;

            FrmReleaseDetainedLicenseApplication frmReleaseDetainedLicenseApplication = new(licenseId);
            frmReleaseDetainedLicenseApplication.ShowDialog();
            fillDetainedLicenses();
        }

        private void cmsManageDetainedLicense_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isReleased = (bool)dgvManageDetainedLicenses.CurrentRow.Cells[3].Value;

            if (isReleased)
                releaseDetainedLicenseToolStripMenuItem.Enabled = false;
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseId = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;
            int personId = License.get(licenseId).ApplicationDto.PersonId;

            FrmShowPersonInfo frmShowPersonInfo = new(personId, "");
            frmShowPersonInfo.ShowDialog();
            fillDetainedLicenses();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseId = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;

            FrmShowLicenseInfo frmShowLicenseInfo = new(licenseId);
            frmShowLicenseInfo.ShowDialog();
            fillDetainedLicenses();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseId = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;
            int personId = License.get(licenseId).ApplicationDto.PersonId;

            FrmShowPersonLicenseHistory frmShowPersonLicenseHistory = new(personId);
            frmShowPersonLicenseHistory.ShowDialog();
            fillDetainedLicenses();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            FrmReleaseDetainedLicenseApplication frmReleaseDetainedLicenseApplication = new();
            frmReleaseDetainedLicenseApplication.ShowDialog();
            fillDetainedLicenses();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            FrmDetainLicenseApplication frmDetainLicenseApplication = new();
            frmDetainLicenseApplication.ShowDialog();
            fillDetainedLicenses();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
    }
}