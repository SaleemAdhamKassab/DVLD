using DVLD_DataAccess;
using Sahred.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class LocalDrivingLicesnseApplication : Application
    {
        public int Id { get; set; }


        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public int LicenseClassId { get; set; }
        public LicenseClass LicenseClass { get; set; }




        public static DataTable get() => LocalDrivingLicesnseApplicationData.get();

        public static LocalDrivingLicesnseApplicationDto get(int id, bool getByApplicationId = false) => LocalDrivingLicesnseApplicationData.get(id, getByApplicationId);

        public bool isThereAnActiveScheduledTest(int ldlaId, byte testTypeId) => LocalDrivingLicesnseApplicationData.isThereAnActiveScheduledTest(ldlaId, testTypeId);

        public bool isPassedTestBefore(int ldlaId, byte testTypeId) => LocalDrivingLicesnseApplicationData.isPassedTestBefore(ldlaId, testTypeId);

        public static int getLicenseId(int ldlaId) => LocalDrivingLicesnseApplicationData.getLicenseId(ldlaId);

        public static bool post(int applicationId, int LicenseClassId) => LocalDrivingLicesnseApplicationData.post(applicationId, LicenseClassId) != -1;

        public static bool put(int applicationId, int LicenseClassId) => LocalDrivingLicesnseApplicationData.put(applicationId, LicenseClassId);
    }
}
