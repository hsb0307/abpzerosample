using Abp.Authorization.Roles;
using Husb.ZeroDemo.MultiTenancy;
using Husb.ZeroDemo.Users;

namespace Husb.ZeroDemo.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}