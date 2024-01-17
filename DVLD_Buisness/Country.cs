using DVLD_DataAccess;
using System.Data;

namespace DVLD_Buisness
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }




        public static DataTable Get() => CountryData.Get();

        public static int CountryId(string countryName) => CountryData.CountryId(countryName);

        public static string CountryName(int countryId) => CountryData.CountryName(countryId);
    }
}