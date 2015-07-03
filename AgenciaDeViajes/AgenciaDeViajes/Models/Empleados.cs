using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaDeViajes.Models
{
    public class Empleados
    {
        String idEmpleado { get; set; }
        String nombre { get; set; }
        String apellidopat { get; set; }
        String apellidomat { get; set; }
        String genero { get; set; }
        String dni{ get; set; }
        String telefono{ get; set; }
        String idPais { get; set; }
        String idCiudad { get; set; }
        String direccion { get; set; }
        String idcargo{ get; set; }
        String clave { get; set; }
        DateTime fechreg { get; set; }
    }
}