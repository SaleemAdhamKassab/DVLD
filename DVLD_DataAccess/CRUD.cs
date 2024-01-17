using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    internal class CRUD
    {
        public static SqlCommand SharedSqlCommand(string query) => new SqlCommand()
        {
            Connection = new SqlConnection(DataAccessSettings.ConnectionString),
            CommandType = CommandType.Text,
            CommandText = query
        };

        private static void SharedErrorMessage(string errorMessage) => throw new Exception("Error: " + errorMessage);

        public static int Create(string query)
        {
            int insertedId = -1;

            SqlCommand sqlCommand = SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                object result = sqlCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    insertedId = id;
            }
            catch (Exception ex)
            {
                SharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return insertedId;
        }

        public static bool ExecuteNonQuery(string query)
        {
            SqlCommand sqlCommand = SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                SharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return false;
        }

        public static DataTable GetUsingDateTable(string query)
        {
            DataTable dataTable = new();

            SqlCommand sqlCommand = SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                SharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return dataTable;
        }

        public static int GetId(string query)
        {
            int id = -1;

            SqlCommand sqlCommand = SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                object result = sqlCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int resultId))
                    id = resultId;
            }
            catch (Exception ex)
            {
                SharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return id;
        }

        public static object getOneValueBasedOnCondition(string query, string name)
        {
            object result = "";

            SqlCommand sqlCommand = SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                    result = (object)reader[name];

                reader.Close();
            }
            catch (Exception ex)
            {
                SharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return result;
        }

        public static bool IsExists(string query) => GetId(query) > 0;
    }
}