using System.Threading.Tasks;
using Abp.Application.Services;
using Eblcu.Bi.Install.Dto;

namespace Eblcu.Bi.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}