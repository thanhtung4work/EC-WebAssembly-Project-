using Microsoft.EntityFrameworkCore;
using Suchimu.Server.Data;
using Suchimu.Server.Services.CategoryService;
using Suchimu.Server.Services.StudioService;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly ICategoryService _categoryService;
        private readonly IStudioService _studioService;
        private readonly DataContext _context;

        public GameService(ICategoryService categoryService, IStudioService studioService, DataContext context)
        {
            _categoryService = categoryService;
            _studioService = studioService;
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> GetGame(int id)
        {
            return await _context.Games.FirstOrDefaultAsync(game => game.Id == id);
        }

        public async Task<List<Game>> GetGamesByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Games.Where(game => game.CategoryId == category.Id).ToListAsync();
        }

        public async Task<List<Game>> GetGamesByStudio(string studioUrl)
        {
            Studio studio = await _studioService.GetStudioByUrl(studioUrl);
            return await _context.Games.Where(game => game.StudioId == studio.Id).ToListAsync();
        }

        public async Task<List<Game>> SearchGame(string searchText)
        {
            return await _context.Games
                .Where(g => g.Title.Contains(searchText) || g.Description.Contains(searchText))
                .ToListAsync();
        }
    }
}
