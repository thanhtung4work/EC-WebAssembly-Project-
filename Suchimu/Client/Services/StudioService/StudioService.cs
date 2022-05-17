using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.StudioService
{
    public class StudioService : IStudioService
    {
        private readonly HttpClient _http;

        public List<Studio> Studios { get; set; } = new List<Studio>();
        public StudioService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadStudios()
        {
            Studios = await _http.GetFromJsonAsync<List<Studio>>("api/Studio");
        }
    }
}
