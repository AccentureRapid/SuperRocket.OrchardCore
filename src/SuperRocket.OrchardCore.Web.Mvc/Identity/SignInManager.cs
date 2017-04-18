using Abp.Configuration;
using Abp.Domain.Uow;
using Abp.Zero.AspNetCore;
using SuperRocket.OrchardCore.Authorization.Roles;
using SuperRocket.OrchardCore.Authorization.Users;
using SuperRocket.OrchardCore.MultiTenancy;
using SuperRocket.OrchardCore.Users;
using Microsoft.AspNetCore.Http;

namespace SuperRocket.OrchardCore.Web.Identity
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager,
            IHttpContextAccessor contextAccessor,
            ISettingManager settingManager,
            IUnitOfWorkManager unitOfWorkManager,
            IAbpZeroAspNetCoreConfiguration configuration)
            : base(
                  userManager,
                  contextAccessor,
                  settingManager,
                  unitOfWorkManager,
                  configuration)
        {
        }
    }
}
