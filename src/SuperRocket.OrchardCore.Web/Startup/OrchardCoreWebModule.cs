using System.Reflection;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using SuperRocket.OrchardCore.Configuration;
using SuperRocket.OrchardCore.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Zero.Configuration;

namespace SuperRocket.OrchardCore.Web.Startup
{
    [DependsOn(
        typeof(OrchardCoreApplicationModule), 
        typeof(OrchardCoreEntityFrameworkModule), 
        typeof(AbpAspNetCoreModule))]
    public class OrchardCoreWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public OrchardCoreWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(OrchardCoreConsts.ConnectionStringName);

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Navigation.Providers.Add<OrchardCoreNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(OrchardCoreApplicationModule).Assembly
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}