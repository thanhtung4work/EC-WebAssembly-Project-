using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private HttpClient _http;
        private ILocalStorageService _localStorage;

        public StatsService(HttpClient http, ILocalStorageService localStorage)
        {
            _http = http;
            _localStorage = localStorage;
        }

        public async Task<int> GetVisits()
        {
            int visits = int.Parse(await _http.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");
            return visits;
        }

        public async Task IncreaseVisits()
        {
            DateTime? lastVisits = await _localStorage.GetItemAsync<DateTime?>("lastVisit");
            if(lastVisits == null || ((DateTime)lastVisits).Ticks != DateTime.Now.Ticks)
            {
                await _localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await _http.PostAsync("api/Stats", null);
            }
        }
    }
}
