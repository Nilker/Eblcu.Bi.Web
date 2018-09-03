using Abp.Configuration;

namespace Eblcu.Bi.Timing.Dto
{
    public class GetTimezoneComboboxItemsInput
    {
        public SettingScopes DefaultTimezoneScope;

        public string SelectedTimezoneId { get; set; }
    }
}
