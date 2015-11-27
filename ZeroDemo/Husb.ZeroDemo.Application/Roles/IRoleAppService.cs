using System.Threading.Tasks;
using Abp.Application.Services;
using Husb.ZeroDemo.Roles.Dto;

namespace Husb.ZeroDemo.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
