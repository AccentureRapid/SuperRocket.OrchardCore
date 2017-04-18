using Abp.AutoMapper;
using SuperRocket.OrchardCore.Authentication.External;

namespace SuperRocket.OrchardCore.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
