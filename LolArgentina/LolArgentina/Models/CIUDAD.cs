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
    
    public partial class CIUDAD
    {
        public CIUDAD()
        {
            this.DOMICILIO = new HashSet<DOMICILIO>();
        }
    
        public int idCiudad { get; set; }
        public int idProvincia { get; set; }
        public string nombre { get; set; }
    
        public virtual PROVINCIA PROVINCIA { get; set; }
        public virtual ICollection<DOMICILIO> DOMICILIO { get; set; }
    }
}
