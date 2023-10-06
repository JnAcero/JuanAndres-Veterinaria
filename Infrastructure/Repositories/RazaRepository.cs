using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;

namespace Infrastructure.Repositories
{
    public class RazaRepository : GenericRepository<Raza>, IRaza
    {
        public RazaRepository(AplicationDbContext context) : base(context)
        {
        }
    }
}