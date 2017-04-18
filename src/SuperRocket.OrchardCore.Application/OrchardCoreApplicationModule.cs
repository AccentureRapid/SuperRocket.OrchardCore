using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using SuperRocket.OrchardCore.Authorization;

namespace SuperRocket.OrchardCore
{
    [DependsOn(
        typeof(OrchardCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OrchardCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OrchardCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}