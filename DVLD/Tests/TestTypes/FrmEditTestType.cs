using DVLD.Helpers;
using DVLD_Buisness;
using Sahred.Dtos;
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
    public partial class FrmEditTestType : Form
    {
        private TestType _testType = new();

        public FrmEditTestType(int testTypeId)
        {
            InitializeComponent();
            _testType = MappingProfiles.TestTypeDtoToTestType(TestType.get(testTypeId), _testType);

            lblApplicationTypeId.Text = _testType.Id.ToString();
            txtTitle.Text = _testType.Title;
            numericUpDownFees.Value = _testType.Fees;
        }


        private TestTypeDto _updatedTestTypeDto() => new TestTypeDto
        {
            Id = _testType.Id,
            Title = txtTitle.Text,
            Fees = numericUpDownFees.Value
        };
        ///////////////////////////// Event ///////////////////////////////////

        private void validateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderEditTestTypes.SetError(Temp, "This field is required!");
                return;
            }
            else
                errorProviderEditTestTypes.SetError(Temp, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TestType.put(_updatedTestTypeDto()))
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        ///////////////////////////////////////////////////////////////////////
    }
}
