using System.Threading.Tasks;
using Eblcu.Bi.ApiClient.Models;

namespace Eblcu.Bi.ApiClient
{
    public interface IAccessTokenManager
    {
        Task<string> GetAccessTokenAsync();
         
        Task<AbpAuthenticateResultModel> LoginAsync();

        void Logout();

        bool IsUserLoggedIn { get; }
    }
}