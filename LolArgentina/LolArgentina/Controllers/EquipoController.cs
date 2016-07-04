using LolArgentina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LolArgentina.Controllers
{
    public class EquipoController : Controller
    {
        // GET: Equipo
        public ActionResult registrarEquipo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoEquipo(EQUIPO equipo)
        {
            GestorEquipoModel contexto = new GestorEquipoModel();
            contexto.registrarEquipo(equipo);
            return View(equipo);
        }
    }
}