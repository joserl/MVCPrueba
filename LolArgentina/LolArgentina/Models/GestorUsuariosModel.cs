using LolArgentina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace LolArgentina.Controllers
{
    public class GestorUsuariosModel
    {
        LOLARGENTINA18Entities modelo = new LOLARGENTINA18Entities();

        

        public void crearUsuario(USUARIO usuario)
        {
            try
            {
                var usuarios = modelo.USUARIO.Where(c => c.nombreDeUsuario=="Kuroba");
                foreach (var item in usuarios)
                {
                    Console.WriteLine(item.nombreDeUsuario);
                }
                usuario.fechaRegistro = DateTime.Today;
                modelo.USUARIO.Add(usuario);
                /*Tambien se actualizara la tabla a la q estmaos haciendo referencia si creamos un nuevo objeto
                ADMIN_X_EQUIPO admin = new ADMIN_X_EQUIPO();
                admin.idAdminXEquipo = 1;
                admin.idUsuario = 1;
                admin.idEquipo = 1;
                usuario.ADMIN_X_EQUIPO.Add(admin);
                 */ 
                modelo.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void borrarUsuario(USUARIO usuario)
        {
            try
            {
                modelo.USUARIO.Remove(usuario);
                modelo.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}