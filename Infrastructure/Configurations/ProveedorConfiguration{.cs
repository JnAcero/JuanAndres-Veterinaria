using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.Property(v =>v.Nombre)
            .HasMaxLength(50)
            .IsRequired();
            builder.Property(v =>v.Telefono).HasMaxLength(50)
            .IsRequired();

             builder.Property(v =>v.Direccion).HasMaxLength(100)
            .IsRequired();
        }
    }
}