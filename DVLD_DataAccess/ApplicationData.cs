using Sahred.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class ApplicationData
    {
        public static ApplicationDto get(int id)
        {
            ApplicationDto applicationDto = new();

            string query = $"select * from applications where id ={id}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    applicationDto.Id = (int)reader["Id"];
                    applicationDto.Date = (DateTime)reader["Date"];
                    applicationDto.Status = (byte)reader["Status"];
                    applicationDto.LastStatusDate = (DateTime)reader["LastStatusDate"];
                    applicationDto.Fees = (decimal)reader["Fees"];

                    applicationDto.PersonId = (int)reader["PersonId"];
                    applicationDto.PersonDto = PersonData.Get(applicationDto.PersonId, string.Empty);

                    applicationDto.CreatedByUserId = (int)reader["CreatedByUserId"];
                    applicationDto.UserDto = UserData.Get(applicationDto.PersonId);

                    applicationDto.ApplicationTypeId = (byte)reader["ApplicationTypeId"];
                    applicationDto.ApplicationTypeDto = ApplicationTypeData.get(applicationDto.ApplicationTypeId);
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

            return applicationDto;
        }

        public static int getActiveApplicationIDForLicenseClass(int personId, int applicationTypeId, int licenseClassID)
        {
            string query = $"select ActiveApplicationID=a.Id from Applications  a INNER JOIN LocalDrivingLicenseApplications l ON a.Id = l.ApplicationId WHERE a.PersonId = {personId} and a.ApplicationTypeId= {applicationTypeId} and l.LicenseClassID = {licenseClassID} and a.Status=1";
            return CRUD.GetId(query);
        }

        public static bool updateApplicationStatusUsingLdla(int ldlaId, byte statusId)
        {
            int applicationId = int.Parse(CRUD.getOneValueBasedOnCondition($"select applicationId from LocalDrivingLicenseApplications where id ={ldlaId}", "applicationId").ToString());

            string query = $"UPDATE Applications SET status ={statusId} where id={applicationId};";

            return CRUD.ExecuteNonQuery(query);
        }

        public static bool updateApplicationStatus(int id, byte statusId)
        {
            string query = $"UPDATE Applications SET status ={statusId} where id={id};";

            return CRUD.ExecuteNonQuery(query);
        }

        public static int post(ApplicationDto applicationDto)
        {
            string query = $"insert into Applications (Status,LastStatusDate,Fees,PersonId ,CreatedByUserId ,ApplicationTypeId) values ({applicationDto.Status} , '{applicationDto.LastStatusDate}', {applicationDto.Fees}, {applicationDto.PersonId}, {applicationDto.CreatedByUserId}, {applicationDto.ApplicationTypeId}); SELECT SCOPE_IdENTITY()";
            return CRUD.Create(query);
        }
    }
}