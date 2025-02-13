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
    internal class TypeOfSubscriptionConfiguration : IEntityTypeConfiguration<TypeOfSubscription>
    {
        public void Configure(EntityTypeBuilder<TypeOfSubscription> builder)
        {
            builder.Property(TS => TS.Type)
                .HasMaxLength(50);
            builder.HasMany(TS => TS.Trainees)
                .WithOne(T => T.TypeOfSubscription)
                .HasForeignKey(T => T.TypeOfSubscriptionId);
        }
    }
}
