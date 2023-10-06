using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class EntradaMedicamento
    {
        [Key]
        public int ID_Entrada { get; set; }
        public int ID_Medicamento { get; set; }
        [ForeignKey("ID_Medicamento")]
        public Medicamento Medicamento { get; set; }
        public int Cantidad { get; set; }
        public float PrecioCompra {   get; set; }
        public DateTime FechaEntrada { get; set; }
        
    }
}