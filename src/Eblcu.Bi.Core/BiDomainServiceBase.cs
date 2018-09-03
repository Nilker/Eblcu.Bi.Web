using Abp.Domain.Services;

namespace Eblcu.Bi
{
    public abstract class BiDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected BiDomainServiceBase()
        {
            LocalizationSourceName = BiConsts.LocalizationSourceName;
        }
    }
}
