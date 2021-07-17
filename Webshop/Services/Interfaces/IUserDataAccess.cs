using System;
using ASPWebshop.Pages.Models;

namespace ASPWebshop.Services.Interfaces
{
    public interface IUserDataAccess
    {
        WebshopUser GetUser(string username);
        WebshopUser GetUser(Guid ID);
        void AddUser(WebshopUser user);
    }
}