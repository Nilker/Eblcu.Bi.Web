using Abp.AutoMapper;
using Eblcu.Bi.Editions;
using Eblcu.Bi.MultiTenancy.Payments.Dto;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}