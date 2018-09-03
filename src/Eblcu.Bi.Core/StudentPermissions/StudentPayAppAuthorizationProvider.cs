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
    public class StudentPayAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //在这里配置了nograduate_studentsdata 的权限。
            var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));
            //学生缴费
            var studentPays = pages.CreateChildPermission(StudentAppPermissions.StudentPay, L("StudentPay"));

            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryProfession_StudentFirstPay_Per, L("StudentPay.EveryProfession_StudentFirstPay_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryProfession_OldStudentRenewPay_Per, L("StudentPay.EveryProfession_OldStudentRenewPay_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryStation_StudentFirstPay_Per, L("StudentPay.EveryStation_StudentFirstPay_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryStation_OldStudentRenewPay_Per, L("StudentPay.EveryStation_OldStudentRenewPay_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryBatch_OldStudentRenewPay_Per, L("StudentPay.EveryBatch_OldStudentRenewPay_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_DropOut_Term_Per, L("StudentPay.DropOut_Term_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_DropOut_AgeSex_Count, L("StudentPay.DropOut_AgeSex_Count"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_DropOut_StudyLevel_Per, L("StudentPay.DropOut_StudyLevel_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryBatch_StudentFirstPay_Per, L("StudentPay.EveryBatch_StudentFirstPay_Per"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryProfession_DropOut_Count, L("StudentPay.EveryProfession_DropOut_Count"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryStation_DropOut_Count, L("StudentPay.EveryStation_DropOut_Count"));
            studentPays.CreateChildPermission(StudentAppPermissions.StudentPay_EveryBatch_DropOut_Count, L("StudentPay.EveryBatch_DropOut_Count"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BiConsts.LocalizationSourceName);
        }
    }
}
