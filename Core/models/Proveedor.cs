using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Proveedor:BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public ICollection<MedicamentoPoveedor> MedicamentosProveedores { get; set; } = new List<MedicamentoPoveedor>();
        
    }
}