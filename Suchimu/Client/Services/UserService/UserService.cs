using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task RegisterUser(UserAccount account)
        {
            await _http.PostAsJsonAsync("api/User", account);
        }
    }
}
