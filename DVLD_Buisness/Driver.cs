using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;

namespace DVLD_Buisness
{
    public class Driver
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }


        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int CreatedByUserId { get; set; }
        public User User { get; set; }



        public static DriverDto get(int id, int personId=-1) => DriverData.get(id, personId);

        public static DataTable get() => DriverData.get();

        public static DataTable getLocalLicensess(int driverId) => DriverData.getLocalLicensess(driverId);

        public static DataTable getInternationalLicensess(int driverId) => DriverData.getInternationalLicensess(driverId);

        public static int post(DriverDto driverDto) => DriverData.post(driverDto);
    }
}
