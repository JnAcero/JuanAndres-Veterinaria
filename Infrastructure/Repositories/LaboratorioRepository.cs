using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;

namespace Infrastructure.Repositories
{
    public class LaboratorioRepository : GenericRepository<Laboratorio>, ILaboratorio
    {
        public LaboratorioRepository(AplicationDbContext context) : base(context)
        {
        }
    }
}