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
    internal class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(A => A.Password)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(A => A.Email)
                .HasMaxLength(50)
                .IsRequired();
            builder.HasIndex(A => A.Email).IsUnique();
        }
    }
}
