using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suchimu.Server.Services.GameService;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Game>>> GetAllGame()
        {
            return Ok(await _gameService.GetAllGames());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Game>>> GetGameByCategory(string categoryUrl)
        {
            return Ok(await _gameService.GetGamesByCategory(categoryUrl));
        }

        [HttpGet("Studio/{studioUrl}")]
        public async Task<ActionResult<List<Game>>> GetGameByStudio(string studioUrl)
        {
            return Ok(await _gameService.GetGamesByStudio(studioUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Game>>> GetGame(int id)
        {
            return Ok(await _gameService.GetGame(id));
        }

        [HttpGet("Search/{searchText}")]
        public async Task<ActionResult<List<Game>>> SearchGame(string searchText)
        {
            return Ok(await _gameService.SearchGame(searchText));
        }
    }
}
