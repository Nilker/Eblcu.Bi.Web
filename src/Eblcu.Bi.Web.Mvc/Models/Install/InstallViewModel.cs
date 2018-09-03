using System.Collections.Generic;
using Abp.Localization;
using Eblcu.Bi.Install.Dto;

namespace Eblcu.Bi.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
