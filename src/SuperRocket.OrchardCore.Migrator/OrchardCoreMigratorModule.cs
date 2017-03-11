using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using SuperRocket.OrchardCore.Configuration;
using SuperRocket.OrchardCore.EntityFramework;

namespace SuperRocket.OrchardCore.Migrator
{
    [DependsOn(typeof(OrchardCoreEntityFrameworkModule))]
    public class OrchardCoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public OrchardCoreMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(OrchardCoreMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<OrchardCoreDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                OrchardCoreConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}