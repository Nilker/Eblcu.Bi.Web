using Abp.Application.Services;
using Eblcu.Bi.Dto;
using Eblcu.Bi.Logging.Dto;

namespace Eblcu.Bi.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
