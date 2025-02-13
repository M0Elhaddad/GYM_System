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
    internal class BillOfSaleConfiguration : IEntityTypeConfiguration<BillOfSale>
    {
        public void Configure(EntityTypeBuilder<BillOfSale> builder)
        {
            builder.Property(B => B.TotalPrice)
                .HasColumnType("decimal(9,2)");

            builder.Property(B => B.InsertionDate)
                .HasComputedColumnSql("GETDATE()");
        }
    }
}
