using Abp.Application.Features;
using Husb.ZeroDemo.Authorization.Roles;
using Husb.ZeroDemo.MultiTenancy;
using Husb.ZeroDemo.Users;

namespace Husb.ZeroDemo.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}