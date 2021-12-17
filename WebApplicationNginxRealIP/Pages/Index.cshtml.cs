using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationNginxRealIP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public string RemoteIp => HttpContext.Connection.RemoteIpAddress?.ToString() ?? "null";

        public string ForwardedIp=> HttpContext.Request.Headers["X-Forwarded-For"];
        public string ForwardedScheme => HttpContext.Request.Headers["X-Forwarded-Proto"];
        public string Host => HttpContext.Request.Host.Host;
        public string RealIp => HttpContext.Request.Headers["X-Real-IP"];
    }
}