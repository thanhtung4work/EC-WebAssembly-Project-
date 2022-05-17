using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suchimu.Server.Services.StudioService;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudioController : ControllerBase
    {
        
        private readonly IStudioService _studioService;
        public StudioController(IStudioService studioService)
        {
            _studioService = studioService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Studio>>> GetCategories()
        {
            return Ok(await _studioService.GetAllStudios());
        }
    }
}
