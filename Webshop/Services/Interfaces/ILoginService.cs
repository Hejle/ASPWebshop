using System;
using ASPWebshop.Pages.Models;

namespace ASPWebshop.Services.Interfaces
{
    public interface ILoginService
    {
        /**
        *   Does stuff
        *
        */
        UserLoginResult verifyUser(string username, string password);
    }
}