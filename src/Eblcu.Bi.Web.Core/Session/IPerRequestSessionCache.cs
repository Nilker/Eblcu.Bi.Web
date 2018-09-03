using System.Threading.Tasks;
using Eblcu.Bi.Sessions.Dto;

namespace Eblcu.Bi.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
