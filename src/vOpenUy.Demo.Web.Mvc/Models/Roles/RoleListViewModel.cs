using System.Collections.Generic;
using vOpenUy.Demo.Roles.Dto;

namespace vOpenUy.Demo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
