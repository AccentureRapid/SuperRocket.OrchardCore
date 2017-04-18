using System.Linq;
using SuperRocket.OrchardCore.EntityFramework;
using SuperRocket.OrchardCore.MultiTenancy;

namespace SuperRocket.OrchardCore.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly OrchardCoreDbContext _context;

        public DefaultTenantCreator(OrchardCoreDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
