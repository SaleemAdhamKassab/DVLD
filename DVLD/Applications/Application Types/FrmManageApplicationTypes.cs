using DVLD.Users;
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

namespace DVLD.Applications.Application_Types
{
    public partial class FrmManageApplicationTypes : Form
    {
        private static DataTable _dtAllApplicationTypes = ApplicationType.get();
        private DataTable _dtApplicationTypes = _dtAllApplicationTypes.DefaultView.ToTable(false, "Id", "Title", "Fees");

        public FrmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void FrmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;
            lblApplicationTypeRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
            if (dgvApplicationTypes.Rows.Count > 0)
            {

                dgvApplicationTypes.Columns[0].HeaderText = "Id";
                dgvApplicationTypes.Columns[0].Width = 50;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 300;


                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 50;
            }

            fillApplicationTypes();
        }

        private void fillApplicationTypes()
        {
            _dtAllApplicationTypes = ApplicationType.get();
            _dtAllApplicationTypes = _dtAllApplicationTypes.DefaultView.ToTable(false, "Id", "Title", "Fees");

            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;
            lblApplicationTypeRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte applicationTypeId = (byte)dgvApplicationTypes.CurrentRow.Cells[0].Value;
            FrmEditApplicationType frmEditApplicationType = new(applicationTypeId);
            frmEditApplicationType.ShowDialog();
            fillApplicationTypes();
        }
    }
}
