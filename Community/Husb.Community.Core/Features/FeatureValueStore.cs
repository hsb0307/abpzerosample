using Abp.Application.Features;
using Husb.Community.Authorization.Roles;
using Husb.Community.MultiTenancy;
using Husb.Community.Users;

namespace Husb.Community.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}