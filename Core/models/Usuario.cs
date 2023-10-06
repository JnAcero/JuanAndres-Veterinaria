using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class Usuario : BaseEntity
    {
        public string NombreUsuario { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }

        public List<UsuarioRol> UsuariosRoles { get; set; } = new List<UsuarioRol>();
        [NotMapped]
        public Veterinario Veterinario { get; set; }
         [NotMapped]
        public Propietario Propietario { get; set; }
    }
}