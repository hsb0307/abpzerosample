using Abp.Authorization;
using Husb.Community.Authorization.Roles;
using Husb.Community.MultiTenancy;
using Husb.Community.Users;

namespace Husb.Community.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
