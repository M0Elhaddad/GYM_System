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
    internal class productPurchaseDetailsConfiguration : IEntityTypeConfiguration<productPurchaseDetails>
    {
        public void Configure(EntityTypeBuilder<productPurchaseDetails> builder)
        {
            builder.HasOne(PP => PP.Product)
                 .WithMany(P => P.ProductPurchaseDetails)
                 .HasForeignKey(P => P.ProductId);
            builder.HasOne(PP => PP.PurchaseInvoice)
                .WithMany(P => P.PurchaseproductDetails)
                .HasForeignKey(PP => PP.PurchaseInvoiceId);



        }
    }
}
