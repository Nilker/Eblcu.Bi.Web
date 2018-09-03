using System.Threading.Tasks;
using Abp.Application.Services;
using Eblcu.Bi.Sessions.Dto;

namespace Eblcu.Bi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
