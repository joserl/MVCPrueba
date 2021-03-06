//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LolArgentina.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.ADMIN_X_EQUIPO = new HashSet<ADMIN_X_EQUIPO>();
            this.JUGADOR = new HashSet<JUGADOR>();
        }
    
        public int IdUsuario { get; set; }
        public int idRol { get; set; }
        [StringLength(20), Required, Display(Name = "Nombre de usuario")]
        public string nombreDeUsuario { get; set; }
        [StringLength(20), Required, Display(Name = "Contraseña")]
        public string contrasena { get; set; }
        [Display(Name = "Fecha de Registro")]
        public System.DateTime fechaRegistro { get; set; }
    
        public virtual ICollection<ADMIN_X_EQUIPO> ADMIN_X_EQUIPO { get; set; }
        public virtual ICollection<JUGADOR> JUGADOR { get; set; }
        public virtual ROLES_USUARIOS ROLES_USUARIOS { get; set; }
    }
}
