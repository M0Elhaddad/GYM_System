using GYM_DAL;
using GYM_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_BLL
{
    public class PurchaseInvoiceRepository :GenericRepository<PurchaseInvoice>
    {
        public PurchaseInvoiceRepository(GYMDbContext dbContext) :base(dbContext)
        {
            
        }
    }
}
