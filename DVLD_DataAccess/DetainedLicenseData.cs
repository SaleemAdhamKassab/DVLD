using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class DetainedLicenseData
    {
        public static DataTable get()
        {
            string query = "SELECT  dl.Id 'Detained Id', l.Id 'License Id', dl.Date 'Detained Date', dl.IsReleased'Is Relesed', cast(dl.FineFees as decimal(10,2)) 'Fine Fees', dl.ReleaseDate 'Release Date', p.NationalNumber 'National Number', p.FirstName + ' ' + p.SecondName + ' ' + p.LastName 'Full Name', dl.ReleaseApplicationId 'Release Application Id' FROM People p join Drivers d ON p.Id = d.PersonId JOIN Licenses l ON d.Id = l.DriverId RIGHT JOIN DetainedLicenses dl ON l.Id = dl.LicenseID;";
            return CRUD.GetUsingDateTable(query);
        }


        public static DetainedLicenseDto getByLicenseId(int licenseId)
        {
            DetainedLicenseDto detainedLicenseDto = new();
            string query = $"SELECT * FROM DetainedLicenses WHERE  licenseId= {licenseId}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    detainedLicenseDto.Id = (int)reader["Id"];
                    detainedLicenseDto.Date = (DateTime)reader["Date"];
                    detainedLicenseDto.FineFees = (decimal)reader["FineFees"];
                    detainedLicenseDto.IsReleased = (bool)reader["IsReleased"];
                    detainedLicenseDto.CreatedByUserId = (int)reader["CreatedByUserId"];

                    detainedLicenseDto.LicenseId = (int)reader["LicenseId"];

                    if (!string.IsNullOrEmpty(reader["ReleaseDate"].ToString()))
                        detainedLicenseDto.ReleaseDate = (DateTime)reader["ReleaseDate"];

                    if (!string.IsNullOrEmpty(reader["ReleasedByUserId"].ToString()))
                        detainedLicenseDto.ReleasedByUserId = (int)reader["ReleasedByUserId"];

                    if (!string.IsNullOrEmpty(reader["ApplicationId"].ToString()))
                        detainedLicenseDto.ApplicationId = (int)reader["ApplicationId"];
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

            return detainedLicenseDto;
        }

        public static bool isLicenseDetained(int licenseId)
        {
            string query = $"select isFound = 1 from DetainedLicenses d where d.licenseId = {licenseId} and d.isReleased = 0;";

            return CRUD.IsExists(query);
        }

        public static bool releaseLicense(int detainedId, int releasedApplicationId, int releasedByUserId)
        {
            string query = $"UPDATE DetainedLicenses SET IsReleased='True',ReleaseDate='{DateTime.UtcNow}',ReleasedByUserId={releasedByUserId}, ReleaseApplicationId={releasedApplicationId} WHERE  Id={detainedId}";
            return CRUD.ExecuteNonQuery(query);
        }

        public static int post(DetainedLicenseDto detainedLicenseDto)
        {
            string query = $"insert into DetainedLicenses values ('{detainedLicenseDto.Date}',{detainedLicenseDto.FineFees},'{detainedLicenseDto.IsReleased}',NULL,{detainedLicenseDto.LicenseId},{detainedLicenseDto.CreatedByUserId},NULL,{detainedLicenseDto.ApplicationId},NULL); SELECT SCOPE_IdENTITY()";
            return CRUD.Create(query);
        }
    }
}