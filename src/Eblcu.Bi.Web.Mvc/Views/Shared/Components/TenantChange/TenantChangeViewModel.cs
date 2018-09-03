using Abp.AutoMapper;
using Eblcu.Bi.Sessions.Dto;

namespace Eblcu.Bi.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}