using Abp.Authorization;
using Eys.Support.Authorization.Roles;
using Eys.Support.Authorization.Users;

namespace Eys.Support.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
