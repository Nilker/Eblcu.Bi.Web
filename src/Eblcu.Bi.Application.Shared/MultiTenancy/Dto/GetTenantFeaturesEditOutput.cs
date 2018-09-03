using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Eblcu.Bi.Editions.Dto;

namespace Eblcu.Bi.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}