using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suchimu.Shared
{
    public class InvoiceDetail
    {
        // InvoiceId
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        // GameId
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
