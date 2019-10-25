using System.Collections.Generic;
using vOpenUy.Demo.Roles.Dto;

namespace vOpenUy.Demo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}