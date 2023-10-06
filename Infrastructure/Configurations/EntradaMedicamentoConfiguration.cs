using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class EntradaMedicamentoConfiguration : IEntityTypeConfiguration<EntradaMedicamento>
    {
        public void Configure(EntityTypeBuilder<EntradaMedicamento> builder)
        {
            builder.Property(x =>x.PrecioCompra).HasPrecision(12,3).IsRequired();

            builder.Property(x =>x.Cantidad).IsRequired();
            builder.Property(x =>x.FechaEntrada)
            .HasColumnType("date")
            .IsRequired();
        }
    }
}