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
    
    public partial class ADMIN_X_EQUIPO
    {
        public int idAdminXEquipo { get; set; }
        public int idEquipo { get; set; }
        public int idUsuario { get; set; }
    
        public virtual EQUIPO EQUIPO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}