using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Mascota : BaseEntity
    {
        public int ID_Propietario { get; set; }
        [ForeignKey("ID_Propietario")]
        public Propietario Propietario { get; set; }
        public int ID_Especie { get; set; }
        [ForeignKey("ID_Especie")]
        public Especie Especie { get; set; }
        public int ID_Raza { get; set; }
        [ForeignKey("ID_Raza")]
        public Raza Raza { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}