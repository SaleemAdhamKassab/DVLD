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

namespace DVLD.Applications.Application_Types
{
    public partial class FrmEditApplicationType : Form
    {
        private ApplicationType _applicationType = new();
        public FrmEditApplicationType(byte applicationTypeId)
        {
            InitializeComponent();
            _applicationType = MappingProfiles.ApplicationTypeDtoToApplicationType(ApplicationType.get(applicationTypeId), _applicationType);

            lblApplicationTypeId.Text = _applicationType.Id.ToString();
            txtTitle.Text = _applicationType.Title;
            numericUpDownFees.Value = _applicationType.Fees;
        }

        private ApplicationTypeDto updatedApplicationTypeDto() => new ApplicationTypeDto
        {
            Id = _applicationType.Id,
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
                errorProviderUpdateApplicationType.SetError(Temp, "This field is required!");
                return;
            }
            else
                errorProviderUpdateApplicationType.SetError(Temp, null);
        }

        ///////////////////////////////////////////////////////////////////////

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ApplicationType.put(updatedApplicationTypeDto()))
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
