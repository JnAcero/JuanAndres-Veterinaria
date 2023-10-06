using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Medicamento : BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public int CantidadDisponible { get; set; }
        public float Precio { get; set; }
        public int ID_Laboratorio { get; set; }
        [ForeignKey("ID_Laboratorio")]
        public Laboratorio Laboratorio { get; set; }
        public ICollection<TratamientoMedico> TratamientosMedicos { get; set; } = new List<TratamientoMedico>();
        public ICollection<EntradaMedicamento> EntradasMedicamento { get; set; } = new List<EntradaMedicamento>();
        public ICollection<SalidaMedicamento> SalidasMedicamento { get; set; } = new List<SalidaMedicamento>();
          public ICollection<MedicamentoPoveedor> MedicamentosProveedores { get; set; } = new List<MedicamentoPoveedor>();

    }
}