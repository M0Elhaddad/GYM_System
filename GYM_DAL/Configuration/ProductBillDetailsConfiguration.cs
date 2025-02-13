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
    internal class ProductBillDetailsConfiguration : IEntityTypeConfiguration<ProductBillDetails>
    {
        public void Configure(EntityTypeBuilder<ProductBillDetails> builder)
        {
            builder.HasOne(PB => PB.Product)
                .WithMany(P => P.ProductBillDetails)
                .HasForeignKey(P => P.ProductId);
            builder.HasOne(PB => PB.BillOfSale)
                .WithMany(B => B.BillProductDetails)
                .HasForeignKey(B => B.BillInvoiceId);
            builder.HasKey(B => new {B.ProductId, B.BillInvoiceId});
        }
    }
}
