using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Localization;
using Eblcu.Bi.Authorization;

namespace Eblcu.Bi.StudentPermissions
{
    public class EnrollRecruitAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //在这里配置了nograduate_studentsdata 的权限。
            var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));
            //招生录取
            var enrollRecruits = pages.CreateChildPermission(StudentAppPermissions.EnrollRecruit, L("EnrollRecruit"));

            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count, L("EnrollRecruit.EveryYear_GQZ_EnrollRecruit_Count"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count, L("EnrollRecruit.EveryYear_ZSB_EnrollRecruit_Count"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_EveryYear_EnrollRecruit_Count, L("EnrollRecruit.EveryYear_EnrollRecruit_Count"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_EveryYear_Recruit_Per, L("EnrollRecruit.EveryYear_Recruit_Per"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_Province_Data, L("EnrollRecruit.Province_Data"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count, L("EnrollRecruit.CurrentBatch_Recruit_AgeSex_Count"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count, L("EnrollRecruit.CurrentBatch_EveryProfession_Recruit_Count"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_EveryStation_EnrollRecruit_Count, L("EnrollRecruit.EveryStation_EnrollRecruit_Count"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_EveryBatch_Recruit_Sex_Count, L("EnrollRecruit.EveryBatch_Recruit_Sex_Count"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_Profession_Data, L("EnrollRecruit.Profession_Data"));
            enrollRecruits.CreateChildPermission(StudentAppPermissions.EnrollRecruit_Station_Data, L("EnrollRecruit.Station_Data"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BiConsts.LocalizationSourceName);
        }
    }
}
