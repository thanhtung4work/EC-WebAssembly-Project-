using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Suchimu.Server.Data;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
         
        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            // Console.WriteLine(categoryUrl);
            return await _context.Categories.FirstOrDefaultAsync(cat => cat.Url.ToLower().Equals(categoryUrl.ToLower()));
            // return Categories[0];
        }
    }
}
