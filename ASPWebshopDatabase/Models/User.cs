using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace ASPWebshopDatabase.Models
{
    [Index(nameof(Username), IsUnique = true)]
    public class User
    {
        [Required]
        [Key]
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

