using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class ApplicationTypeData
    {
        public static ApplicationTypeDto get(byte id)
        {
            ApplicationTypeDto applicationTypeDto = new();

            string query = $"SELECT * FROM ApplicationTypes WHERE  id= {id}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    applicationTypeDto.Id = (byte)reader["Id"];
                    applicationTypeDto.Title = (string)reader["title"];
                    applicationTypeDto.Fees = (decimal)reader["fees"];
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

            return applicationTypeDto;
        }

        public static DataTable get()
        {
            string query = "select id, title, CAST(fees AS DECIMAL(5, 2)) fees from ApplicationTypes";

            return CRUD.GetUsingDateTable(query);
        }

        public static bool put(ApplicationTypeDto applicationTypeDto)
        {
            if (applicationTypeDto is null)
                throw new ArgumentNullException("applicationTypeDto is null!!");

            string query = $"UPDATE ApplicationTypes SET  title ='{applicationTypeDto.Title}', fees={applicationTypeDto.Fees} WHERE id ={applicationTypeDto.Id}";

            return CRUD.ExecuteNonQuery(query);
        }
    }
}
