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

        public UserLoginResult verifyUser(string username, string password)
        {
            var user = _userDataAccess.getUser(username);
            if(user.Password.Equals(password)) {
                return new UserLoginResult {user = user, Verified = true};
            }
            throw UserException.WrongPasswordException(user.Username);
        }
    }
}