using System.Threading.Tasks;
using Abp.Application.Services;
using Husb.ZeroDemo.Users.Dto;

namespace Husb.ZeroDemo.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}