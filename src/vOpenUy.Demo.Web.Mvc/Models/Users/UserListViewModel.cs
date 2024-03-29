using System.Collections.Generic;
using vOpenUy.Demo.Roles.Dto;
using vOpenUy.Demo.Users.Dto;

namespace vOpenUy.Demo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
