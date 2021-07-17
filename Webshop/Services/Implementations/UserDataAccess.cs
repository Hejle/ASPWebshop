using ASPWebshop.Exceptions;
using ASPWebshop.Pages.Models;
using ASPWebshop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPWebshop.Services.Implementations
{
    public class UserDataAccess : IUserDataAccess
    {

        private Dictionary<Guid, WebshopUser> userDatabase;

        public UserDataAccess()
        {
            userDatabase = new Dictionary<Guid, WebshopUser>();
            //Add default user
            var user = new WebshopUser{
                ID = Guid.NewGuid(),
                EMail = "admin@admin.com",
                Username = "admin",
                Password = "admin"
            };
            userDatabase.Add(user.ID,user);
        }

        public void AddUser(WebshopUser user)
        {
            userDatabase.Add(user.ID, user);
        }

        public WebshopUser GetUser(string username)
        {
            try
            {
                var user = userDatabase.Select(x => x.Value).Where(d => d.Username.Equals(username));
                if(user.Count() > 1) {
                    //Todo: What should we do if there are multiple users with the same username
                    throw new Exception();
                }
                return (WebshopUser)user.First();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw UserException.UserNotFoundException(username);
            }
        }

        public WebshopUser GetUser(Guid ID)
        {
            try
            {
                return userDatabase[ID];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new UserException("Could not find user for id: " + ID.ToString(), e);
            }

        }
    }
}