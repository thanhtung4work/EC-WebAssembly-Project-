﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suchimu.Server.Services.StatsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _statsService;

        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statsService.GetVisits();
        }

        [HttpPost]
        public async Task IncreaseVisits()
        {
            await _statsService.IncreaseVisits();
        }
    }
}
