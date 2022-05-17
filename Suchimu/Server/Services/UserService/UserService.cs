using Suchimu.Server.Data;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task ResgisterUser(UserAccount account)
        {
            _context.Users.Add(account);
            await _context.SaveChangesAsync();
        }
    }
}
