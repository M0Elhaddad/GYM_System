using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Entities
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public int QuantityStock { get; set; }
        public decimal unitPrice { get; set; }
        public ICollection<productPurchaseDetails> ProductPurchaseDetails { get; set; } =new HashSet<productPurchaseDetails>();
        public ICollection<ProductBillDetails> ProductBillDetails { get; set; } =new HashSet<ProductBillDetails>();
    }
}
