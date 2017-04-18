using System.Collections.Generic;

namespace SuperRocket.OrchardCore.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
