using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using vOpenUy.Demo.Authorization.Users;
using vOpenUy.Demo.Editions;

namespace vOpenUy.Demo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
