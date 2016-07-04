using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LolArgentina.Models;


namespace LolArgentina.Controllers
{
    public class UsuarioController : Controller
    {
        GestorUsuariosModel gestorUsuario = new GestorUsuariosModel();

  
        public ActionResult crearUsuario()
        {
            return View();
        }


        public ActionResult iniciarSesion()
        {
            return View();
        }


        [HttpPost]
        public ActionResult nuevoUsuario(USUARIO usuario)
        {
            usuario.idRol = 1;
            gestorUsuario.crearUsuario(usuario);
            ViewData["mensaje"] = "usuario creado";
            return View(usuario);
        }

    }
}