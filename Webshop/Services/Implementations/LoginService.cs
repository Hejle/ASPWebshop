using System;
using ASPWebshop.Exceptions;
using ASPWebshop.Pages.Models;
using ASPWebshop.Services.Interfaces;

namespace ASPWebshop.Services.Implementations
{
    public class LoginService : ILoginService
    {
        private readonly IUserDataAccess _userDataAccess;
        public LoginService(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public UserLoginResult VerifyUser(string username, string password)
        {
            var user = _userDataAccess.GetUser(username);
            if(user.Password.Equals(password)) {
                return new UserLoginResult {WebshopUser = user, Verified = true};
            }
            throw UserException.WrongPasswordException(user.Username);
            return null;
        }
    }
}