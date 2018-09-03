using Abp.AutoMapper;
using Eblcu.Bi.MultiTenancy;
using Eblcu.Bi.MultiTenancy.Dto;
using Eblcu.Bi.Web.Areas.AppAreaName.Models.Common;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}