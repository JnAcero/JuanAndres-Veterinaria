using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class PropoietarioConfiguration : IEntityTypeConfiguration<Propietario>
    {
        public void Configure(EntityTypeBuilder<Propietario> builder)
        {
             builder.HasOne(v =>v.Usuario)
                .WithOne();
            builder.Property(v =>v.Nombre)
            .HasMaxLength(50)
            .IsRequired();
            builder.Property(v =>v.Telefono).HasMaxLength(50)
            .IsRequired();

             builder.Property(v =>v.CorreoElectronico).HasMaxLength(100)
            .IsRequired();
        }
    }
}