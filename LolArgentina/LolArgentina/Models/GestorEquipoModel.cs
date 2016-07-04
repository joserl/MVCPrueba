using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolArgentina.Models
{
    public class GestorEquipoModel
    {
        LOLARGENTINA18Entities modelo = new LOLARGENTINA18Entities();

        public void registrarEquipo(EQUIPO equipo)
        {
            try
            {
                equipo.fechaAlta = DateTime.Today;
                modelo.EQUIPO.Add(equipo);
                modelo.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
 
        }

    }
}