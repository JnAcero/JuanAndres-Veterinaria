using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOs
{
    public class MedicamentoCreationDTO
    {
        public string Nombre { get; set; } = null!;
        public int CantidadDisponible { get; set; }
        public float Precio { get; set; }
        public int ID_Laboratorio { get; set; }
    }
}