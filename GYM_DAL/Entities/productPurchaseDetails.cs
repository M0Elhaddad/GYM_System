using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Entities
{
    public class productPurchaseDetails:BaseEntity
    {
        public int ProductId { get; set; }
        public int PurchaseInvoiceId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public PurchaseInvoice PurchaseInvoice { get; set; }
    }
}
