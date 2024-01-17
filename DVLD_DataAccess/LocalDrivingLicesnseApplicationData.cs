using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class LocalDrivingLicesnseApplicationData
    {
        public static LocalDrivingLicesnseApplicationDto get(int id, bool getByApplicationId = false)
        {
            LocalDrivingLicesnseApplicationDto localDrivingLicesnseApplicationDto = new();

            string query = $"select * from LocalDrivingLicenseApplications where id ={id}";

            if (getByApplicationId)
                query = $"select * from LocalDrivingLicenseApplications where applicationid ={id}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    localDrivingLicesnseApplicationDto.Id = (int)reader["Id"];
                    localDrivingLicesnseApplicationDto.ApplicationId = (int)reader["ApplicationId"];
                    localDrivingLicesnseApplicationDto.LicenseClassId = (int)reader["LicenseClassId"];
                    localDrivingLicesnseApplicationDto.ApplicationDto = ApplicationData.get(localDrivingLicesnseApplicationDto.ApplicationId);
                    localDrivingLicesnseApplicationDto.LicenseClassDto = LicenseClassData.get(localDrivingLicesnseApplicationDto.LicenseClassId);
                    localDrivingLicesnseApplicationDto.ApplicationTypeDto = ApplicationTypeData.get(localDrivingLicesnseApplicationDto.ApplicationTypeId);
                    localDrivingLicesnseApplicationDto.PersonDto = PersonData.Get(localDrivingLicesnseApplicationDto.ApplicationDto.PersonId, string.Empty);
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

            return localDrivingLicesnseApplicationDto;
        }

        public static DataTable get()
        {
            //string query = "select l.Id, c.Name 'Driving Class',p.NationalNumber 'National No.', p.FirstName +' '+ p.SecondName +' '+p.LastName 'Full Name', a.Date 'Application Date', -1 'NoColl', case  when a.Status=1 then 'New' when a.Status= 2 then 'Cancelled' else 'Completed' end 'Status' from Applications a join LocalDrivingLicenseApplications l on l.ApplicationId = a.Id join LicenseClasses c on l.LicenseClassId = c.Id join People p on a.PersonId=  p.Id;";
            string query =
                "select l.Id, c.Name 'Driving Class',p.NationalNumber 'National No.', p.FirstName +' '+ p.SecondName +' '+p.LastName 'Full Name', a.Date 'Application Date'," +
                "(select count(*) from TestAppointments ta join Tests t on t.TestAppointmentId = ta.Id where ta.LocalDrivingLicenseApplicationId = l.Id and t.Result='True' )'Passed Tests'," +
                "case  when a.Status=1 then 'New' when a.Status= 2 then 'Cancelled' else 'Completed' end 'Status' from Applications a join LocalDrivingLicenseApplications l on l.ApplicationId = a.Id join LicenseClasses c on l.LicenseClassId = c.Id join People p on a.PersonId=  p.Id;";
            return CRUD.GetUsingDateTable(query);
        }

        public static int getLicenseId(int ldlaId)
        {
            string query = $"select ls.Id licenceId from LocalDrivingLicenseApplications l join Applications a on l.ApplicationID = a.Id join Licenses ls on ls.ApplicationId = a.Id where l.Id = {ldlaId};";
            return int.Parse(CRUD.getOneValueBasedOnCondition(query, "licenceId").ToString());
        }

        public static bool isThereAnActiveScheduledTest(int ldlaId, byte testTypeId)
        {
            string query = $"select isFound = 1 from TestAppointments t join LocalDrivingLicenseApplications l on t.localDrivingLicenseApplicationId = l.Id where t.localDrivingLicenseApplicationId = {ldlaId} and t.testTypeId= {testTypeId} and t.islocked = 0 ORDER BY t.id desc";
            return !string.IsNullOrEmpty(CRUD.getOneValueBasedOnCondition(query, "isFound").ToString());
        }

        public static bool isPassedTestBefore(int ldlaId, byte testTypeId)
        {
            string query = $"select isFound =1 from TestAppointments ta join Tests t on t.TestAppointmentId = ta.Id where ta.LocalDrivingLicenseApplicationId = {ldlaId} and ta.TestTypeId={testTypeId} and  t.Result='True'";
            return !string.IsNullOrEmpty(CRUD.getOneValueBasedOnCondition(query, "isFound").ToString());
        }

        public static int post(int applicaitonId, int LicenseId)
        {
            string query = $"insert into LocalDrivingLicenseApplications  values ({applicaitonId},{LicenseId}); SELECT SCOPE_IDENTITY();";
            return CRUD.Create(query);
        }

        public static bool put(int applicationId, int LicenseClassId)
        {

            if (applicationId == 0 || LicenseClassId == 0)
                throw new ArgumentNullException("Application Id or LicenseClass Id are null!!");

            string query = $"UPDATE LocalDrivingLicenseApplications SET  ApplicationID ={applicationId}, LicenseClassId={LicenseClassId} where applicationId = {applicationId}";

            return CRUD.ExecuteNonQuery(query);
        }

        //public static decimal getlicenseClassFees(string licenseClassFees)
        //{
        //    string query = $"SELECT FEES FROM LicenseClasses WHERE Name = '{licenseClassFees}'";

        //    return decimal.Parse(CRUD.getOneValueBasedOnCondition(query, "Fees").ToString());
        //}
    }
}
