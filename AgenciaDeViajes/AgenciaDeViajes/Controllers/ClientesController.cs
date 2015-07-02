using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AgenciaDeViajes.Models;

namespace AgenciaDeViajes.Controllers
{
    public class ClientesController : Controller
    {
        //
        // GET: /Cliente/

        EasyTravelEntities2 agv = new EasyTravelEntities2();

        public ActionResult Inicio()
        {

            return View(agv.GestionPaquetes.ToList());
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
