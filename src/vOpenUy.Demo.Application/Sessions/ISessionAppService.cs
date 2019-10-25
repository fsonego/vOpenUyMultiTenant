using System.Threading.Tasks;
using Abp.Application.Services;
using vOpenUy.Demo.Sessions.Dto;

namespace vOpenUy.Demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
