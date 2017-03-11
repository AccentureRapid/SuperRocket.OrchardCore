using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SuperRocket.OrchardCore.MultiTenancy;

namespace SuperRocket.OrchardCore.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}