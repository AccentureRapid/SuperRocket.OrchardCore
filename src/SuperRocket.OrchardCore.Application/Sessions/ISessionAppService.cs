using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.OrchardCore.Sessions.Dto;

namespace SuperRocket.OrchardCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
