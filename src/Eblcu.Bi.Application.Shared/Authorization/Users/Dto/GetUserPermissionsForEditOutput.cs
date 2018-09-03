using System.Collections.Generic;
using Eblcu.Bi.Authorization.Permissions.Dto;

namespace Eblcu.Bi.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}