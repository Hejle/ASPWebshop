using System;
using ASPWebshop.Pages.Models;

namespace ASPWebshop.Services.Interfaces
{
    public interface IUserDataAccess
    {
        User getUser(string username);
        User getUser(Guid ID);
        void AddUser(User user);
    }
}