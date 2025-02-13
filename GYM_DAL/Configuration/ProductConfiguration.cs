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
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(P => P.Name)
                .HasMaxLength(50);
            builder.Property(P => P.PurchasePrice)
                .HasColumnType("decimal(9,2)");
            builder.Property(P=>P.Name)
                .HasMaxLength (50);
            builder.Property(P => P.unitPrice)
                .HasColumnType("decimal(9,2)");
        }
    }
}
