using ASPWebshop.Exceptions;
using ASPWebshop.Pages.Models;
using ASPWebshop.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPWebshop.Services.Implementations
{
    public class UserDataAccess : IUserDataAccess
    {

        private readonly Dictionary<Guid, WebshopUser> userDatabase;
        private readonly ILogger<UserDataAccess> _logger;

        /// <summary>
        /// Addes a default TestUser
        /// </summary>
        public UserDataAccess(ILogger<UserDataAccess> logger)
        {
            userDatabase = new Dictionary<Guid, WebshopUser>();
            _logger = logger;
            
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
                return userDatabase.Select(x => x.Value).First(d => d.Username.Equals(username));
            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
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
                _logger.LogInformation(e.Message);
                throw new UserException("Could not find user for id: " + ID.ToString(), e);
            }

        }
    }
}