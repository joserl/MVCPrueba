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
    
    public partial class CAMPEONES_MAS_JUGADOS_X_USUARIO
    {
        public int idCampeonesMasJugadosXUSuario { get; set; }
        public int idJugador { get; set; }
        public int idCampeon { get; set; }
    
        public virtual CAMPEONES CAMPEONES { get; set; }
        public virtual JUGADOR JUGADOR { get; set; }
    }
}