using DVLD_DataAccess;
using Sahred.Dtos;

namespace DVLD_Buisness
{
    public class Test
    {
        public int Id { get; set; }
        public bool Result { get; set; }
        public string Notes { get; set; }


        public int TestAppointmentId { get; set; }
        public TestAppointment TestAppointment { get; set; }


        public int CreatedByUserId { get; set; }
        public User User { get; set; }



        public static TestDto get(int id) => TestData.get(id);

        public static byte passedTest(int ldlaId) => TestData.passedTest(ldlaId);

        public static int getLastFailedId(int ldlaId, byte testTypeId) => TestData.getLastFailedId(ldlaId, testTypeId);

        public static int post(TestDto testDto) => TestData.post(testDto);
    }
}