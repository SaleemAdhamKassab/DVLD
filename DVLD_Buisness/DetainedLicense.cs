using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;

namespace DVLD_Buisness
{
    public class DetainedLicense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal FineFees { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }


        public int LicenseId { get; set; }
        public License License { get; set; }

        public int CreatedByUserId { get; set; }
        public User User { get; set; }

        public int? ReleasedByUserId { get; set; }
        public User? ReleasedByUser { get; set; }

        public int? ApplicationId { get; set; }
        public Application? Application { get; set; }


        public static DataTable get() => DetainedLicenseData.get();

        public static DetainedLicenseDto getByLicenseId(int licenseId) => DetainedLicenseData.getByLicenseId(licenseId);

        public static bool isLicenseDetained(int licenseId) => DetainedLicenseData.isLicenseDetained(licenseId);

        public static bool releaseLicense(int detainedId, int releasedApplicationId, int releasedByUserId) => DetainedLicenseData.releaseLicense(detainedId, releasedApplicationId, releasedByUserId);

        public static int post(DetainedLicenseDto detainedLicenseDto) => DetainedLicenseData.post(detainedLicenseDto);
    }
}