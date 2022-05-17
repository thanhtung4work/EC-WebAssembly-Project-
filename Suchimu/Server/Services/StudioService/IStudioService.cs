using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.StudioService
{
    public interface IStudioService 
    {
        Task<List<Studio>> GetAllStudios();
        Task<Studio> GetStudioByName(string name);
        Task<Studio> GetStudioByUrl(string url);
    }
}
