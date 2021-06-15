using ASPWebshop.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASPWebshop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IInfoService _infoService;
        public string Name { get; set; }
        public string Email { get; set; }

        public Microsoft.AspNetCore.Http.HttpContext Context { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IInfoService infoService)
        {
            _logger = logger;
            _infoService = infoService;
            Name = _infoService.GetName();
            Email = _infoService.GetEmail();
        }

        public void OnGet()
        {
            Context = HttpContext;
        }

    }
}
