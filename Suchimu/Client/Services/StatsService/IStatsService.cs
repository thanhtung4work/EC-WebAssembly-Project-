using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.StatsService
{
    interface IStatsService
    {
        Task<int> GetVisits();
        Task IncreaseVisits();
    }
}
