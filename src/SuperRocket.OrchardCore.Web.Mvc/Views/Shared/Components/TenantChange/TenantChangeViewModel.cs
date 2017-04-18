using Abp.AutoMapper;
using SuperRocket.OrchardCore.Sessions.Dto;

namespace SuperRocket.OrchardCore.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}