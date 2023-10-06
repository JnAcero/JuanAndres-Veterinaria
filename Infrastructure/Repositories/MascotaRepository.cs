using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MascotaRepository : GenericRepository<Mascota>, IMascota
    {
        public MascotaRepository(AplicationDbContext context) : base(context)
        {
        }
        public override async Task<(int totalRegistros, IEnumerable<Mascota> registros)> GetAllAsync(int pageIndex, int pageSize, string Search)
            {
                var query = _context.Mascotas.Include(m =>m.Especie) as IQueryable<Mascota>;
                if (!string.IsNullOrEmpty(Search))
                {
                    query = query.Where(t => t.Especie.Nombre.ToLower().Contains(Search.ToLower()) || t.Nombre.ToLower().Contains(Search));
                }
                var totalRegistros = await query.CountAsync();
                var registros = await query
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
                return (totalRegistros, registros);
            }

            public object MascotasVCacunadasPrimerTimestre2023()
            {
                var query = 
                    from mascota in _context.Mascotas
                    join cita in _context.Citas on mascota.Id equals cita.ID_Mascota
                    let InicioEnero2023 = new DateTime(2023,1,1)
                    let FinMarzo2023 = new DateTime(2023,3,30)
                    where cita.Motivo.Contains("vacunacion") && cita.Fecha > InicioEnero2023 && cita.Fecha < FinMarzo2023 
                    select mascota;

                 return query;
            }
    }
}