using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class TestAppointmentData
    {
        public static TestAppointmentDto get(int id)
        {
            TestAppointmentDto testAppointmentDto = new();
            SqlCommand sqlCommand = CRUD.SharedSqlCommand($"select * from TestAppointments where id = {id}");

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    testAppointmentDto.Id = (int)reader["Id"];
                    testAppointmentDto.Date = (DateTime)reader["Date"];
                    testAppointmentDto.PaidFees = (decimal)reader["PaidFees"];
                    testAppointmentDto.IsLocked = (bool)reader["IsLocked"];
                    testAppointmentDto.TestTypeId = (int)reader["TestTypeId"];
                    testAppointmentDto.LocalDrivingLicenseApplicationId = (int)reader["LocalDrivingLicenseApplicationId"];
                    testAppointmentDto.CreatedByUserId = (int)reader["CreatedByUserId"];
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

            return testAppointmentDto;
        }

        public static DataTable getTestAppointments(int ldlaId, byte testTypeId)
        {
            string query = $"select a.Id 'Id', a.Date 'Date',cast(a.PaidFees as decimal(10,2)) 'Paid Fees', case when a.IsLocked = 'True' then 'No' else 'Yes' end 'Is Active' from TestAppointments a where a.LocalDrivingLicenseApplicationId ={ldlaId} and  a.TestTypeId ={testTypeId} order by a.Date desc";
            return CRUD.GetUsingDateTable(query);
        }

        public static byte getPassedTestsCount(int ldlaId)
        {
            string qyery = $"select count(*) passedTestsCount from TestAppointments t where t.LocalDrivingLicenseApplicationId = {ldlaId} and t.IsLocked =0";
            return byte.Parse(CRUD.getOneValueBasedOnCondition(qyery, "passedTestsCount").ToString());
        }

        public static int getTotalTrialsPerTest(int ldlaId, byte testTypeId)
        {
            string query = $"select  count(*)  totalTrials from TestAppointments t where t.LocalDrivingLicenseApplicationId ={ldlaId} and t.TestTypeId= {testTypeId} and t.IsLocked =0";
            return int.Parse(CRUD.getOneValueBasedOnCondition(query, "totalTrials").ToString());
        }

        public static void lockTestAppointment(int appointmentId)
        {
            string query = $"update TestAppointments  set IsLocked = 1 where Id = {appointmentId}";
            CRUD.ExecuteNonQuery(query);
        }

        public static DateTime getLastTestDate(int ldlaId)
        {
            string query = $"select MAX(t.Date) date from TestAppointments t where t.LocalDrivingLicenseApplicationId = {ldlaId}",
            date = CRUD.getOneValueBasedOnCondition(query, "date").ToString();

            return string.IsNullOrEmpty(date) ? DateTime.UtcNow : DateTime.Parse(date);
        }

        public static int post(TestAppointmentDto testAppointmentDto)
        {
            string query = $"insert into TestAppointments values ('{testAppointmentDto.Date}', {testAppointmentDto.PaidFees},'{testAppointmentDto.IsLocked}',{testAppointmentDto.TestTypeId},{testAppointmentDto.LocalDrivingLicenseApplicationId},{testAppointmentDto.CreatedByUserId}) ; SELECT SCOPE_IdENTITY()";
            return CRUD.Create(query);
        }

        public static bool put(TestAppointmentDto testAppointmentDto)
        {

            if (testAppointmentDto is null)
                throw new ArgumentNullException("testAppointmentDto is null!!");

            string query = $"UPDATE TestAppointments SET  Date ='{testAppointmentDto.Date}' WHERE LocalDrivingLicenseApplicationId ={testAppointmentDto.LocalDrivingLicenseApplicationId} and IsLocked=0";

            return CRUD.ExecuteNonQuery(query);
        }
    }
}