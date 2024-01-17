using DVLD_Buisness;
using Sahred;

namespace DVLD.Helpers
{
    internal class LoggedUser
    {
        public static User? User { get; set; }
        public static void Logout() => User = null;
    }
}