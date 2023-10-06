using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOs
{
    public class MascotaCreationDTO
    {
        public string Nombre { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public int ID_Propietario { get; set; }
        public int ID_Especie { get; set; }
        public int ID_Raza { get; set; }

    }
}