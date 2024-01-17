using DVLD.People;
using DVLD_Buisness;
using DVLD_DataAccess;
using System.Data;

namespace DVLD.Users
{
    public partial class FrmManageUsers : Form
    {
        private static DataTable _dtAllUsers = User.Get();
        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "User Id", "Person Id", "Full Name", "User Name", "Is Active");

        public FrmManageUsers()
        {
            InitializeComponent();
            FillUsers();
        }

        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _dtUsers;
            lblUserRecords.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.Columns[0].HeaderText = "User Id";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person Id";
                dgvUsers.Columns[1].Width = 120;


                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 180;

                dgvUsers.Columns[3].HeaderText = "User Name";
                dgvUsers.Columns[3].Width = 140;


                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 120;
            }
        }

        public void FillUsers()
        {
            _dtAllUsers = User.Get();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "User Id", "Person Id", "Full Name", "User Name", "Is Active");

            dgvUsers.DataSource = _dtUsers;
            lblUserRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        ////////////////////////////////// Events /////////////////////////////////
        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e) => txtFilter.Visible = true;

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            //Map Selected Filter to real Column name 
            string filterColumn = cbFilter.Text switch
            {
                "User Id" => "User Id",
                "Person Id" => "Person Id",
                "Full Name" => "Full Name",
                "User Name" => "User Name",
                "Is Active" => "Is Active",
                _ => "None",
            };

            if (txtFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblUserRecords.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "User Id")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else if (filterColumn == "Person Id")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, txtFilter.Text.Trim());

            lblUserRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "User Id" || cbFilter.Text == "Person Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)dgvUsers.CurrentRow.Cells[0].Value;

            FrmShowUserInfo frmShowUserInfo = new(userId);
            frmShowUserInfo.ShowDialog();
            FillUsers();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)dgvUsers.CurrentRow.Cells[0].Value;
            FrmChangePassword frmChangePassword = new(userId);
            frmChangePassword.ShowDialog();
            FillUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = (int)dgvUsers.CurrentRow.Cells[1].Value;
            FrmAddEditUser frmAddEditUser = new(personId);
            frmAddEditUser.ShowDialog();
            FillUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());

            string userName = dgvUsers.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete User [{userName}]",
                                "Confirm Delete",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                User.Delete(userId);
                FillUsers();
                MessageBox.Show($"User {userName} has been disabled successfully.",
                   "confirm",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }           
        }

        //////////////////////////////////////////////////////////////////////////

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddEditUser frmAddEditUser = new();
            frmAddEditUser.ShowDialog();
            FillUsers();
        }
    }
}