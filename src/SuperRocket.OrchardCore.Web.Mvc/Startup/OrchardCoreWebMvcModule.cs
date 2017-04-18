using System.Reflection;
using Abp.Modules;
using Abp.Zero.AspNetCore;
using SuperRocket.OrchardCore.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace SuperRocket.OrchardCore.Web.Startup
{
    [DependsOn(typeof(OrchardCoreWebCoreModule))]
    public class OrchardCoreWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OrchardCoreWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Get<IAbpZeroAspNetCoreConfiguration>().AuthenticationScheme = AuthConfigurer.AuthenticationScheme;

            Configuration.Navigation.Providers.Add<OrchardCoreNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}