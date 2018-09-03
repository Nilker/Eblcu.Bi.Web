using Abp.Web.Models.AbpUserConfiguration;
using JetBrains.Annotations;
using Eblcu.Bi.Sessions.Dto;

namespace Eblcu.Bi.ApiClient
{
    public interface IApplicationContext
    {
        [CanBeNull]
        TenantInformation CurrentTenant { get; }

        AbpUserConfigurationDto Configuration { get; set; }

        GetCurrentLoginInformationsOutput LoginInfo { get; set; }

        void SetAsHost();

        void SetAsTenant(string tenancyName, int tenantId);
    }
}