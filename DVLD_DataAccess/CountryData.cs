using System.Data;

namespace DVLD_DataAccess
{
    public class CountryData
    {
        public static DataTable Get()
        {
            string query = "SELECT * FROM COUNTRIES";

            return CRUD.GetUsingDateTable(query);
        }

        public static int CountryId(string countryName)
        {
            string query = $"SELECT Id FROM COUNTRIES WHERE NAME = '{countryName.Trim()}'";

            return CRUD.GetId(query);
        }

        public static string CountryName(int countryId)
        {
            string query = $"SELECT NAME FROM COUNTRIES WHERE Id = {countryId}";

            return CRUD.getOneValueBasedOnCondition(query, "NAME").ToString();
        }
    }
}