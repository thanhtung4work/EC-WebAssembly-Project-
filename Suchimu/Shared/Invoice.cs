using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suchimu.Shared
{
    public class Invoice
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
        public int[] InvoiceDetailId { get; set; }
        public double Total { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
