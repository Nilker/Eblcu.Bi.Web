using System.Collections.Generic;
using Eblcu.Bi.Authorization.Permissions.Dto;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}