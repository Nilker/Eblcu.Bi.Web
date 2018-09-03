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
    public class StudentManageAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //在这里配置了nograduate_studentsdata 的权限。
            var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));
            //学生管理
            var studentManages = pages.CreateChildPermission(StudentAppPermissions.StudentManage, L("StudentManage"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_InReading_Profession_Data, L("StudentManage.InReading_Profession_Data"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_InReading_Profession_Per, L("StudentManage.InReading_Profession_Per"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_InReading_AgeSex_Count, L("StudentManage.InReading_AgeSex_Count"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_InReading_Batch_Count, L("StudentManage.InReading_Batch_Count"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_EveryYear_Graduate_Count, L("StudentManage.EveryYear_Graduate_Count"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_NotGraduate_2_5_Per, L("StudentManage.NotGraduate_2_5_Per"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_EveryStation_Graduate_Per, L("StudentManage.EveryStation_Graduate_Per"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_EveryProfession_Graduate_Per, L("StudentManage.EveryProfession_Graduate_Per"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_Graduate_StudyTime_Count, L("StudentManage.Graduate_StudyTime_Count"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_NotGraduate_Term, L("StudentManage.NotGraduate_Term"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_Graduate_EveryBatch_BZ_Data, L("StudentManage.Graduate_EveryBatch_BZ_Data"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_Graduate_EveryBatch_Term_Data, L("StudentManage.Graduate_EveryBatch_Term_Data"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_NotGraduate_5_5_AgeSex_Count, L("StudentManage.NotGraduate_5_5_AgeSex_Count"));
            studentManages.CreateChildPermission(StudentAppPermissions.StudentManage_NotGraduate_5_5_Per, L("StudentManage.NotGraduate_5_5_Per"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BiConsts.LocalizationSourceName);
        }
    }
}
