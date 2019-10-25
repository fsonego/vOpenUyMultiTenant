using Abp.Application.Services;
using Abp.Application.Services.Dto;
using vOpenUy.Demo.MultiTenancy.Dto;

namespace vOpenUy.Demo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

