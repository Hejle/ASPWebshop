using System;

namespace ASPWebshop.Common.Models
{
    public class WebshopUser
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
