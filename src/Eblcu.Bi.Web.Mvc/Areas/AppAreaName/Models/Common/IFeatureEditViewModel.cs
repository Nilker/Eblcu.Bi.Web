using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Eblcu.Bi.Editions.Dto;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}