using System.Threading.Tasks;
using Abp.Application.Services;
using Eblcu.Bi.Editions.Dto;
using Eblcu.Bi.MultiTenancy.Dto;

namespace Eblcu.Bi.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}