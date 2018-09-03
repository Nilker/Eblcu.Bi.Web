using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Eblcu.Bi.Authorization
{
    /// <summary>
    /// Application's authorization provider.
    /// Defines permissions for the application.
    /// See <see cref="AppPermissions"/> for all permission names.
    /// </summary>
    public class AppAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public AppAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public AppAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));
            pages.CreateChildPermission(AppPermissions.Pages_DemoUiComponents, L("DemoUiComponents"));

            var administration = pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            var roles = administration.CreateChildPermission(AppPermissions.Pages_Administration_Roles, L("Roles"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Create, L("CreatingNewRole"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Edit, L("EditingRole"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Delete, L("DeletingRole"));

            var users = administration.CreateChildPermission(AppPermissions.Pages_Administration_Users, L("Users"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Create, L("CreatingNewUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Edit, L("EditingUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Delete, L("DeletingUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_ChangePermissions, L("ChangingPermissions"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Impersonation, L("LoginForUsers"));

            var languages = administration.CreateChildPermission(AppPermissions.Pages_Administration_Languages, L("Languages"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Create, L("CreatingNewLanguage"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Edit, L("EditingLanguage"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Delete, L("DeletingLanguages"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_ChangeTexts, L("ChangingTexts"));

            administration.CreateChildPermission(AppPermissions.Pages_Administration_AuditLogs, L("AuditLogs"));

            var organizationUnits = administration.CreateChildPermission(AppPermissions.Pages_Administration_OrganizationUnits, L("OrganizationUnits"));
            organizationUnits.CreateChildPermission(AppPermissions.Pages_Administration_OrganizationUnits_ManageOrganizationTree, L("ManagingOrganizationTree"));
            organizationUnits.CreateChildPermission(AppPermissions.Pages_Administration_OrganizationUnits_ManageMembers, L("ManagingMembers"));

            administration.CreateChildPermission(AppPermissions.Pages_Administration_UiCustomization, L("VisualSettings"));

            //TENANT-SPECIFIC PERMISSIONS

            pages.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard, L("Dashboard"), multiTenancySides: MultiTenancySides.Tenant);

            administration.CreateChildPermission(AppPermissions.Pages_Administration_Tenant_Settings, L("Settings"), multiTenancySides: MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement, L("Subscription"), multiTenancySides: MultiTenancySides.Tenant);

            //HOST-SPECIFIC PERMISSIONS

            var editions = pages.CreateChildPermission(AppPermissions.Pages_Editions, L("Editions"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Create, L("CreatingNewEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Edit, L("EditingEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Delete, L("DeletingEdition"), multiTenancySides: MultiTenancySides.Host);

            var tenants = pages.CreateChildPermission(AppPermissions.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Create, L("CreatingNewTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Edit, L("EditingTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_ChangeFeatures, L("ChangingFeatures"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Delete, L("DeletingTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Impersonation, L("LoginForTenants"), multiTenancySides: MultiTenancySides.Host);

            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Settings, L("Settings"), multiTenancySides: MultiTenancySides.Host);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Maintenance, L("Maintenance"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_HangfireDashboard, L("HangfireDashboard"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard, L("Dashboard"), multiTenancySides: MultiTenancySides.Host);


            //招生录取
            var enrollRecruits = pages.CreateChildPermission(AppPermissions.EnrollRecruit, L("EnrollRecruit"));

            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count, L("EnrollRecruit.EveryYear_GQZ_EnrollRecruit_Count") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count, L("EnrollRecruit.EveryYear_ZSB_EnrollRecruit_Count") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_EveryYear_EnrollRecruit_Count, L("EnrollRecruit.EveryYear_EnrollRecruit_Count") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_EveryYear_Recruit_Per, L("EnrollRecruit.EveryYear_Recruit_Per") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_Province_Data, L("EnrollRecruit.Province_Data") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count, L("EnrollRecruit.CurrentBatch_Recruit_AgeSex_Count") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count, L("EnrollRecruit.CurrentBatch_EveryProfession_Recruit_Count") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_EveryStation_EnrollRecruit_Count, L("EnrollRecruit.EveryStation_EnrollRecruit_Count") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_EveryBatch_Recruit_Sex_Count, L("EnrollRecruit.EveryBatch_Recruit_Sex_Count") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_Profession_Data, L("EnrollRecruit.Profession_Data") );
            enrollRecruits.CreateChildPermission(AppPermissions.EnrollRecruit_Station_Data, L("EnrollRecruit.Station_Data") );


            //学生缴费
            var studentPays = pages.CreateChildPermission(AppPermissions.StudentPay, L("StudentPay"));

            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryProfession_StudentFirstPay_Per, L("StudentPay.EveryProfession_StudentFirstPay_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryProfession_OldStudentRenewPay_Per, L("StudentPay.EveryProfession_OldStudentRenewPay_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryStation_StudentFirstPay_Per, L("StudentPay.EveryStation_StudentFirstPay_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryStation_OldStudentRenewPay_Per, L("StudentPay.EveryStation_OldStudentRenewPay_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryBatch_OldStudentRenewPay_Per, L("StudentPay.EveryBatch_OldStudentRenewPay_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_DropOut_Term_Per, L("StudentPay.DropOut_Term_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_DropOut_AgeSex_Count, L("StudentPay.DropOut_AgeSex_Count") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_DropOut_StudyLevel_Per, L("StudentPay.DropOut_StudyLevel_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryBatch_StudentFirstPay_Per, L("StudentPay.EveryBatch_StudentFirstPay_Per") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryProfession_DropOut_Count, L("StudentPay.EveryProfession_DropOut_Count") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryStation_DropOut_Count, L("StudentPay.EveryStation_DropOut_Count") );
            studentPays.CreateChildPermission(AppPermissions.StudentPay_EveryBatch_DropOut_Count, L("StudentPay.EveryBatch_DropOut_Count") );

            //学生管理
            var studentManages = pages.CreateChildPermission(AppPermissions.StudentManage, L("StudentManage"));
            studentManages.CreateChildPermission(AppPermissions.StudentManage_InReading_Profession_Data, L("StudentManage.InReading_Profession_Data") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_InReading_Profession_Per, L("StudentManage.InReading_Profession_Per") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_InReading_AgeSex_Count, L("StudentManage.InReading_AgeSex_Count") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_InReading_Batch_Count, L("StudentManage.InReading_Batch_Count") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_EveryYear_Graduate_Count, L("StudentManage.EveryYear_Graduate_Count") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_NotGraduate_2_5_Per, L("StudentManage.NotGraduate_2_5_Per") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_EveryStation_Graduate_Per, L("StudentManage.EveryStation_Graduate_Per") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_EveryProfession_Graduate_Per, L("StudentManage.EveryProfession_Graduate_Per") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_Graduate_StudyTime_Count, L("StudentManage.Graduate_StudyTime_Count") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_NotGraduate_Term, L("StudentManage.NotGraduate_Term") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_Graduate_EveryBatch_BZ_Data, L("StudentManage.Graduate_EveryBatch_BZ_Data") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_Graduate_EveryBatch_Term_Data, L("StudentManage.Graduate_EveryBatch_Term_Data") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_NotGraduate_5_5_AgeSex_Count, L("StudentManage.NotGraduate_5_5_AgeSex_Count") );
            studentManages.CreateChildPermission(AppPermissions.StudentManage_NotGraduate_5_5_Per, L("StudentManage.NotGraduate_5_5_Per") );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BiConsts.LocalizationSourceName);
        }
    }
}
