using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IUsuario Usuarios { get; }
        IRol Roles { get; }
        IUsuarioRol UsuariosRoles { get; }
        ICita Citas { get; }
        IMascota Mascotas { get; }
        IVeterinario Veterinarios{ get; }
        IPropietario Propietarios { get; }
        IEspecie Especies  { get; }
        IRaza Razas { get; }
        ITrataminetoMedico TratamientostoMedicos { get; }
        IMedicamento Medicamentos { get; }
        ILaboratorio Laboratorios { get; }
        IProveedor Proveedores { get; }
        ISalidaMedicamento SalidasMedicamento { get; }
        IEntradaMedicamento EntradasMedicamentos {  get; }
        Task<int> SaveAsync();
        
    }
}