using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using vOpenUy.Demo.Roles.Dto;
using vOpenUy.Demo.Users.Dto;

namespace vOpenUy.Demo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
