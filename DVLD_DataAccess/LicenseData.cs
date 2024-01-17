using Sahred.Dtos;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class LicenseData
    {
        public static LicenseDto get(int id)
        {
            LicenseDto licenseDto = new();
            string query = $"SELECT * FROM Licenses WHERE  id= {id}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    licenseDto.Id = (int)reader["Id"];
                    licenseDto.IssueDate = (DateTime)reader["IssueDate"];
                    licenseDto.ExpirationDate = (DateTime)reader["ExpirationDate"];
                    licenseDto.Notes = (string)reader["Notes"];
                    licenseDto.PaidFees = (decimal)reader["PaidFees"];
                    licenseDto.IsActive = (bool)reader["IsActive"];
                    licenseDto.IssueReason = (byte)reader["IssueReason"];

                    licenseDto.ApplicationId = (int)reader["ApplicationId"];
                    licenseDto.ApplicationDto = ApplicationData.get(licenseDto.ApplicationId);

                    licenseDto.LicenseClassId = (int)reader["LicenseClassId"];
                    licenseDto.LicenseClassDto = LicenseClassData.get(licenseDto.LicenseClassId);

                    licenseDto.CreatedByUserId = licenseDto.ApplicationDto.CreatedByUserId;
                    licenseDto.UserDto = licenseDto.ApplicationDto.UserDto;

                    licenseDto.DriverId = (int)reader["DriverId"];
                    licenseDto.DriverDto = DriverData.get(licenseDto.DriverId);
                }

                reader.Close(); ;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return licenseDto;
        }

        public static int post(LicenseDto licenseDto)
        {
            string query = $"insert into Licenses values('{licenseDto.IssueDate}','{licenseDto.ExpirationDate}','{licenseDto.Notes}',{licenseDto.PaidFees},'{licenseDto.IsActive}',{licenseDto.IssueReason},{licenseDto.ApplicationId},{licenseDto.LicenseClassId},{licenseDto.CreatedByUserId},{licenseDto.DriverId}); SELECT SCOPE_IdENTITY()";
            ApplicationData.updateApplicationStatus(licenseDto.ApplicationId, 3);
            return CRUD.Create(query);
        }

        public static bool deactivateLicense(int licenseId)
        {
            bool isUpdated = false;

            string query = $"update licenses set isActive=0 where id = {licenseId}";
            CRUD.ExecuteNonQuery(query);
            isUpdated = true;

            return isUpdated;
        }

        public static bool isLicenseExistByPersonID(int LicenseClassId, int personId)
        {
            string query = $"SELECT l.Id FROM Licenses l INNER JOIN Drivers d ON l.Id = d.Id WHERE l.LicenseClassId = {LicenseClassId} AND d.Id = {personId} And IsActive=1;";
            return CRUD.IsExists(query);
        }
    }
}
