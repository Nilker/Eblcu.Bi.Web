using System.Threading.Tasks;
using Abp.Application.Services;
using Eblcu.Bi.Configuration.Host.Dto;

namespace Eblcu.Bi.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
