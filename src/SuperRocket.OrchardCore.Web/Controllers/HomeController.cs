using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SuperRocket.OrchardCore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : OrchardCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}