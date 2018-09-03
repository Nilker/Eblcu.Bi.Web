using System.ComponentModel.DataAnnotations;

namespace Eblcu.Bi.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}