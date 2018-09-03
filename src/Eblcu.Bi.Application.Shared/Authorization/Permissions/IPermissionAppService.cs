using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Eblcu.Bi.Authorization.Permissions.Dto;

namespace Eblcu.Bi.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
