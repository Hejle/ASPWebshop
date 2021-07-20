using ASPWebshop.Common.Models;
using ASPWebshopDatabase.Context.UserDatabase;
using System;
using System.Linq;

namespace ASPWebshopDatabase.Services.Implementations
{
    public class UserDataAccess : IUserDataAccess
    {

        public void AddUser(WebshopUser user)
        {
            using var db = new UserContext();
            db.Add(UserMapper.MapWebshopUserToUser(user));
            db.SaveChanges();
        }

        public WebshopUser GetUser(string username)
        {
            using var db = new UserContext();
            return (from user in db.Users
                    where user.Username.Equals(username)
                    select UserMapper.MapUserToWebshopUser(user))
                    .SingleOrDefault();
        }

        public WebshopUser GetUser(Guid ID)
        {
            using var db = new UserContext();
            return (from user in db.Users
                    where user.ID.Equals(ID)
                    select UserMapper.MapUserToWebshopUser(user))
                    .SingleOrDefault();
        }
    }
}
