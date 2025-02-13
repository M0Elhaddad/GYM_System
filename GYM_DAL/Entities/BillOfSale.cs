using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Entities
{
    public class BillOfSale :BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public DateTime InsertionDate { get; set; }

        public ICollection<ProductBillDetails> BillProductDetails { get; set; } = new HashSet<ProductBillDetails>();
    }
}
