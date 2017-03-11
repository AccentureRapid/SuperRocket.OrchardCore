using Abp.Authorization;
using SuperRocket.OrchardCore.Authorization.Roles;
using SuperRocket.OrchardCore.MultiTenancy;
using SuperRocket.OrchardCore.Users;

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
