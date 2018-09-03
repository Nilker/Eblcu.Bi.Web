using System.Collections.Generic;
using Eblcu.Bi.Authorization.Users.Dto;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}