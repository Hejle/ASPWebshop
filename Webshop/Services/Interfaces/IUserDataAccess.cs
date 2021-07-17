using System;
using ASPWebshop.Pages.Models;

namespace ASPWebshop.Services.Interfaces
{
    public interface IUserDataAccess
    {
        WebshopUser getUser(string username);
        WebshopUser getUser(Guid ID);
        void AddUser(WebshopUser user);
    }
}