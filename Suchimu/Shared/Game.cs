using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suchimu.Shared
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public double OriginalPrice { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Studio Studio { get; set; }
        public int StudioId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime LatestUpdate { get; set; } = DateTime.Now;
    }
}
