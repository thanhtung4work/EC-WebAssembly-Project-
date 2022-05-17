using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.UserService
{
    public interface IUserService
    {
        Task ResgisterUser(UserAccount acount);
    }
}
