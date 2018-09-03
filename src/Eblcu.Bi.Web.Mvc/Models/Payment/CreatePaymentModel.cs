﻿using Eblcu.Bi.Editions;
using Eblcu.Bi.MultiTenancy.Payments;

namespace Eblcu.Bi.Web.Models.Payment
{
    public class CreatePaymentModel
    {
        public int EditionId { get; set; }

        public PaymentPeriodType? PaymentPeriodType { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}
