using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;

namespace Infrastructure.Repositories
{
    public class CitaRepository : GenericRepository<Cita>, ICita
    {
        public CitaRepository(AplicationDbContext context) : base(context)
        {
        }
    }
}