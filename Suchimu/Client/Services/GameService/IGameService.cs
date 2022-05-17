using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.GameService
{
    public interface IGameService
    {
        event Action OnChange;
        List<Game> Games { get; set; }
        public Task LoadGames(string categoryUrl = null);
        public Task<Game> GetGame(int id);
        Task LoadGameByStudio(string studioUrl);
        Task<List<Game>> SearchGame(string searchText);
    }
}
