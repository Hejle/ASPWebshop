using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ASPWebshop.Pages.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ASPWebshop.Services.Interfaces;
using ASPWebshop.Exceptions;
using ASPWebshop.Pages.Models;

namespace ASPWebshop.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly ILoginService _loginService;

        public string ErrorMessage {get; set;}

        public LoginModel(ILogger<PrivacyModel> logger, ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;

        }

        [BindProperty]
        public LoginViewModel LoginViewModel { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            { 
                if (this.User.Identity.IsAuthenticated)
                {  
                    await SignOutAsync();
                    return this.RedirectToPage("Index");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return this.Page();
        }

        public async Task<IActionResult> LogOff()
        {
            await SignOutAsync();
            return this.RedirectToPage("Index");
        }

        public async Task<IActionResult> OnPostLogIn()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var username = this.LoginViewModel.Username;
                    var password = this.LoginViewModel.Password;
                    var userResult = _loginService.verifyUser(username, password);
                    if (userResult.Verified)
                    {
                        await this.SignInUser(userResult.user, false);

                        return this.RedirectToPage("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    }
                }
            }
            catch (UserException ex)
            {
                ErrorMessage = ex.Message;
            } catch (Exception e) {
                Console.Write(e);
            }
            return this.Page();
        }


        private async Task SignOutAsync()
        {
            var authenticationManager = Request.HttpContext;
            await authenticationManager.SignOutAsync();
        }

        private async Task SignInUser(User user, bool isPersistent)
        {
            // Initialization.  
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Email, user.EMail),
                new Claim(ClaimTypes.UserData, user.ID.ToString()),
                new Claim(ClaimTypes.Role, "Administrator")
            };

            try
            {
                var claimIdenties = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };
                var claimPrincipal = new ClaimsPrincipal(claimIdenties);
                var authenticationManager = Request.HttpContext;

                // Sign In.  
                await authenticationManager.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, authProperties);
            }
            catch (Exception)
            {
                
            }
        }
    }
}
