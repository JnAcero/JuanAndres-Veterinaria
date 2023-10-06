
using System.Reflection;
using Core.models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions options) :base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<UsuarioRol> UsuariosRoles => Set<UsuarioRol>();
        public DbSet<Rol> Roles => Set<Rol>();
        public DbSet<Cita> Citas => Set<Cita>();
        public DbSet<Mascota> Mascotas => Set<Mascota>();
        public DbSet<Veterinario> Veterinarios => Set<Veterinario>();
        public DbSet<Propietario> Propietarios => Set<Propietario>();
        public DbSet<Especie> Especies => Set<Especie>();
        public DbSet<Raza> Razas => Set<Raza>();
        public DbSet<TratamientoMedico> TratamientoMedicos => Set<TratamientoMedico>();
        public DbSet<Medicamento> Medicamentos => Set<Medicamento>();
        public DbSet<Laboratorio> Laboratorios => Set<Laboratorio>();
        public DbSet<Proveedor> Proveedores => Set<Proveedor>();
        public DbSet<EntradaMedicamento> EntradasMedicamentos => Set<EntradaMedicamento>();
        public DbSet<SalidaMedicamento> SalidasMedicamentos => Set<SalidaMedicamento>();

    }
}