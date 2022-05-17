using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suchimu.Shared
{
    public class CartItem
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
