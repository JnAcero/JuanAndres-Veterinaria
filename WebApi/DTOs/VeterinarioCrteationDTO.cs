using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOs
{
    public class VeterinarioCrteationDTO
    {
         public string Nombre { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string  Telefono { get; set; } = null!;
        public string Especialidad { get; set; } = null!;
        public int ID_Usuario { get; set; } 
    }
}