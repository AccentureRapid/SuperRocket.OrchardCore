using SuperRocket.OrchardCore.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SuperRocket.OrchardCore.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly OrchardCoreDbContext _context;

        public InitialHostDbBuilder(OrchardCoreDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
