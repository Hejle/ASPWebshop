using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ASPWebshop.Pages.Login;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASPWebshop.Pages
{
    public class LogoffModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public LogoffModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            // Verification.  
            if (this.User.Identity.IsAuthenticated)
            {
                // Home Page.  
                await SignOutAsync();
                return this.RedirectToPage("Index");
            }
            // Info.  
            return this.RedirectToPage("Index");
        }

        public async Task<IActionResult> LogOff()
        {
            await SignOutAsync();
            return this.RedirectToPage("Index");
        }

        private async Task SignOutAsync()
        {
            var authenticationManager = Request.HttpContext;
            await authenticationManager.SignOutAsync();
        }

    }
}
