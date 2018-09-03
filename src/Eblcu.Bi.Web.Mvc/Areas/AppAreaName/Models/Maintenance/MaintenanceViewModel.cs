using System.Collections.Generic;
using Eblcu.Bi.Caching.Dto;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}