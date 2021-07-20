using ASPWebshop.Common.Models;

namespace ASPWebshop.Pages.Models
{
    public class UserLoginResult
    {
        public WebshopUser WebshopUser { get; set; }
        public bool Verified { get; set; }
    }
}