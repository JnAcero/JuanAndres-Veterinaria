using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Laboratorio:BaseEntity
    {
        public string Nombre { get; set; }=null!;
        public string Direccion { get; set; } =null!;
        public string Telefono { get; set; }=null!;
        public ICollection<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();
    }
}