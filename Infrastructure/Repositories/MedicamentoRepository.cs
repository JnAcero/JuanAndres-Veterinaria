using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MedicamentoRepository : GenericRepository<Medicamento>, IMedicamento
    {
        public MedicamentoRepository(AplicationDbContext context) : base(context)
        {
        }
        public override async Task<(int totalRegistros, IEnumerable<Medicamento> registros)> GetAllAsync(int pageIndex, int pageSize, string Search)
            {
                var query = _context.Medicamentos.Include(m =>m.Laboratorio) as IQueryable<Medicamento>;
                if (!string.IsNullOrEmpty(Search))
                {
                    query = query.Where(t => t.Laboratorio.Nombre.ToLower().Contains(Search.ToLower()) || t.Nombre.ToLower().Contains(Search));
                }
                var totalRegistros = await query.CountAsync();
                var registros = await query
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
                return (totalRegistros, registros);
            }
    }
}