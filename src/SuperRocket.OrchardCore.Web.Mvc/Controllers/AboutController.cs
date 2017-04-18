using SuperRocket.OrchardCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SuperRocket.OrchardCore.Web.Controllers
{
    public class AboutController : OrchardCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}