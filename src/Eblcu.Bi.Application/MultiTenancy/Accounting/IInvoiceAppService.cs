using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Eblcu.Bi.MultiTenancy.Accounting.Dto;

namespace Eblcu.Bi.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
