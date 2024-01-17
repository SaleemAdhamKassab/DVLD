using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;

namespace DVLD_Buisness
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public static UserDto Get(int personId, int userId, string userName = "", string password = "") => UserData.Get(personId, userId, userName, password);

        public static DataTable Get() => UserData.Get();

        public static bool IsExists(int personId) => UserData.IsExists(personId);

        public static bool IsUserNameExists(string userName) => UserData.IsUserNameExists(userName);

        public static bool changePassword(int userId, string password) => UserData.changePassowrd(userId, password);

        public static bool Add(UserDto userDto) => UserData.Post(userDto) != -1;

        public static bool Update(UserDto userDto) => UserData.Put(userDto);

        public static bool Delete(int id) => UserData.Delete(id);
    }
}