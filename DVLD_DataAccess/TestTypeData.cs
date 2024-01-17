using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class TestTypeData
    {
        public static TestTypeDto get(int id)
        {
            TestTypeDto testTypeDto = new();

            string query = $"SELECT * FROM TestTypes WHERE  id= {id}";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    testTypeDto.Id = (int)reader["Id"];
                    testTypeDto.Title = (string)reader["title"];
                    testTypeDto.Description = (string)reader["Description"];
                    testTypeDto.Fees = (decimal)reader["fees"];
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

            return testTypeDto;
        }

        public static DataTable get()
        {
            string query = "select * from TestTypes";

            return CRUD.GetUsingDateTable(query);
        }

        public static decimal getTestTypeFees(byte testTypeId)
        {
            string query = $"SELECT FEES FROM TestTypes WHERE id = '{testTypeId}'";

            return decimal.Parse(CRUD.getOneValueBasedOnCondition(query, "Fees").ToString());
        }

        public static bool put(TestTypeDto testTypeDto)
        {
            if (testTypeDto is null)
                throw new ArgumentNullException("testTypeDto is null!!");

            string query = $"UPDATE TestTypes SET  title ='{testTypeDto.Title}', fees={testTypeDto.Fees} WHERE id ={testTypeDto.Id}";

            return CRUD.ExecuteNonQuery(query);
        }
    }
}
