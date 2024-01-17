using System.Data;
using System.Data.SqlClient;
using Sahred.Dtos;

namespace DVLD_DataAccess
{
    public class UserData
    {
        public static DataTable Get()
        {
            string query = "select u.Id 'User Id', p.Id 'Person Id', p.FirstName +' '+p.SecondName+' '+p.LastName 'Full Name', u.UserName 'User Name', case when u.IsActive=1 then 'True' else 'False' end 'Is Active' from people p join users u on u.PersonId = p.Id";

            return CRUD.GetUsingDateTable(query);
        }

        public static UserDto Get(int personId, int userId = 0, string userName = "", string password = "")
        {
            UserDto userDto = new();
            SqlCommand sqlCommand = CRUD.SharedSqlCommand($"select * from Users u where u.PersonId={personId} Or u.id= {userId} OR(u.UserName='{userName}' and u.Password='{password}');");

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    userDto.Id = (int)reader["Id"];
                    userDto.UserName = (string)reader["UserName"];
                    userDto.Password = (string)reader["Password"];
                    userDto.IsActive = (bool)reader["IsActive"];
                    userDto.PersonId = (int)reader["PersonId"];
                    userDto.PersonDto = PersonData.Get(userDto.PersonId, string.Empty);
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

            return userDto;

        }

        public static bool IsExists(int personId)
        {
            string query = $"SELECT Id FROM USERS WHERE PersonId ='{personId}'";
            return CRUD.IsExists(query);
        }

        public static bool IsUserNameExists(string userName)
        {
            string query = $"SELECT Id FROM USERS WHERE lower(UserName) ='{userName.ToLower()}'";
            return CRUD.IsExists(query);
        }

        public static bool changePassowrd(int userId, string password)
        {
            if (userId == 0)
                throw new ArgumentNullException("Invalid User Id!!");

            string query = $"UPDATE Users SET  Password='{password}' WHERE Id ={userId}";

            return CRUD.ExecuteNonQuery(query);
        }

        public static int Post(UserDto userDto)
        {
            string query = $"INSERT INTO USERS (UserName, Password, IsActive, PersonId) VALUES ('{userDto.UserName}', '{userDto.Password}', '{userDto.IsActive}', {userDto.PersonId}); SELECT SCOPE_IdENTITY()";

            return CRUD.Create(query);
        }

        public static bool Put(UserDto userDto)
        {

            if (userDto is null)
                throw new ArgumentNullException("User is null!!");

            string query = $"UPDATE Users SET  UserName ='{userDto.UserName}', Password='{userDto.Password}', IsActive='{userDto.IsActive}' WHERE PersonId ={userDto.PersonId}";

            return CRUD.ExecuteNonQuery(query);
        }

        public static bool Delete(int id)
        {
            string query = $"Update Users set IsActive = 'False' where id = {id}";

            return CRUD.ExecuteNonQuery(query);
        }
    }
}