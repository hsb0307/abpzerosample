using Abp.Authorization.Roles;
using Husb.Community.MultiTenancy;
using Husb.Community.Users;

namespace Husb.Community.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}