using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgenciaDeViajes.Controllers
{
    public class ClientesController : Controller
    {
        //
        // GET: /Cliente/

       // AgenciaDeViajes agv = new AgenciaDeViajes();

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult RegistrarCliente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarCliente(AgenciaDeViajes.Models.Cliente cliente)
        {
            return View();
        }



    }
}
