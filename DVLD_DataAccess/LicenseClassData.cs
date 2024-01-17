using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class LicenseClassData
    {
        public static LicenseClassDto get(int id)
        {
            LicenseClassDto licenseClassDto = new();

            string query = $"select * from LicenseClasses where id ={id}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    licenseClassDto.Id = (int)reader["Id"];
                    licenseClassDto.Name = (string)reader["Name"];
                    licenseClassDto.Description = (string)reader["Description"];
                    licenseClassDto.MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    licenseClassDto.DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    licenseClassDto.Fees = (decimal)reader["Fees"];
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

            return licenseClassDto;
        }

        public static DataTable get()
        {
            string query = "select * from LicenseClasses";

            return CRUD.GetUsingDateTable(query);
        }

        public static LicenseClassDto getLicenseClassInfoByClassName(string className)
        {
            string query = $"select * from LicenseClasses where name = '{className}'";

            LicenseClassDto licenseClassDto = new();
            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    licenseClassDto.Id = (int)reader["Id"];
                    licenseClassDto.Name = (string)reader["Name"];
                    licenseClassDto.Description = (string)reader["Description"];
                    licenseClassDto.MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    licenseClassDto.DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    licenseClassDto.Fees = (decimal)reader["Fees"];
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

            return licenseClassDto;
        }

        public static int getMinimumAllowedAgeForLicenseClass(int LicenseClassId)
        {
            string query = $"select MinimumAllowedAge from LicenseClasses where id ={LicenseClassId}";
            return int.Parse(CRUD.getOneValueBasedOnCondition(query, "MinimumAllowedAge").ToString());
        }

    }
}
