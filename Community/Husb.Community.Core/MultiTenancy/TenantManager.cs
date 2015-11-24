using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Husb.Community.Authorization.Roles;
using Husb.Community.Editions;
using Husb.Community.Users;

namespace Husb.Community.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository,
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository,
            EditionManager editionManager)
            : base(tenantRepository, tenantFeatureRepository,  editionManager)
        {

        }
    }
}