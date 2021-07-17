using System.Collections.Generic;
using System.Linq;
using ASPWebshop.Pages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using ASPWebshop.Services.Interfaces;

namespace ASPWebshop.Pages
{
    public class UserPageModel : PageModel
    {
        private readonly IUserDataAccess _userDataAccess;

        public WebshopUser WebshopUser { get; set; }

        public UserPageModel(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public void OnGet()
        {
            var identity = User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;
            var claim = claims.First(x => x.Type.Equals(ClaimTypes.Name));
            WebshopUser = _userDataAccess.GetUser(claim.Value);
        }
    }
}
