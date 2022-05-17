using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Client.Services.StudioService
{
    public interface IStudioService
    {
        List<Studio> Studios { get; set; }
        public Task LoadStudios();
    }
}
