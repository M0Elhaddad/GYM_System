using GYM_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Configuration
{
    internal class PurchaseInvoiceConfiguration : IEntityTypeConfiguration<PurchaseInvoice>
    {
        public void Configure(EntityTypeBuilder<PurchaseInvoice> builder)
        {
            builder.Property(PI => PI.TotalPrice)
                .HasColumnType("decimal(9,2)");
            builder.Property(PI => PI.Date)
                .HasComputedColumnSql("GETDATE()");
                
        }
    }
}
