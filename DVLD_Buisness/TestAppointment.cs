using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;

namespace DVLD_Buisness
{
    public class TestAppointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsLocked { get; set; }


        public int TestTypeId { get; set; }
        public TestType TestType { get; set; }

        public int CreatedByUserId { get; set; }
        public User User { get; set; }

        public int LocalDrivingLicenseApplicationId { get; set; }
        public LocalDrivingLicesnseApplication LocalDrivingLicesnseApplicationDto { get; set; }


        public static TestAppointmentDto get(int id) => TestAppointmentData.get(id);

        public static DataTable getTestAppointments(int ldlaId, byte testTypeId) => TestAppointmentData.getTestAppointments(ldlaId, testTypeId);

        public static int getTotalTrialsPerTest(int ldlaId, byte testTypeId) => TestAppointmentData.getTotalTrialsPerTest(ldlaId, testTypeId);

        public static byte getPassedTestsCount(int ldlaId) => TestAppointmentData.getPassedTestsCount(ldlaId);

        public static DateTime getLastTestDate(int ldlaId) => TestAppointmentData.getLastTestDate(ldlaId);

        public static bool post(TestAppointmentDto testAppointmentDto) => TestAppointmentData.post(testAppointmentDto) != -1;

        public static bool put(TestAppointmentDto testAppointmentDto) => TestAppointmentData.put(testAppointmentDto);

    }
}