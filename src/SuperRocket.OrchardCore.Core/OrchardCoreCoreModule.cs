using System.Reflection;
using Abp.Modules;
using Abp.Timing;
using Abp.Zero;
using SuperRocket.OrchardCore.Localization;
using Abp.Zero.Configuration;
using SuperRocket.OrchardCore.MultiTenancy;
using SuperRocket.OrchardCore.Authorization.Roles;
using SuperRocket.OrchardCore.Users;
using SuperRocket.OrchardCore.Timing;

namespace SuperRocket.OrchardCore
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class OrchardCoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            OrchardCoreLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = true;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}