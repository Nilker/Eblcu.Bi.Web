namespace Eblcu.Bi.Authorization
{
    /// <summary>
    /// Defines string constants for application's permission names.
    /// <see cref="AppAuthorizationProvider"/> for permission definitions.
    /// </summary>
    public static class AppPermissions
    {
        //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

        public const string Pages = "Pages";

        public const string Pages_DemoUiComponents= "Pages.DemoUiComponents";
        public const string Pages_Administration = "Pages.Administration";

        public const string Pages_Administration_Roles = "Pages.Administration.Roles";
        public const string Pages_Administration_Roles_Create = "Pages.Administration.Roles.Create";
        public const string Pages_Administration_Roles_Edit = "Pages.Administration.Roles.Edit";
        public const string Pages_Administration_Roles_Delete = "Pages.Administration.Roles.Delete";

        public const string Pages_Administration_Users = "Pages.Administration.Users";
        public const string Pages_Administration_Users_Create = "Pages.Administration.Users.Create";
        public const string Pages_Administration_Users_Edit = "Pages.Administration.Users.Edit";
        public const string Pages_Administration_Users_Delete = "Pages.Administration.Users.Delete";
        public const string Pages_Administration_Users_ChangePermissions = "Pages.Administration.Users.ChangePermissions";
        public const string Pages_Administration_Users_Impersonation = "Pages.Administration.Users.Impersonation";

        public const string Pages_Administration_Languages = "Pages.Administration.Languages";
        public const string Pages_Administration_Languages_Create = "Pages.Administration.Languages.Create";
        public const string Pages_Administration_Languages_Edit = "Pages.Administration.Languages.Edit";
        public const string Pages_Administration_Languages_Delete = "Pages.Administration.Languages.Delete";
        public const string Pages_Administration_Languages_ChangeTexts = "Pages.Administration.Languages.ChangeTexts";

        public const string Pages_Administration_AuditLogs = "Pages.Administration.AuditLogs";

        public const string Pages_Administration_OrganizationUnits = "Pages.Administration.OrganizationUnits";
        public const string Pages_Administration_OrganizationUnits_ManageOrganizationTree = "Pages.Administration.OrganizationUnits.ManageOrganizationTree";
        public const string Pages_Administration_OrganizationUnits_ManageMembers = "Pages.Administration.OrganizationUnits.ManageMembers";

        public const string Pages_Administration_HangfireDashboard = "Pages.Administration.HangfireDashboard";

        public const string Pages_Administration_UiCustomization = "Pages.Administration.UiCustomization";

        //TENANT-SPECIFIC PERMISSIONS

        public const string Pages_Tenant_Dashboard = "Pages.Tenant.Dashboard";

        public const string Pages_Administration_Tenant_Settings = "Pages.Administration.Tenant.Settings";

        public const string Pages_Administration_Tenant_SubscriptionManagement = "Pages.Administration.Tenant.SubscriptionManagement";

        //HOST-SPECIFIC PERMISSIONS

        public const string Pages_Editions = "Pages.Editions";
        public const string Pages_Editions_Create = "Pages.Editions.Create";
        public const string Pages_Editions_Edit = "Pages.Editions.Edit";
        public const string Pages_Editions_Delete = "Pages.Editions.Delete";

        public const string Pages_Tenants = "Pages.Tenants";
        public const string Pages_Tenants_Create = "Pages.Tenants.Create";
        public const string Pages_Tenants_Edit = "Pages.Tenants.Edit";
        public const string Pages_Tenants_ChangeFeatures = "Pages.Tenants.ChangeFeatures";
        public const string Pages_Tenants_Delete = "Pages.Tenants.Delete";
        public const string Pages_Tenants_Impersonation = "Pages.Tenants.Impersonation";

        public const string Pages_Administration_Host_Maintenance = "Pages.Administration.Host.Maintenance";
        public const string Pages_Administration_Host_Settings = "Pages.Administration.Host.Settings";
        public const string Pages_Administration_Host_Dashboard = "Pages.Administration.Host.Dashboard";


        //招生录取
        public const string EnrollRecruit = "EnrollRecruit";
        public const string EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count = "EnrollRecruit.EveryYear_GQZ_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count= "EnrollRecruit.EveryYear_ZSB_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryYear_EnrollRecruit_Count = "EnrollRecruit.EveryYear_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryYear_Recruit_Per = "EnrollRecruit.EveryYear_Recruit_Per";
        public const string EnrollRecruit_Province_Data = "EnrollRecruit.Province_Data";
        public const string EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count = "EnrollRecruit.CurrentBatch_Recruit_AgeSex_Count";
        public const string EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count = "EnrollRecruit.CurrentBatch_EveryProfession_Recruit_Count";
        public const string EnrollRecruit_EveryStation_EnrollRecruit_Count = "EnrollRecruit.EveryStation_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryBatch_Recruit_Sex_Count = "EnrollRecruit.EveryBatch_Recruit_Sex_Count";
        public const string EnrollRecruit_Profession_Data = "EnrollRecruit.Profession_Data";
        public const string EnrollRecruit_Station_Data = "EnrollRecruit.Station_Data";
        

        //学生缴费
        public const string StudentPay = "StudentPay";
        public const string StudentPay_EveryProfession_StudentFirstPay_Per = "StudentPay.EveryProfession_StudentFirstPay_Per";
        public const string StudentPay_EveryProfession_OldStudentRenewPay_Per = "StudentPay.EveryProfession_OldStudentRenewPay_Per";
        public const string StudentPay_EveryStation_StudentFirstPay_Per = "StudentPay.EveryStation_StudentFirstPay_Per";
        public const string StudentPay_EveryStation_OldStudentRenewPay_Per = "StudentPay.EveryStation_OldStudentRenewPay_Per";
        public const string StudentPay_EveryBatch_OldStudentRenewPay_Per = "StudentPay.EveryBatch_OldStudentRenewPay_Per";
        public const string StudentPay_DropOut_Term_Per = "StudentPay.DropOut_Term_Per";
        public const string StudentPay_DropOut_AgeSex_Count = "StudentPay.DropOut_AgeSex_Count";
        public const string StudentPay_DropOut_StudyLevel_Per = "StudentPay.DropOut_StudyLevel_Per";
        public const string StudentPay_EveryBatch_StudentFirstPay_Per = "StudentPay.EveryBatch_StudentFirstPay_Per";
        public const string StudentPay_EveryProfession_DropOut_Count = "StudentPay.EveryProfession_DropOut_Count";
        public const string StudentPay_EveryStation_DropOut_Count = "StudentPay.EveryStation_DropOut_Count";
        public const string StudentPay_EveryBatch_DropOut_Count = "StudentPay.EveryBatch_DropOut_Count";

        //学生管理
        public const string StudentManage = "StudentManage";
        public const string StudentManage_InReading_Profession_Data = "StudentManage.InReading_Profession_Data";
        public const string StudentManage_InReading_Profession_Per = "StudentManage.InReading_Profession_Per";
        public const string StudentManage_InReading_AgeSex_Count = "StudentManage.InReading_AgeSex_Count";
        public const string StudentManage_InReading_Batch_Count = "StudentManage.InReading_Batch_Count";
        public const string StudentManage_EveryYear_Graduate_Count = "StudentManage.EveryYear_Graduate_Count";
        public const string StudentManage_NotGraduate_2_5_Per = "StudentManage.NotGraduate_2_5_Per";
        public const string StudentManage_EveryStation_Graduate_Per = "StudentManage.EveryStation_Graduate_Per";
        public const string StudentManage_EveryProfession_Graduate_Per = "StudentManage.EveryProfession_Graduate_Per";
        public const string StudentManage_Graduate_StudyTime_Count = "StudentManage.Graduate_StudyTime_Count";
        public const string StudentManage_NotGraduate_Term = "StudentManage.NotGraduate_Term";
        public const string StudentManage_Graduate_EveryBatch_BZ_Data = "StudentManage.Graduate_EveryBatch_BZ_Data";
        public const string StudentManage_Graduate_EveryBatch_Term_Data = "StudentManage.Graduate_EveryBatch_Term_Data";
        public const string StudentManage_NotGraduate_5_5_AgeSex_Count = "StudentManage.NotGraduate_5_5_AgeSex_Count";
        public const string StudentManage_NotGraduate_5_5_Per = "StudentManage.NotGraduate_5_5_Per";





    }
}