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
    
    public partial class DOMICILIO
    {
        public DOMICILIO()
        {
            this.JUGADOR = new HashSet<JUGADOR>();
        }
    
        public int idDomicilio { get; set; }
        public int idCiudad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string dpto { get; set; }
    
        public virtual CIUDAD CIUDAD { get; set; }
        public virtual ICollection<JUGADOR> JUGADOR { get; set; }
    }
}
