using ASPWebshop.Common.Models;
using System;

namespace ASPWebshopDatabase.Services
{
    public interface IUserDataAccess
    {
        WebshopUser GetUser(string username);
        WebshopUser GetUser(Guid ID);
        void AddUser(WebshopUser user);
        void DeleteUser(Guid ID);
    }
}
