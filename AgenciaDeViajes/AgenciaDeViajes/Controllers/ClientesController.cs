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

        EasyTravelEntities agv = new EasyTravelEntities();
   
        List<Genero> genero = new List<Genero>();

        public ActionResult Inicio()
        {

            return View(agv.GestionPaquete.OrderBy(x=>x.findisponibilidad).Take(8));
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

            return View(agv.GestionPaquete.Where(x => x.idTipopaquete.Equals(tipopaquete)).ToList());
        }

        public ActionResult RegistrarCliente()
        {
            //cargar el modelo
            Clientes clim = new Clientes();

            //cargar paises
            ViewBag.pais = new SelectList(agv.Pais.ToList(),"idPais","nombPais");
            //cargar ciudades
            ViewBag.ciudad = new SelectList(agv.Ciudad.ToList(), "idCiudad", "nombCiudad");
            //cargar genero

            Genero g = new Genero();
            g.genero = "m";
            g.value = "Masculino";
            Genero g1 = new Genero();
            g1.genero = "f";
            g1.value = "Femenino";
           
            genero.Add(g);
            genero.Add(g1);
            ViewBag.genero = new SelectList(genero, "genero", "value");

            return View(clim);
        }
        [HttpPost]
        public ActionResult RegistrarCliente(Clientes cliente)
        {

            //cargar paises
            ViewBag.pais = new SelectList(agv.Pais.ToList(), "idPais", "nombPais",cliente.idPais);
            //cargar ciudades
            ViewBag.ciudad = new SelectList(agv.Ciudad.ToList(), "idCiudad", "nombCiudad",cliente.idCiudad);

            Genero g = new Genero();
            g.genero = "m";
            g.value = "Masculino";
            Genero g1 = new Genero();
            g1.genero = "f";
            g1.value = "Femenino";

            genero.Add(g);
            genero.Add(g1);
            ViewBag.genero = new SelectList(genero, "genero", "value",cliente.genero);


            if(ModelState.IsValid){

                System.Console.WriteLine("exito");

                Clientes cli = cliente;

                

                return RedirectToAction("Inicio");
                
            }

            return View(cliente);
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
