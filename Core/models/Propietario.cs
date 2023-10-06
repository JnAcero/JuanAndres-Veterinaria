using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Propietario:BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
        public int ? ID_Usuario { get; set; } 
        [ForeignKey("ID_Usuario")]
        public  Usuario Usuario { get; set; }
        
    }
}