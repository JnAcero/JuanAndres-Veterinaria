using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class MedicamentoPoveedor
    {
        public int ID_Proveedor { get; set; }
        [ForeignKey("ID_Proveedor")]
        public Proveedor Proveedor { get; set; }
        public int ID_Medicamento { get; set; }
        [ForeignKey("ID_Medicamento")]
        public Medicamento Medicamento { get; set; }

    }
}