﻿using System.ComponentModel.DataAnnotations;

namespace Eblcu.Bi.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}