using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DTOs
{
    public class TratMedicoCreationDTO
    {
        public int ID_Cita { get; set; }

        public int ID_Medicamento { get; set; }

        public decimal Dosis { get; set; }
        public DateTime FechaAdministracion { get; set; }
        public string Observacion { get; set; }

    }
}