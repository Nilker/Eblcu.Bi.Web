using Abp.Authorization;
using Eblcu.Bi.Authorization.Roles;
using Eblcu.Bi.Authorization.Users;

namespace Eblcu.Bi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
