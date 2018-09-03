using System.Collections.Generic;
using Eblcu.Bi.Authorization.Users.Dto;
using Eblcu.Bi.Dto;

namespace Eblcu.Bi.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}