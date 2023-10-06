using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class SalidaMedicamento
    {
        [Key]
        public int ID_Salida { get; set; }
        public int ID_Medicamento { get; set; }
        [ForeignKey("ID_Medicamento")]
        public Medicamento Medicamento { get; set; }
        public int Cantidad { get; set; }
        public float PrecioVenta {   get; set; }
        public DateTime FechaSalida { get; set; }

    }
}