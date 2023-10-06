using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.Property(x =>x.Nombre).HasMaxLength(50)
            .IsRequired();
             builder.Property(x =>x.Precio).HasPrecision(12,3)
            .IsRequired();
                    

            
        }
    }
}