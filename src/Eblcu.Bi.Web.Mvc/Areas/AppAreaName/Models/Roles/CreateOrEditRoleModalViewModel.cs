using Abp.AutoMapper;
using Eblcu.Bi.Authorization.Roles.Dto;
using Eblcu.Bi.Web.Areas.AppAreaName.Models.Common;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}