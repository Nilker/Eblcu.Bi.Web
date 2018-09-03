using Eblcu.Bi.Editions;
using Eblcu.Bi.Editions.Dto;
using Eblcu.Bi.Security;
using Eblcu.Bi.MultiTenancy.Payments;
using Eblcu.Bi.MultiTenancy.Payments.Dto;

namespace Eblcu.Bi.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType? Gateway { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public bool ShowPaymentExpireNotification()
        {
            return !string.IsNullOrEmpty(PaymentId);
        }
    }
}
