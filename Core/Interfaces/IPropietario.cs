using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;

namespace Core.Interfaces
{
    public interface IPropietario:IGenericRepository<Propietario>
    {
         Task<object> GetPropietariosYMascotas();
        
    }
}