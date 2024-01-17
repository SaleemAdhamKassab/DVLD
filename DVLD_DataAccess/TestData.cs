using Sahred.Dtos;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class TestData
    {
        public static TestDto get(int id)
        {
            TestDto testDto = new();

            string query = $"SELECT * FROM Tests WHERE  id= {id}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    testDto.Id = (int)reader["Id"];
                    testDto.Result = (bool)reader["Result"];
                    testDto.Notes = (string)reader["Notes"];
                    testDto.CreatedByUserId = (int)reader["CreatedByUserId"];
                }

                reader.Close(); ;
            }
            catch (Exception e)
            {
                throw new Exception($"Error: {e.Message}");
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return testDto;
        }

        public static byte passedTest(int ldlaId)
        {
            string qyery = $"select count(*) passedTests from TestAppointments ta  join Tests t on t.TestAppointmentId = ta.Id where ta.LocalDrivingLicenseApplicationId = {ldlaId} and t.Result='True';";
            return byte.Parse(CRUD.getOneValueBasedOnCondition(qyery, "passedTests").ToString());
        }

        public static int getLastFailedId(int ldlaId, byte testTypeId)
        {
            string query = $"select  max(t.id) lastFailedTestId from TestAppointments ta join tests t on t.TestAppointmentId = ta.Id where ta.LocalDrivingLicenseApplicationId = {ldlaId} and  ta.TestTypeId ={testTypeId} and  t.Result = 'False';",
            id = CRUD.getOneValueBasedOnCondition(query, "lastFailedTestId").ToString();

            return string.IsNullOrEmpty(id) ? 0 : int.Parse(id.ToString());
        }

        public static int post(TestDto testDto, int ldlaId = -1)
        {
            string query = $"insert into Tests values ('{testDto.Result}', '{testDto.Notes}',{testDto.TestAppointmentId},{testDto.CreatedByUserId}); SELECT SCOPE_IdENTITY();";
            TestAppointmentData.lockTestAppointment(testDto.TestAppointmentId);

            if (ldlaId != -1)
            {

                ApplicationData.updateApplicationStatusUsingLdla(-1, 3);
            }
               

            return CRUD.Create(query);
        }
    }
}
