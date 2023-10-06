using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class SalidaMedicamentoConfiguration : IEntityTypeConfiguration<SalidaMedicamento>
    {
        public void Configure(EntityTypeBuilder<SalidaMedicamento> builder)
        {
             builder.Property(x =>x.PrecioVenta).HasPrecision(12,3).IsRequired();

            builder.Property(x =>x.Cantidad).IsRequired();
            builder.Property(x =>x.FechaSalida)
            .HasColumnType("date")
            .IsRequired();
        }
    }
}