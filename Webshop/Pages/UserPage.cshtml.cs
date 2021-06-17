using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASPWebshop.Pages
{
    public class UserPageModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public UserPageModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
