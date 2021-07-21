using ASPWebshop.Common.Models;
using ASPWebshop.Exceptions;
using ASPWebshopDatabase.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPWebshop.Services.Implementations
{
    public class UserMockDataAccess : IUserDataAccess
    {

        private readonly Dictionary<Guid, WebshopUser> userDatabase;
        private readonly ILogger<UserMockDataAccess> _logger;

        /// <summary>
        /// Addes a default TestUser
        /// </summary>
        public UserMockDataAccess(ILogger<UserMockDataAccess> logger)
        {
            userDatabase = new Dictionary<Guid, WebshopUser>();
            _logger = logger;
        }

        public void AddUser(WebshopUser user)
        {
            userDatabase.Add(user.ID, user);
        }

        public void DeleteUser(Guid ID)
        {
            userDatabase.Remove(ID);
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