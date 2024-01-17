using Sahred.Dtos;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class DriverData
    {
        public static DriverDto get(int id, int personId = -1)
        {
            DriverDto driverDto = new();
            string query = $"SELECT * FROM Drivers WHERE  id= '{id}'";

            if (personId != -1)
                query = $"SELECT * FROM Drivers WHERE  personId= '{personId}'";

            SqlCommand sqlCommand = CRUD.SharedSqlCommand(query);

            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    driverDto.Id = (int)reader["Id"];
                    driverDto.Date = (DateTime)reader["Date"];
                    driverDto.PersonId = (int)reader["PersonId"];
                    driverDto.CreatedByUserId = (int)reader["CreatedByUserId"];
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

            return driverDto;
        }

        public static DataTable get()
        {
            string query = "select d.Id 'Driver Id', p.Id 'Person Id', p.NationalNumber 'National Number', p.FirstName + ' ' + p.SecondName +' '+p.LastName 'Full Name', d.Date, count(l.IsActive) 'Active Licenses' from Drivers d join People p on d.PersonId = p.Id join Licenses l on l.DriverId = d.Id where l.IsActive = 'True' group by d.Id, p.Id, p.NationalNumber, p.FirstName + ' ' + p.SecondName +' '+p.LastName, d.Date";

            return CRUD.GetUsingDateTable(query);
        }

        public static DataTable getLocalLicensess(int driverId)
        {
            string query = $"SELECT Licenses.Id, ApplicationID, LicenseClasses.Name, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive FROM Licenses JOIN LicenseClasses ON Licenses.LicenseClassId = LicenseClasses.Id where DriverID= {driverId} Order By IsActive Desc, ExpirationDate Desc";

            return CRUD.GetUsingDateTable(query);
        }

        public static DataTable getInternationalLicensess(int driverId)
        {
            string query = $"SELECT Id, ApplicationID, IssuedUsingLocalLicenseID , IssueDate, ExpirationDate, IsActive from InternationalLicenses where DriverID= {driverId} order by ExpirationDate desc;";

            return CRUD.GetUsingDateTable(query);
        }

        public static int post(DriverDto driverDto)
        {
            string query = $"insert into drivers values('{driverDto.Date}',{driverDto.PersonId},{driverDto.CreatedByUserId}) ; SELECT SCOPE_IdENTITY()";
            return CRUD.Create(query);
        }
    }
}