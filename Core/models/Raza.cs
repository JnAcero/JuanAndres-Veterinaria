using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Raza : BaseEntity
    {
        public int ID_Especie { get; set; }
        [ForeignKey("ID_Especie")]
        public Especie Especie { get; set; }
        public string Nombre { get; set; } = null!;
         public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
        
    }
}