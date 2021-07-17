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
        UserLoginResult VerifyUser(string username, string password);
    }
}