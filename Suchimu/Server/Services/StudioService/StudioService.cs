using Microsoft.EntityFrameworkCore;
using Suchimu.Server.Data;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.StudioService
{
    public class StudioService : IStudioService
    {
        private readonly DataContext _context;

        public StudioService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Studio>> GetAllStudios()
        {
            return await _context.Studios.ToListAsync();
        }

        public async Task<Studio> GetStudioByName(string name)
        {
            name = name.ToLower();
            return await _context.Studios.FirstOrDefaultAsync(studio => studio.Name.ToLower().Equals(name));
        }
        public async Task<Studio> GetStudioByUrl(string url)
        {
            url = url.ToLower();
            return await _context.Studios.FirstOrDefaultAsync(studio => studio.Url.ToLower().Equals(url));
        }
    }
}
