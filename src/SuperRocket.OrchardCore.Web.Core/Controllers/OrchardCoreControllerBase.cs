using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNet.Identity;

namespace SuperRocket.OrchardCore.Controllers
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