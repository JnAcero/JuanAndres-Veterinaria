using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Especie:BaseEntity
    {
        public string Nombre { get; set; } = null!;
         public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
          public ICollection<Raza> Razas { get; set; } = new List<Raza>();
        
    }
}