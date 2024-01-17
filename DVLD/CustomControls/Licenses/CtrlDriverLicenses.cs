using DVLD.Helpers;
using DVLD.Licenses.Local_Licenses;
using DVLD_Buisness;
using System.Data;

namespace DVLD.CustomControls.Licenses
{
    public partial class CtrlDriverLicenses : UserControl
    {
        private Driver _driver = new();

        private static DataTable _dtDriverLocalLicensesHistory;

        private static DataTable _dtDriverInternationalLicensesHistory;

        public CtrlDriverLicenses() => InitializeComponent();

        private void loadLocalLicenses()
        {
            _dtDriverLocalLicensesHistory = Driver.getLocalLicensess(_driver.Id);

            dgvLocalLicenses.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalHistoryRecords.Text = dgvLocalLicenses.Rows.Count.ToString();

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns[0].Width = 110;

                dgvLocalLicenses.Columns[1].HeaderText = "App.ID";
                dgvLocalLicenses.Columns[1].Width = 110;

                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 270;

                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 170;

                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 170;

                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 110;

            }

        }

        private void loadInternationalLicenseInfo()
        {
            _dtDriverInternationalLicensesHistory = Driver.getInternationalLicensess(_driver.Id);

            dgvInternationalLicenses.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 160;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 130;

                dgvInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[2].Width = 130;

                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 180;

                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 180;

                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 120;

            }
        }

        ////////////////////////////// Events /////////////////////////
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseId = (int)dgvLocalLicenses.CurrentRow.Cells[0].Value;

            FrmShowLicenseInfo frmShowLicenseInfo = new(LicenseId);
            frmShowLicenseInfo.ShowDialog();
            
        }

        ///////////////////////////////////////////////////////////////
        public void loadInfoByPersonId(int personId)
        {
            _driver = MappingProfiles.DriverDtoToDriver(Driver.get(-1,personId), _driver);

            if (_driver is null)
            {
                MessageBox.Show($"There is no driver linked with person Id : {personId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadLocalLicenses();
            loadInternationalLicenseInfo();
        }
    }
}