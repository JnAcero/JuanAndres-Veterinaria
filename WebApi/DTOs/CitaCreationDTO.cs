using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOs
{
    public class CitaCreationDTO
    {
        
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Motivo { get; set; } 
        public int ID_Veterinario { get; set; }
        public int ID_Mascota { get; set; }

    }
}