using System.Linq;
using Abp.Application.Navigation;
using Abp.Localization;
using Eblcu.Bi.Authorization;
using Eblcu.Bi.Authorization.Users;
using Eblcu.Bi.StudentPermissions;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Startup
{
    public class AppAreaNameNavigationProvider : NavigationProvider
    {
        private readonly IUserAppService _userAppService;
        public AppAreaNameNavigationProvider(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaName/HostDashboard",
                        icon: "flaticon-line-graph",
                        requiredPermissionName: AppPermissions.Pages_Administration_Host_Dashboard
                    )
                ).AddItem(new MenuItemDefinition(
                    AppAreaNamePageNames.Host.Tenants,
                    L("Tenants"),
                    url: "AppAreaName/Tenants",
                    icon: "flaticon-list-3",
                    requiredPermissionName: AppPermissions.Pages_Tenants
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Host.Editions,
                        L("Editions"),
                        url: "AppAreaName/Editions",
                        icon: "flaticon-app",
                        requiredPermissionName: AppPermissions.Pages_Editions
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaName/Dashboard",
                        icon: "flaticon-line-graph",
                        requiredPermissionName: AppPermissions.Pages_Tenant_Dashboard
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8"
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "AppAreaName/OrganizationUnits",
                            icon: "flaticon-map",
                            requiredPermissionName: AppPermissions.Pages_Administration_OrganizationUnits
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.Roles,
                            L("Roles"),
                            url: "AppAreaName/Roles",
                            icon: "flaticon-suitcase",
                            requiredPermissionName: AppPermissions.Pages_Administration_Roles
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.Users,
                            L("Users"),
                            url: "AppAreaName/Users",
                            icon: "flaticon-users",
                            requiredPermissionName: AppPermissions.Pages_Administration_Users
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.Languages,
                            L("Languages"),
                            url: "AppAreaName/Languages",
                            icon: "flaticon-tabs",
                            requiredPermissionName: AppPermissions.Pages_Administration_Languages
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "AppAreaName/AuditLogs",
                            icon: "flaticon-folder-1",
                            requiredPermissionName: AppPermissions.Pages_Administration_AuditLogs
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "AppAreaName/Maintenance",
                            icon: "flaticon-lock",
                            requiredPermissionName: AppPermissions.Pages_Administration_Host_Maintenance
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "AppAreaName/SubscriptionManagement",
                            icon: "flaticon-refresh"
                            ,
                            requiredPermissionName: AppPermissions.Pages_Administration_Tenant_SubscriptionManagement
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "AppAreaName/UiCustomization",
                            icon: "flaticon-medical",
                            requiredPermissionName: AppPermissions.Pages_Administration_UiCustomization
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Host.Settings,
                            L("Settings"),
                            url: "AppAreaName/HostSettings",
                            icon: "flaticon-settings",
                            requiredPermissionName: AppPermissions.Pages_Administration_Host_Settings
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppAreaNamePageNames.Tenant.Settings,
                            L("Settings"),
                            url: "AppAreaName/Settings",
                            icon: "flaticon-settings",
                            requiredPermissionName: AppPermissions.Pages_Administration_Tenant_Settings
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaNamePageNames.Common.DemoUiComponents,
                        L("DemoUiComponents"),
                        url: "AppAreaName/DemoUiComponents",
                        icon: "flaticon-shapes",
                        requiredPermissionName: AppPermissions.Pages_DemoUiComponents
                    )
                );


            #region 动态菜单

           //var currentUserPer= _userAppService.GeCurrentUserGrantedPermissions().Result;

           // foreach (var item in currentUserPer.Where(s=>s.IsParent))
           // {
           //     menu.AddItem(new MenuItemDefinition(
           //         item.Name,
           //         L(item.Name),
           //         icon: "flaticon-interface-8"
           //     ));
           // }

            //招生录取
            menu.AddItem(new MenuItemDefinition(
                StudentAppPermissions.EnrollRecruit,
                L(StudentAppPermissions.EnrollRecruit),
                icon: "flaticon-interface-8"
            ).AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count,
                    L(StudentAppPermissions.EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count),
                    url: StudentAppPermissions.EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count
                    ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count,
                    L(StudentAppPermissions.EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count),
                    url: StudentAppPermissions.EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_EveryYear_EnrollRecruit_Count,
                    L(StudentAppPermissions.EnrollRecruit_EveryYear_EnrollRecruit_Count),
                    url: StudentAppPermissions.EnrollRecruit_EveryYear_EnrollRecruit_Count.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_EveryYear_EnrollRecruit_Count
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_EveryYear_Recruit_Per,
                    L(StudentAppPermissions.EnrollRecruit_EveryYear_Recruit_Per),
                    url: StudentAppPermissions.EnrollRecruit_EveryYear_Recruit_Per.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_EveryYear_Recruit_Per
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_Province_Data,
                    L(StudentAppPermissions.EnrollRecruit_Province_Data),
                    url: StudentAppPermissions.EnrollRecruit_Province_Data.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_Province_Data
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count,
                    L(StudentAppPermissions.EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count),
                    url: StudentAppPermissions.EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count,
                    L(StudentAppPermissions.EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count),
                    url: StudentAppPermissions.EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_EveryStation_EnrollRecruit_Count,
                    L(StudentAppPermissions.EnrollRecruit_EveryStation_EnrollRecruit_Count),
                    url: StudentAppPermissions.EnrollRecruit_EveryStation_EnrollRecruit_Count.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_EveryStation_EnrollRecruit_Count
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_EveryBatch_Recruit_Sex_Count,
                    L(StudentAppPermissions.EnrollRecruit_EveryBatch_Recruit_Sex_Count),
                    url: StudentAppPermissions.EnrollRecruit_EveryBatch_Recruit_Sex_Count.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_EveryBatch_Recruit_Sex_Count
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_Profession_Data,
                    L(StudentAppPermissions.EnrollRecruit_Profession_Data),
                    url: StudentAppPermissions.EnrollRecruit_Profession_Data.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_Profession_Data
                ))
                .AddItem(new MenuItemDefinition(
                    StudentAppPermissions.EnrollRecruit_Station_Data,
                    L(StudentAppPermissions.EnrollRecruit_Station_Data),
                    url: StudentAppPermissions.EnrollRecruit_Station_Data.Replace('.', '/'),
                    icon: "flaticon-shapes",
                    requiredPermissionName: StudentAppPermissions.EnrollRecruit_Station_Data
                ))
            );

            //学生缴费
            menu.AddItem(new MenuItemDefinition(
                StudentAppPermissions.StudentPay,
                L(StudentAppPermissions.StudentPay),
                icon: "flaticon-interface-8"
            ));

            //学生管理
            menu.AddItem(new MenuItemDefinition(
                StudentAppPermissions.StudentManage,
                L(StudentAppPermissions.StudentManage),
                icon: "flaticon-interface-8"
            ));


            #endregion
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BiConsts.LocalizationSourceName);
        }
    }
}