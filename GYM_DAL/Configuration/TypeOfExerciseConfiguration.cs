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
    internal class TypeOfExerciseConfiguration : IEntityTypeConfiguration<TypeOfExercise>
    {
        public void Configure(EntityTypeBuilder<TypeOfExercise> builder)
        {
            builder.Property(TE => TE.Type)
                .HasMaxLength(50);
            builder.Property(TE => TE.Price)
                .HasColumnType("decimal(9,2)");
            builder.HasMany(TE => TE.Trainees)
                .WithOne(T => T.TypeOfExercise)
                .HasForeignKey(T => T.TypeOfExerciseId);
        }
    }
}
