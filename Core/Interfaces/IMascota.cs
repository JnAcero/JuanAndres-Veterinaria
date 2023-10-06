using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;

namespace Core.Interfaces
{
    public interface IMascota:IGenericRepository<Mascota>
    {
        object MascotasVCacunadasPrimerTimestre2023();
    }
}