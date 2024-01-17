using DVLD.Helpers;
using DVLD.People;
using DVLD.People.Controls;
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
using Application = DVLD_Buisness.Application;

namespace DVLD.SharedUserControls
{
    public partial class CtrlApplicationBasicInfo : UserControl
    {
        Application _application = new();

        public CtrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private string getStatusName(byte statusId)
        {
            switch (statusId)
            {
                case 1:
                    return "New";
                case 2:
                    return "Cancelled";
                case 3:
                    return "Completed";
            }

            return string.Empty;
        }

        private void fillInfo()
        {
            lblApplicationBasicInfoId.Text = _application.Id.ToString();
            lblStatus.Text = getStatusName(_application.Status);
            lblFees.Text = _application.Fees.ToString("0.00");
            lblType.Text = _application.ApplicationType.Title;
            lblApplicant.Text = $"{_application.Person.FirstName} {_application.Person.SecondName} {_application.Person.LastName}";
            lblDate.Text = _application.Date.ToString();
            lblLastStatusDate.Text = _application.LastStatusDate.ToString();
            lblCreatedBy.Text = User.Get(_application.PersonId, 0).UserName;
        }

        public void loadApplicationBasicInfo(int id)
        {
            _application = MappingProfiles.ApplicationdToDtoApplication(Application.get(id), _application);
            fillInfo();
        }

        private void btnShowPersonInfo_Click(object sender, EventArgs e)
        {
            FrmShowPersonInfo frmShowPersonInfo = new(_application.PersonId, string.Empty);
            frmShowPersonInfo.ShowDialog();
            loadApplicationBasicInfo(_application.Id);
        }
    }
}
