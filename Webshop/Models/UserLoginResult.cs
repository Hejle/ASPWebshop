using System;

namespace ASPWebshop.Pages.Models
{
    public class UserLoginResult
    {
        public User user { get; set; }
        public bool Verified { get; set; }
    }
}