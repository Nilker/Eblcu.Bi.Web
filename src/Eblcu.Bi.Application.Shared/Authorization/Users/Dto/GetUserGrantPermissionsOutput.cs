using Eblcu.Bi.Authorization.Permissions.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eblcu.Bi.Authorization.Users.Dto
{
    public  class GetUserGrantPermissionsOutput
    {
        public List<FlatPermissionDto> GrantedPermissions { get; set; }
    }
}
