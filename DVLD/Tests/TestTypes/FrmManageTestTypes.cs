using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class FrmManageTestTypes : Form
    {
        private static DataTable _dtAllTestTypes = TestType.get();
        private DataTable _dtTestTypes = _dtAllTestTypes.DefaultView.ToTable(false, "Id", "Title", "Description", "Fees");

        public FrmManageTestTypes()
        {
            InitializeComponent();
            fillTestTypes();
        }

        private void FrmManageTestTypes_Load(object sender, EventArgs e)
        {
            dgvTestTypes.DataSource = _dtAllTestTypes;
            lblTestTypesRecords.Text = dgvTestTypes.Rows.Count.ToString();
            if (dgvTestTypes.Rows.Count > 0)
            {

                dgvTestTypes.Columns[0].HeaderText = "Id";
                dgvTestTypes.Columns[0].Width = 110;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 120;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 180;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 50;
            }
        }
        private void fillTestTypes()
        {
            _dtAllTestTypes = TestType.get();
            _dtTestTypes = _dtAllTestTypes.DefaultView.ToTable(false, "Id", "Title", "Description", "Fees");

            dgvTestTypes.DataSource = _dtTestTypes;
            lblTestTypesRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testTypeId = (int)dgvTestTypes.CurrentRow.Cells[0].Value;
            FrmEditTestType frmEditTestType = new(testTypeId);
            frmEditTestType.ShowDialog();
            fillTestTypes();
        }
    }
}
