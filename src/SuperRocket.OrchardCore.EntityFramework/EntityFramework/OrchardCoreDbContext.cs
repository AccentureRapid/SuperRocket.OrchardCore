using System.Data.Common;
using System.Data.Entity;
using Abp.Notifications;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using SuperRocket.OrchardCore.Authorization.Roles;
using SuperRocket.OrchardCore.Authorization.Users;
using SuperRocket.OrchardCore.Configuration;
using SuperRocket.OrchardCore.MultiTenancy;
using SuperRocket.OrchardCore.Web;

namespace SuperRocket.OrchardCore.EntityFramework
{
    [DbConfigurationType(typeof(OrchardCoreDbConfiguration))]
    public class OrchardCoreDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public OrchardCoreDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                OrchardCoreConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of OrchardCoreDbContext since ABP automatically handles it.
         */
        public OrchardCoreDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public OrchardCoreDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public OrchardCoreDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class OrchardCoreDbConfiguration : DbConfiguration
    {
        public OrchardCoreDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
