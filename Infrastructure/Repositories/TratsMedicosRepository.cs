using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;

namespace Infrastructure.Repositories
{
    public class TratsMedicosRepository : GenericRepository<TratamientoMedico>, ITrataminetoMedico
    {
        public TratsMedicosRepository(AplicationDbContext context) : base(context)
        {
        }
    }
}