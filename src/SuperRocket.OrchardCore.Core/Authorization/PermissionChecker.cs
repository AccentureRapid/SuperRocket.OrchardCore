using Abp.Authorization;
using SuperRocket.OrchardCore.Authorization.Roles;
using SuperRocket.OrchardCore.Authorization.Users;
using SuperRocket.OrchardCore.MultiTenancy;

namespace SuperRocket.OrchardCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
