using System.Threading.Tasks;
using Abp.Application.Services;
using Husb.Community.Users.Dto;

namespace Husb.Community.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}