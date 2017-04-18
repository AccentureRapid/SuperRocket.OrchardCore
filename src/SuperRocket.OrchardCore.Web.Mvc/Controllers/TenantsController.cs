using Abp.AspNetCore.Mvc.Authorization;
using SuperRocket.OrchardCore.Authorization;
using SuperRocket.OrchardCore.Controllers;
using SuperRocket.OrchardCore.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace SuperRocket.OrchardCore.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : OrchardCoreControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}