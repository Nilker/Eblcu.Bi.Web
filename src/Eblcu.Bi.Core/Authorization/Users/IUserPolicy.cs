using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Eblcu.Bi.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
