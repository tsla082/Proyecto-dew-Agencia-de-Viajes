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

        //instancia ado de objetos de base de datos

        EasyTravelEntities ete = new EasyTravelEntities();

        //instancia paquetes controller

        PaquetesController pqc = new PaquetesController();

        //elementos

        public static List<Clientes> clientelista = new List<Clientes>();

        public static List<Empleados> Empleadoslista = new List<Empleados>();

        public static String mensajes;

        public static String mensajesvalidacionempleado;

        String sesioncliente = "ClienteSession";
        String sesionclientecarro = "ClienteCarritoSession";
        String sesionempleado = "EmpleadoSession";
        //
        // GET: /Seguridad/

        public ActionResult Login()
        {
            //crear la instancia del modelo a recibir

            Empleados emp = new Empleados();

            return View(emp);
        }

        //
        // GET: /Seguridad/Details/5
        [HttpPost]
        public ActionResult Login(Empleados emp)
        {

            if(ModelState.IsValid){
                
                //confirmar si hay usuario
                Empleados em = emp;

                Empleado emple = ete.Empleado.Where(x => x.idEmpleado == em.idEmpleado && x.clave.Equals(em.clave)).FirstOrDefault();

              if (emple!=null){

                  em.idEmpleado = emple.idEmpleado;
                  em.nombre = emple.nombre;
                  em.apellidopat = emple.apellidopat;
                  em.apellidomat = emple.apellidomat;
                  em.genero = emple.genero;
                  em.dni = emple.dni;
                  em.telefono = emple.telefono;
                  em.idPais = emple.idPais;
                  em.idCiudad = emple.idCiudad;
                  em.direccion = emple.direccion;
                  em.idcargo = emple.idCargo;
                  em.clave = emple.clave;
                  em.fechareg = (DateTime)emple.fechareg;

                  crearSesionEmpleados(em);

                  return RedirectToAction("MenuPrincipal","Paquetes");
               
              }
              //si no hayusuario
              else
              {

                  mensajesvalidacionempleado = "Error de id o clave ,usuario no encontrado";

                  return View(emp);

              }

               

            }

            return View(emp);
        }

        

        public Boolean verficarSesion(String nombresesion) { 

            Boolean existe=false;

            List<Object> obj = (List<Object>)Session[nombresesion];

            //agregar script

            if (obj != null)
            {
                existe = true;
            }

            return existe;
        }

        public void crearSesionCliente(Object objcli)
        {

            Session["ClienteSession"] = objcli;

        }
        public void crearSesionClienteCarrito(Object objcliecar)
        {

            Session["ClienteCarritoSession"] = objcliecar;

        }
        public void crearSesionEmpleados(Object objemp)
        {

            Session["EmpleadoSession"] = objemp;

        }
        
    }
}
