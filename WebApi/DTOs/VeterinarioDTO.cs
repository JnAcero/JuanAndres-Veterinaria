using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOs
{
    public class VeterinarioDTO
    {
        public int Id { get; set;}
         public string Nombre { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string  Telefono { get; set; } = null!;
        public string Especialidad { get; set; } = null!;
    }
}