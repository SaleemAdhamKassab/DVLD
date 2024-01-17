using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class PersonData
    {
        public static PersonDto Get(int id, string nationalNo)
        {
            string query;

            if (id > 0)
                query = $"SELECT * FROM PEOPLE WHERE Id = {id}";
            else if (!string.IsNullOrEmpty(nationalNo))
                query = $"SELECT * FROM PEOPLE WHERE  NationalNumber= '{nationalNo}'";
            else
                throw new Exception("Invalid Get Person (id and nationalNo are null)");

            PersonDto personDto = new();
            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    personDto.Id = (int)reader["Id"];
                    personDto.NationalNumber = (string)reader["NationalNumber"];
                    personDto.FirstName = (string)reader["FirstName"];
                    personDto.SecondName = (string)reader["SecondName"];
                    personDto.LastName = (string)reader["LastName"];
                    personDto.DateOfBirth = (DateTime)reader["DateOfBirth"];
                    personDto.Gender = (byte)reader["Gender"];
                    personDto.Address = (string)reader["Address"];
                    personDto.Phone = (string)reader["Phone"];
                    personDto.ImagePath = (string)reader["ImagePath"];
                    personDto.CountryId = (int)reader["CountryId"];

                    if (!string.IsNullOrEmpty((string)reader["Email"]))
                        personDto.Email = (string)reader["Email"];
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

            return personDto;
        }

        public static DataTable Get()
        {
            string query = "SELECT p.Id 'Person Id', p. NationalNumber 'National No.' , p.FirstName 'First Name', p.SecondName 'Second Name' ,p.LastName 'Last Name', case when p.Gender =0 then 'Male' when p.Gender =1 then 'Female' else 'Invalid Gender' end as 'Gender', p.DateOfBirth 'Date Of Birth', c.Name 'Nationality', p.Phone, p.Email FROM PEOPLE p join Countries c on p.CountryId = c.Id ORDER BY 1";

            return CRUD.GetUsingDateTable(query);
        }

        public static bool IsNationalNumberExists(string nationalNumber)
        {
            string query = $"SELECT Id FROM PEOPLE WHERE NationalNumber ='{nationalNumber}'";

            return CRUD.IsExists(query);
        }

        public static int Post(PersonDto personDto)
        {
            string query = "INSERT INTO PEOPLE (NationalNumber, FirstName, SecondName, LastName, DateOfBirth, Gender, Address, Phone, Email, ImagePath, CountryId)" +
                $"VALUES ('{personDto.NationalNumber}', '{personDto.FirstName}', '{personDto.SecondName}', '{personDto.LastName}', '{personDto.DateOfBirth}', {personDto.Gender}, '{personDto.Address}', '{personDto.Phone}', '{personDto.Email}', '{personDto.ImagePath}', {personDto.CountryId}); SELECT SCOPE_IdENTITY()";

            return CRUD.Create(query);
        }

        public static bool Put(int personId, PersonDto personDto)
        {

            if (personId == 0 || personDto is null)
                throw new ArgumentNullException("Person Id or Person are null!!");

            string query = $"UPDATE PEOPLE SET  NationalNumber ='{personDto.NationalNumber}', FirstName='{personDto.FirstName}', SecondName='{personDto.SecondName}', LastName = '{personDto.LastName}', DateOfBirth='{personDto.DateOfBirth}', Gender={personDto.Gender}, Address='{personDto.Address}', Phone='{personDto.Phone}', Email ='{personDto.Email}', ImagePath= '{personDto.ImagePath}', CountryId ={personDto.CountryId} WHERE Id ={personId}";

            return CRUD.ExecuteNonQuery(query);
        }

        public static bool Delete(int id)
        {
            string query = $"DELETE FROM PEOPLE WHERE Id = {id}";

            return CRUD.ExecuteNonQuery(query);
        }
    }
}