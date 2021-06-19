using System;

namespace ASPWebshop.Exceptions
{
    public class UserException : Exception
    {
        public UserException() {}

        public UserException(string message, Exception e)
            : base(message, e)
        {}

        private UserException(string message)
            : base(message)
        {}

        public static UserException UserNotFoundException(string userName) {
            return new UserException(String.Format("Unknown user: {0}", userName));
        }

        public static UserException WrongPasswordException(string userName) {
            return new UserException(String.Format("Password and username does not match for {0}", userName));
        }
    }
}