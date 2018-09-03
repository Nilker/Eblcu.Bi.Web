using Abp.AutoMapper;
using Eblcu.Bi.MultiTenancy.Dto;

namespace Eblcu.Bi.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}