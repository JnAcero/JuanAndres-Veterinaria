using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MedicamentoProveedorConfiguration : IEntityTypeConfiguration<MedicamentoPoveedor>
    {
        public void Configure(EntityTypeBuilder<MedicamentoPoveedor> builder)
        {
            builder.HasKey(x =>new{x.ID_Proveedor,x.ID_Medicamento});
        }
    }
}