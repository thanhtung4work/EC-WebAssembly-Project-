using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.UserService
{
    interface IUserService
    {
        Task RegisterUser(UserAccount account);
    }
}
