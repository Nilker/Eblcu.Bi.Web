using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eblcu.Bi.MultiTenancy.HostDashboard.Dto;

namespace Eblcu.Bi.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}