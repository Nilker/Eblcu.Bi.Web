using System.Threading.Tasks;
using Abp.Application.Services;
using Eblcu.Bi.Configuration.Tenants.Dto;

namespace Eblcu.Bi.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
