using DVLD.Helpers;
using DVLD_Buisness;
using static DVLD.Helpers.ConstantValues;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class CtrlDrivingLicenseApplicationInfo : UserControl
    {
        private LocalDrivingLicesnseApplication _localDrivingLicesnseApplication = new();
        public CtrlDrivingLicenseApplicationInfo() => InitializeComponent();


        private void fillInfo()
        {
            lblDlAppId.Text = _localDrivingLicesnseApplication.Id.ToString();
            lblAppliedForLicense.Text = _localDrivingLicesnseApplication.LicenseClass.Name;
            ctrlApplicationBasicInfo1.loadApplicationBasicInfo(_localDrivingLicesnseApplication.ApplicationId);
            lblPassedTests.Text = $"{Test.passedTest(_localDrivingLicesnseApplication.Id)} /3";
        }

        public void loadDrivingLicenseApplicationInfo(int ldlaId)
        {
            _localDrivingLicesnseApplication = MappingProfiles.LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplication.get(ldlaId), _localDrivingLicesnseApplication);
            fillInfo();
        }
    }
}
