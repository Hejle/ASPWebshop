using System.ComponentModel.DataAnnotations;

namespace ASPWebshop.Pages.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        public string EMail { get; set; }
    }
}