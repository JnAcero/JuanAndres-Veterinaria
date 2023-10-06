using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class LaboratorioConfiguration : IEntityTypeConfiguration<Laboratorio>
    {
        public void Configure(EntityTypeBuilder<Laboratorio> builder)
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