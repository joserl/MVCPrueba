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
    
    public partial class DISPONIBILIDAD_X_JUGADOR
    {
        public int idDisponibilidadXJugador { get; set; }
        public int idJugador { get; set; }
        public Nullable<System.TimeSpan> horaDesde { get; set; }
        public Nullable<System.TimeSpan> horaHasta { get; set; }
        public int idDia { get; set; }
    
        public virtual DIA DIA { get; set; }
        public virtual JUGADOR JUGADOR { get; set; }
    }
}