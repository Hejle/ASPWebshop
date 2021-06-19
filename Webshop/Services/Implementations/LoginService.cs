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
        public bool verifyUser(string username, string password)
        {
            var user = _userDataAccess.getUser(username);
            if(user.Password.Equals(password)) {
                return true;
            }
            return false;
        }
    }
}