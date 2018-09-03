using System.Threading.Tasks;
using Abp.Application.Services;

namespace Eblcu.Bi.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
