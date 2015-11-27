using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Husb.ZeroDemo.Authorization.Roles;
using Husb.ZeroDemo.Editions;
using Husb.ZeroDemo.Users;

namespace Husb.ZeroDemo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}