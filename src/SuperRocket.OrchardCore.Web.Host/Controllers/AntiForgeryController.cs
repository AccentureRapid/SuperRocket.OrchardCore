using SuperRocket.OrchardCore.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace SuperRocket.OrchardCore.Web.Host.Controllers
{
    public class AntiForgeryController : OrchardCoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}