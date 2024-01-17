using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;

namespace DVLD_Buisness
{
    public class LicenseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal Fees { get; set; }



        public static LicenseClassDto get(int id) => LicenseClassData.get(id);

        public static LicenseClassDto getLicenseClassInfoByClassName(string className) => LicenseClassData.getLicenseClassInfoByClassName(className);

        public static DataTable get() => LicenseClassData.get();

        public static int getMinimumAllowedAgeForLicenseClass(int licenseClassId) => LicenseClassData.getMinimumAllowedAgeForLicenseClass(licenseClassId);

    }
}
