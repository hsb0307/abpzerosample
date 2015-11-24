using System.Threading.Tasks;
using Abp.Application.Services;
using Husb.Community.Roles.Dto;

namespace Husb.Community.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
