using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace SuperRocket.OrchardCore.EntityFramework
{
    [DependsOn(
        typeof(OrchardCoreCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class OrchardCoreEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<OrchardCoreDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}