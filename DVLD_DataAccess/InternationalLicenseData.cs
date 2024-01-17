using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class InternationalLicenseData
    {
        public static DataTable get()
        {
            string query = "SELECT i.Id 'International License Id', i.ApplicationId 'Application Id', i.DriverId 'Driver Id', i.IssuedUsingLocalLicenseId 'License Id', i.IssueDate 'Issue Date', i.ExpirationDate 'Expiration Date', i.IsActive 'Is Active' from InternationalLicenses i order by IsActive, ExpirationDate desc;";
            return CRUD.GetUsingDateTable(query);
        }

        public static InternationalLicensesDto get(int id)
        {
            InternationalLicensesDto internationalLicensesDto = new();
            string query = $"SELECT * FROM InternationalLicenses WHERE  id= '{id}'";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    internationalLicensesDto.Id = (int)reader["Id"];
                    internationalLicensesDto.IssueDate = (DateTime)reader["IssueDate"];
                    internationalLicensesDto.ExpirationDate = (DateTime)reader["ExpirationDate"];
                    internationalLicensesDto.IsActive = (bool)reader["IsActive"];
                    internationalLicensesDto.ApplicationId = (int)reader["ApplicationId"];
                    internationalLicensesDto.DriverId = (int)reader["DriverId"];
                    internationalLicensesDto.IssuedUsingLocalLicenseId = (int)reader["IssuedUsingLocalLicenseId"];
                    internationalLicensesDto.CreatedByUserID = (int)reader["CreatedByUserID"];
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

            return internationalLicensesDto;
        }

        public static bool getActiveLicenseIdByDriverId(int driverId)
        {
            string query = $"select isFound = 1 from InternationalLicenses i where i.DriverId = {driverId} and i.IsActive ='True';";
            return CRUD.IsExists(query);
        }

        public static int post(InternationalLicensesDto internationalLicensesDto)
        {
            string updateQuery = $"update InternationalLicenses set isActive='False' where id ={internationalLicensesDto.DriverId}";
            CRUD.ExecuteNonQuery(updateQuery);

            string query = $"insert into InternationalLicenses values('{internationalLicensesDto.IssueDate}','{internationalLicensesDto.ExpirationDate}','True',{internationalLicensesDto.ApplicationId},{internationalLicensesDto.DriverId},{internationalLicensesDto.IssuedUsingLocalLicenseId},{internationalLicensesDto.CreatedByUserID}) ; SELECT SCOPE_IdENTITY()";
            return CRUD.Create(query);
        }
    }
}