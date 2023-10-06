using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.models;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private UsuarioRepository _usuarios;
        private RolRepository _roles;
        private CitaRepository _citas;
        private MascotaRepository _mascotas;
        private VeterinarioRepository _veterinarios;
        private PropietarioRepository _propietarios;
        private EspecieRepository _especies;
        private RazaRepository _razas;
        private TratsMedicosRepository _tratsMedicos;
        private MedicamentoRepository _medicamentos;
        private LaboratorioRepository _laboratorios;
        private ProveedorRepository _proveedores;
        private EntradaMedicamentoRepository _entradaMedicamentos;
        private SalidaMedicamentoRepository _salidaMedicamentos;
         

        private readonly AplicationDbContext _context;
        public UnitOfWork( AplicationDbContext context)
        {
            _context = context;
        }

        public IUsuario Usuarios
        {
            get
            {
                _usuarios ??= new UsuarioRepository(_context);
                return _usuarios;
            }

        }

        public IRol Roles
        {
            get
            {
                _roles ??= new RolRepository(_context);
                return _roles;
            }
        }

        public IUsuarioRol UsuariosRoles => throw new NotImplementedException();

        public ICita Citas {
            get
            {
                _citas ??= new CitaRepository(_context);
                return _citas;
            }
        }

        public IMascota Mascotas {
            get
            {
                _mascotas ??= new MascotaRepository(_context);
                return _mascotas;
            }
        }

        public IVeterinario Veterinarios  {
            get
            {
                _veterinarios ??= new VeterinarioRepository(_context);
                return _veterinarios;
            }
        }

        public IPropietario Propietarios  {
            get
            {
                _propietarios ??= new PropietarioRepository(_context);
                return _propietarios;
            }
        }

        public IEspecie Especies {
            get
            {
                _especies ??= new EspecieRepository(_context);
                return _especies;
            }
        }

        public IRaza Razas  {
            get
            {
                _razas ??= new RazaRepository(_context);
                return _razas;
            }
        }
        public ITrataminetoMedico TratamientostoMedicos {
            get
            {
                _tratsMedicos ??= new TratsMedicosRepository(_context);
                return _tratsMedicos;
            }
        }
        public IMedicamento Medicamentos {
            get
            {
                _medicamentos ??= new MedicamentoRepository(_context);
                return _medicamentos;
            }
        }

        public ILaboratorio Laboratorios  {
            get
            {
                _laboratorios ??= new LaboratorioRepository(_context);
                return _laboratorios;
            }
        }

        public IProveedor Proveedores  {
            get
            {
                _proveedores ??= new ProveedorRepository(_context);
                return _proveedores;
            }
        }

        public ISalidaMedicamento SalidasMedicamento  {
            get
            {
                _salidaMedicamentos ??= new SalidaMedicamentoRepository(_context);
                return _salidaMedicamentos;
            }
        }

        public IEntradaMedicamento EntradasMedicamentos  {
            get
            {
                _entradaMedicamentos ??= new EntradaMedicamentoRepository(_context);
                return _entradaMedicamentos;
            }
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}