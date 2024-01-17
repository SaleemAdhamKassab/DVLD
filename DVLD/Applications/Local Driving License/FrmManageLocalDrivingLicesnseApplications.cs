using DVLD.Licenses.Local_Licenses;
using DVLD.Tests;
using DVLD_Buisness;
using System.Data;
using static DVLD.Helpers.ConstantValues;
using Application = DVLD_Buisness.Application;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class FrmManageLocalDrivingLicesnseApplications : Form
    {
        private static DataTable _dtAllLDLA = LocalDrivingLicesnseApplication.get();

        private DataTable _dtLDLA = _dtAllLDLA.Rows.Count > 0 ? _dtAllLDLA.DefaultView.ToTable(false, "Id", "Driving Class", "National No.", "Full Name", "Application Date", "Passed Tests", "Status") : null;

        public FrmManageLocalDrivingLicesnseApplications()
        {
            InitializeComponent();
            fillLDLA();
            txtFilter.Visible = false;
        }

        private void setDgvLocalDrivingLicenseApplication()
        {
            dgvLocalDrivingLicenseApplication.DataSource = _dtLDLA;
            cbFilter.SelectedIndex = 0;
            lblRecords.Text = dgvLocalDrivingLicenseApplication.Rows.Count.ToString();

            if (dgvLocalDrivingLicenseApplication.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplication.Columns[0].HeaderText = "Id";
                dgvLocalDrivingLicenseApplication.Columns[0].Width = 50;

                dgvLocalDrivingLicenseApplication.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplication.Columns[1].Width = 220;


                dgvLocalDrivingLicenseApplication.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingLicenseApplication.Columns[2].Width = 120;

                dgvLocalDrivingLicenseApplication.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplication.Columns[3].Width = 180;


                dgvLocalDrivingLicenseApplication.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplication.Columns[4].Width = 140;

                dgvLocalDrivingLicenseApplication.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplication.Columns[5].Width = 100;

                dgvLocalDrivingLicenseApplication.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApplication.Columns[6].Width = 80;
            }
        }

        private void FrmManageLocalDrivingLicesnseApplications_Load(object sender, EventArgs e) => setDgvLocalDrivingLicenseApplication();


        private void fillLDLA()
        {
            _dtAllLDLA = LocalDrivingLicesnseApplication.get();
            _dtLDLA = _dtAllLDLA.Rows.Count > 0 ? _dtAllLDLA.DefaultView.ToTable(false, "Id", "Driving Class", "National No.", "Full Name", "Application Date", "Passed Tests", "Status") : null;
            dgvLocalDrivingLicenseApplication.DataSource = _dtLDLA;
            setDgvLocalDrivingLicenseApplication();
            lblRecords.Text = dgvLocalDrivingLicenseApplication.Rows.Count.ToString();
        }

        private void createTestAppointment(int ldlaId, enTestType testType)
        {
            FrmListTestAppointments frmListTestAppointments = new(ldlaId, testType);
            frmListTestAppointments.ShowDialog();
            fillLDLA();
        }

        ////////////////////////////// Events ////////////////////////////////

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) => txtFilter.Visible = true;

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //Map Selected Filter to real Column name 
            string filterColumn = cbFilter.Text switch
            {
                "ID" => "ID",
                "Driving Class" => "Driving Class",
                "National No." => "National No.",
                "Full Name" => "Full Name",
                "Application Date" => "Application Date",
                "Passed Tests" => "Passed Tests",
                "Status" => "Status",
                _ => "None",
            };

            if (txtFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtLDLA.DefaultView.RowFilter = "";
                lblRecords.Text = dgvLocalDrivingLicenseApplication.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "ID")
                _dtLDLA.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else
                _dtLDLA.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, txtFilter.Text.Trim());

            lblRecords.Text = dgvLocalDrivingLicenseApplication.Rows.Count.ToString();
        }

        private void btnAddLDLA_Click(object sender, EventArgs e)
        {
            FrmAddUpdateLocalDrivingLicesnseApplication frmAddUpdateLocalDrivingLicesnseApplication = new();
            frmAddUpdateLocalDrivingLicesnseApplication.ShowDialog();
            fillLDLA();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int applicationId = (int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value;

            FrmLocalDrivingLicenseApplicationInfo frmLocalDrivingLicenseApplicationInfo = new(applicationId);
            frmLocalDrivingLicenseApplicationInfo.ShowDialog();
            fillLDLA();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ldaId = (int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value;

            FrmAddUpdateLocalDrivingLicesnseApplication frmAddUpdateLocalDrivingLicesnseApplication = new(ldaId);
            frmAddUpdateLocalDrivingLicesnseApplication.ShowDialog();
            fillLDLA();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ldlaId = (int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value,
                applicationId = LocalDrivingLicesnseApplication.get(ldlaId).ApplicationId;

            if (Application.updateApplicationStatus(applicationId, (byte)enApplicationStatus.Cancelled))
                MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fillLDLA();
        }


        ///////////
        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e) => createTestAppointment((int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value, enTestType.Vision);

        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e) => createTestAppointment((int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value, enTestType.Written);

        private void sechduleStreetToolStripMenuItem_Click(object sender, EventArgs e) => createTestAppointment((int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value, enTestType.Street);

        /////////

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ldlaId = (int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value;

            FrmIssueDriverLicenseFirstTime frmIssueDriverLicenseFirstTime = new(ldlaId);
            frmIssueDriverLicenseFirstTime.ShowDialog();
            fillLDLA();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ldlaId = (int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[0].Value,
                licenceId = LocalDrivingLicesnseApplication.getLicenseId(ldlaId);


            FrmShowLicenseInfo frmShowLicenseInfo = new(licenceId);
            frmShowLicenseInfo.ShowDialog();
            fillLDLA();
        }

        private void cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int passedTests = (int)dgvLocalDrivingLicenseApplication.CurrentRow.Cells[5].Value;
            string Teststatus = dgvLocalDrivingLicenseApplication.CurrentRow.Cells[6].Value.ToString();

            if (Teststatus == enApplicationStatus.Completed.ToString())
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;

            if (Teststatus == enApplicationStatus.Cancelled.ToString() || Teststatus == enApplicationStatus.Completed.ToString())
            {
                cancelApplicationToolStripMenuItem.Enabled = false;
                sechduleTestsToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                return;
            }
            else
            {
                cancelApplicationToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }




            if (passedTests == 3)
            {
                sechduleTestsToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                return;
            }

            if (passedTests == 0)
            {
                sechduleVisionTestToolStripMenuItem.Enabled = true;
                sechduleWrittenTestToolStripMenuItem.Enabled = false;
                sechduleStreetToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                return;
            }

            if (passedTests == 1)
            {
                sechduleVisionTestToolStripMenuItem.Enabled = false;
                sechduleWrittenTestToolStripMenuItem.Enabled = true;
                sechduleStreetToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                return;
            }

            if (passedTests == 2)
            {
                sechduleVisionTestToolStripMenuItem.Enabled = false;
                sechduleWrittenTestToolStripMenuItem.Enabled = false;
                sechduleStreetToolStripMenuItem.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
            }
        }
    }
}