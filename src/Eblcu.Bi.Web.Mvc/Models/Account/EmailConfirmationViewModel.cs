using Eblcu.Bi.Authorization.Accounts.Dto;

namespace Eblcu.Bi.Web.Models.Account
{
    public class EmailConfirmationViewModel : ActivateEmailInput
    {
        /// <summary>
        /// Tenant id.
        /// </summary>
        public int? TenantId { get; set; }
    }
}