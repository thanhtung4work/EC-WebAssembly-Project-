using Microsoft.EntityFrameworkCore;
using Suchimu.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext _context;

        public StatsService(DataContext context)
        {
            _context = context;
        }
        public async Task<int> GetVisits()
        {
            var stats = await _context.Stats.FirstOrDefaultAsync();
            if(stats == null)
            {
                return 0;
            }
            return stats.Visits;
        }

        public async Task IncreaseVisits()
        {
            var stats = await _context.Stats.FirstOrDefaultAsync();
            if(stats == null)
            {
                _context.Stats.Add(new Shared.Stats { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stats.Visits++;
                stats.LastVisit = DateTime.Now;
            }
            await _context.SaveChangesAsync();
        }
    }
}
