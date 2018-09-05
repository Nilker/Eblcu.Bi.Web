using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Eblcu.Bi.Authorization.Permissions.Dto;
using Eblcu.Bi.Authorization.Users.Dto;
using Eblcu.Bi.Dto;

namespace Eblcu.Bi.Authorization.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<PagedResultDto<UserListDto>> GetUsers(GetUsersInput input);

        Task<FileDto> GetUsersToExcel();

        Task<GetUserForEditOutput> GetUserForEdit(NullableIdDto<long> input);

        Task<GetUserPermissionsForEditOutput> GetUserPermissionsForEdit(EntityDto<long> input);

        Task ResetUserSpecificPermissions(EntityDto<long> input);

        Task UpdateUserPermissions(UpdateUserPermissionsInput input);

        Task CreateOrUpdateUser(CreateOrUpdateUserInput input);

        Task DeleteUser(EntityDto<long> input);

        Task UnlockUser(EntityDto<long> input);

        Task<ResultJsonObj> GetUserGrantedPermissions(EntityDto<long> input);

        Task<List<FlatPermissionDto>> GeCurrentUserGrantedPermissions();

        /// <summary>
        /// 获取用户现有的权限-----目录
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ResultJsonObj> GetUserGrantedPermissions_Parent(EntityDto<long> input);

        /// <summary>
        /// 获取用户现有的权限-----列表
        /// </summary>
        /// <param name="input"></param>
        /// <param name="parentName"></param>
        /// <returns></returns>
        Task<ResultJsonObj> GetUserGrantedPermissions_Child(EntityDto<long> input, string parentName);
    }
}