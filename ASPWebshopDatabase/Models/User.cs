using System;
using System.ComponentModel.DataAnnotations;

namespace ASPWebshopDatabase.Models
{
    public class User
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string EMail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

