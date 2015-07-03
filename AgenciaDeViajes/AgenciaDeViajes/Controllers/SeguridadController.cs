using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AgenciaDeViajes.Models;

namespace AgenciaDeViajes.Controllers
{
    public class SeguridadController : Controller
    {
        //
        // GET: /Seguridad/

        public ActionResult Login()
        {
            return View();
        }

        //
        // GET: /Seguridad/Details/5
        [HttpPost]
        public ActionResult Login(Empleados emp)
        {
            return View();
        }

        public static List<Cliente> clientelista = new List<Cliente>();

        public static List<Empleados> Empleadoslista = new List<Empleados>();

        

        public Boolean verficarSesion() { 

            Boolean existe=false;

            return existe;
        }

        public void crearSesionCliente()
        {

            Session["ClienteSession"] = clientelista;

        }
        public void crearSesionEmpleados()
        {

            Session["EmpleadoSession"] = Empleadoslista;

        }
        
    }
}
