using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly HttpClient _http;
        public List<Game> Games { get; set; } = new List<Game>();
        public event Action OnChange;
        public GameService(HttpClient httpClient)
        {
            _http = httpClient;
        }
        

        public async Task LoadGames(string categoryUrl = null)
        {
            if(categoryUrl == null)
            {
                Games = await _http.GetFromJsonAsync<List<Game>>($"api/Game");
            }
            else
            {
                Games = await _http.GetFromJsonAsync<List<Game>>($"api/Game/Category/{categoryUrl}");
            }
            OnChange.Invoke();
        }

        public async Task LoadGameByStudio(string studioUrl)
        {
            Games = await _http.GetFromJsonAsync<List<Game>>($"api/Game/Studio/{studioUrl}");
            OnChange.Invoke();
        }

        public async Task<Game> GetGame(int id)
        {
            return await _http.GetFromJsonAsync<Game>($"api/Game/{id}");
        }

        public async Task<List<Game>> SearchGame(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Game>>($"api/Game/Search/{searchText}");
        }
    }
}
