using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Eblcu.Bi.Configuration.Tenants.Dto;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}