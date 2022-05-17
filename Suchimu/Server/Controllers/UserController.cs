using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suchimu.Server.Services.UserService;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task ResgisterUser(UserAccount account)
        {
            await _userService.ResgisterUser(account);
        }
    }
}
