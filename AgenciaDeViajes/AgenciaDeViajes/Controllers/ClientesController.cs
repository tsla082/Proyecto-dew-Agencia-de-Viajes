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

            return View(agv.GestionPaquetes.OrderBy(x=>x.findisponibilidad).Take(8));
        }

      

        public ActionResult PaquetesXtipo(String tipopaquete=null)
        {
            ViewBag.tipopaquete = tipopaquete;

             String NAC1 = "NAC1";
        String ITN1 = "ITN1";

        ViewBag.tituloPaquetesXtipo = "Paquetes por tipo";

            if(tipopaquete==NAC1){
                   ViewBag.tituloPaquetesXtipo = "Paquetes Nacionales";

            }
             if(tipopaquete==ITN1){
                ViewBag.tituloPaquetesXtipo = "Paquetes Internacionales";

            }

            return View(agv.GestionPaquetes.Where(x => x.idTipopaquete.Equals(tipopaquete)).ToList());
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

        public ActionResult Acercadenosotros( )
        {
            return View();
        }
        public ActionResult Contactenos()
        {
            return View();
        }

    }
}
