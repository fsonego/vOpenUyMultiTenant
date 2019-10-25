using Abp.AutoMapper;
using vOpenUy.Demo.Sessions.Dto;

namespace vOpenUy.Demo.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
