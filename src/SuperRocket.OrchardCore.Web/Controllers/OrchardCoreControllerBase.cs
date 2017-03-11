using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace SuperRocket.OrchardCore.Web.Controllers
{
    public abstract class OrchardCoreControllerBase: AbpController
    {
        protected OrchardCoreControllerBase()
        {
            LocalizationSourceName = OrchardCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}