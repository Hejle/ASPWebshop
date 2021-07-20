using ASPWebshop.Common.Models;
using ASPWebshopDatabase.Models;

namespace ASPWebshopDatabase.Context.UserDatabase
{
    public static class UserMapper
    {
        public static User MapWebshopUserToUser(WebshopUser webshopUser)
        {
            return new User
            {
                EMail = webshopUser.EMail,
                ID = webshopUser.ID,
                Username = webshopUser.Username,
                Password = webshopUser.Password
            };
        }

        public static WebshopUser MapUserToWebshopUser(User user)
        {
            return new WebshopUser
            {
                EMail = user.EMail,
                ID = user.ID,
                Username = user.Username,
                Password = user.Password
            };
        }

    }
}
