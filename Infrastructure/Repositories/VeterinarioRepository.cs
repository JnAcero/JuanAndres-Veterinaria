using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class VeterinarioRepository : GenericRepository<Veterinario>, IVeterinario
    {
        public VeterinarioRepository(AplicationDbContext context) : base(context)
        {
        }
        public override async Task<(int totalRegistros, IEnumerable<Veterinario> registros)> GetAllAsync(int pageIndex, int pageSize, string Search)
            {
                var query = _context.Veterinarios as IQueryable<Veterinario>;
                if (!string.IsNullOrEmpty(Search))
                {
                    query = query.Where(t => t.Especialidad.ToLower().Contains(Search.ToLower()));
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