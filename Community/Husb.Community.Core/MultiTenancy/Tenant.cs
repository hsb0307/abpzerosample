using Abp.MultiTenancy;
using Husb.Community.Users;

namespace Husb.Community.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}