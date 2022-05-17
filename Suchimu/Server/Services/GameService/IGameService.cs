using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.GameService
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<List<Game>> GetGamesByCategory(string categoryUrl);
        Task<Game> GetGame(int id);
        Task<List<Game>> GetGamesByStudio(string studioUrl);
        Task<List<Game>> SearchGame(string searchText);
    }
}
