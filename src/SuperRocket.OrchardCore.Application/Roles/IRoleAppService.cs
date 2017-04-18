using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.OrchardCore.Roles.Dto;

namespace SuperRocket.OrchardCore.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
