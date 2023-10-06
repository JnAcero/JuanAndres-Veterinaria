using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;

namespace Infrastructure.Repositories
{
    public class SalidaMedicamentoRepository : GenericRepo<SalidaMedicamento>, ISalidaMedicamento
    {
        public SalidaMedicamentoRepository(AplicationDbContext context) : base(context)
        {
        }
    }
}