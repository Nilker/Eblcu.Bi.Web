using Abp.AutoMapper;
using Eblcu.Bi.Authorization.Users;
using Eblcu.Bi.Authorization.Users.Dto;
using Eblcu.Bi.Web.Areas.AppAreaName.Models.Common;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}