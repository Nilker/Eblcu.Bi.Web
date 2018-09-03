using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Eblcu.Bi.Configuration.Host.Dto;
using Eblcu.Bi.Editions.Dto;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}