using Abp.MultiTenancy;
using SuperRocket.OrchardCore.Users;

namespace SuperRocket.OrchardCore.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}