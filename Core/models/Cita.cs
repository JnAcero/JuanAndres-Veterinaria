using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Cita:BaseEntity
    {
        public int ID_Mascota { get; set; }
        [ForeignKey("ID_Mascota")]
        public Mascota Mascota { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Motivo { get; set; }
        public int ID_Veterinario { get; set; }
        [ForeignKey("ID_Veterinario")]
        public Veterinario Veterinario { get; set; }
        public ICollection<TratamientoMedico> TratamientosMedicos {get; set ;} = new List<TratamientoMedico>(); 
      
    }
}