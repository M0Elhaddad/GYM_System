using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Entities
{
    public class PurchaseInvoice:BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public ICollection<productPurchaseDetails> PurchaseproductDetails { get; set; } = new HashSet<productPurchaseDetails>();
    }
}
