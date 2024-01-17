using DVLD_DataAccess;
using Sahred.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class License
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }


        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int LicenseClassId { get; set; }
        public LicenseClass LicenseClass { get; set; }

        public int CreatedByUserId { get; set; }
        public User User { get; set; }



        public static LicenseDto get(int id) => LicenseData.get(id);

        public static bool isLicenseExistByPersonID(int LicenseClassId, int personId) => LicenseData.isLicenseExistByPersonID(LicenseClassId, personId);

        public static bool deactivateOldLicense(int licenseId) => LicenseData.deactivateLicense(licenseId);

        public static int post(LicenseDto licenseDto) => LicenseData.post(licenseDto);
    }
}