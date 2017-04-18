using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace SuperRocket.OrchardCore.Web.Views
{
    public abstract class OrchardCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected OrchardCoreRazorPage()
        {
            LocalizationSourceName = OrchardCoreConsts.LocalizationSourceName;
        }
    }
}
