using Abp.MultiTenancy;
using Husb.ZeroDemo.Users;

namespace Husb.ZeroDemo.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}