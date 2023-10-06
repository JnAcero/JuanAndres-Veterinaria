using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;

namespace Infrastructure.Repositories
{
    public class EspecieRepository : GenericRepository<Especie>, IEspecie
    {
        public EspecieRepository(AplicationDbContext context) : base(context)
        {
        }
    }
}