using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOs
{
    public class LaboratorioCrteationDTO
    {
         public string Nombre { get; set; }=null!;
        public string Direccion { get; set; } =null!;
        public string Telefono { get; set; }=null!;
    }
}