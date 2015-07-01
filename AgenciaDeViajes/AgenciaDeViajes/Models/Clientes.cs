using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//libreria de trabajo para las anotaciones
using System.ComponentModel.DataAnnotations;

namespace AgenciaDeViajes.Models
{
    public class Clientes
    {
        [Required(ErrorMessage="Ingrese el id del Cliente",AllowEmptyStrings=false)]
        String idCliente {get;set;}
        String nombre {get;set;}
        String apellidopat {get;set;}
        String apellidomat {get;set;}
        String Stringgenero {get;set;}
        String fechanacimiento {get;set;}
        String docId {get;set;}
        String idPais {get;set;}
        String idCiudad {get;set;}
        String direccion {get;set;}
        String correo {get;set;}
        String clave {get;set;}
        DateTime  fechreg {get;set;}

    }
}