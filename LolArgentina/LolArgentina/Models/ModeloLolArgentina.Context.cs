﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LOLARGENTINA18Entities : DbContext
    {
        public LOLARGENTINA18Entities()
            : base("name=LOLARGENTINA18Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN_X_EQUIPO> ADMIN_X_EQUIPO { get; set; }
        public virtual DbSet<CAMPEONES> CAMPEONES { get; set; }
        public virtual DbSet<CAMPEONES_MAS_JUGADOS_X_USUARIO> CAMPEONES_MAS_JUGADOS_X_USUARIO { get; set; }
        public virtual DbSet<CIUDAD> CIUDAD { get; set; }
        public virtual DbSet<DIA> DIA { get; set; }
        public virtual DbSet<DISPONIBILIDAD_X_JUGADOR> DISPONIBILIDAD_X_JUGADOR { get; set; }
        public virtual DbSet<DIVISION> DIVISION { get; set; }
        public virtual DbSet<DOMICILIO> DOMICILIO { get; set; }
        public virtual DbSet<EQUIPO> EQUIPO { get; set; }
        public virtual DbSet<JUGADOR> JUGADOR { get; set; }
        public virtual DbSet<JUGADORES_X_EQUIPO> JUGADORES_X_EQUIPO { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<POSTULACION_EQUIPO_X_JUGADOR> POSTULACION_EQUIPO_X_JUGADOR { get; set; }
        public virtual DbSet<PROVINCIA> PROVINCIA { get; set; }
        public virtual DbSet<ROLES_JUGADOR> ROLES_JUGADOR { get; set; }
        public virtual DbSet<ROLES_JUGADOR_X_JUGADOR> ROLES_JUGADOR_X_JUGADOR { get; set; }
        public virtual DbSet<ROLES_USUARIOS> ROLES_USUARIOS { get; set; }
        public virtual DbSet<TELEFONO_X_JUGADOR> TELEFONO_X_JUGADOR { get; set; }
        public virtual DbSet<TIPO_TELEFONO> TIPO_TELEFONO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}
