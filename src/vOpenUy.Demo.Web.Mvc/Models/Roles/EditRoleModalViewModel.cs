using Abp.AutoMapper;
using vOpenUy.Demo.Roles.Dto;
using vOpenUy.Demo.Web.Models.Common;

namespace vOpenUy.Demo.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
