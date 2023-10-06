using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PropietarioRepository : GenericRepository<Propietario>, IPropietario
    {
        public PropietarioRepository(AplicationDbContext context) : base(context)
        {
        }
        public async Task<object> GetPropietariosYMascotas()
        {
            return await  _context.Propietarios
            .Select(x => new 
            {
                x.Id,
                x.Nombre,
                x.Telefono,
                x.CorreoElectronico,
                Mascotas = x.Mascotas.Select(m =>new {m.Id,m.Nombre,Raza =m.Raza.Nombre }).ToList()

            })
            .ToListAsync();
        }
    }
}