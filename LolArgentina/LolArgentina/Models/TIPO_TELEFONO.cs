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
    
    public partial class TIPO_TELEFONO
    {
        public TIPO_TELEFONO()
        {
            this.TELEFONO_X_JUGADOR = new HashSet<TELEFONO_X_JUGADOR>();
        }
    
        public int idTipoTelefono { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<TELEFONO_X_JUGADOR> TELEFONO_X_JUGADOR { get; set; }
    }
}
