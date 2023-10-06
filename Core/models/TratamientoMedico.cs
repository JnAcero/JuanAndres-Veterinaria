using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class TratamientoMedico:BaseEntity
    {
        public int ID_Cita { get; set; }
        [ForeignKey("ID_Cita")]
        public Cita Cita{ get; set; }
        public int ID_Medicamento { get; set; }
        [ForeignKey("ID_Medicamento")]
        public Medicamento Medicamento { get; set; }
        public decimal Dosis { get; set; }
        public DateTime FechaAdministracion { get; set; }
        public string Observacion { get; set; }

    }
}