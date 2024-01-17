using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;

namespace DVLD_Buisness
{
    public class InternationalLicense
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }


        public int ApplicationId { get; set; }
        public int DriverId { get; set; }
        public int IssuedUsingLocalLicenseId { get; set; }
        public int CreatedByUserID { get; set; }



        public static DataTable get() => InternationalLicenseData.get();

        public static InternationalLicensesDto get(int id) => InternationalLicenseData.get(id);

        public static bool getActiveLicenseIdByDriverId(int driverId) => InternationalLicenseData.getActiveLicenseIdByDriverId(driverId);

        public static int post(InternationalLicensesDto internationalLicensesDto) => InternationalLicenseData.post(internationalLicensesDto);
    }
}