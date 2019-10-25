using Abp.Authorization;
using vOpenUy.Demo.Authorization.Roles;
using vOpenUy.Demo.Authorization.Users;

namespace vOpenUy.Demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
