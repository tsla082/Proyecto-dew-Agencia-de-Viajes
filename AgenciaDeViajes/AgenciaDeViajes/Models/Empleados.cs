using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//improtar libreia de tabajo de compnente del sistema las anotaciones de datos
using System.ComponentModel.DataAnnotations;

namespace AgenciaDeViajes.Models
{
    public class Empleados
    {
         [Required(ErrorMessage = "Ingrese el id del usuario")]
         [StringLength(4, ErrorMessage = "el campo no debe tener mas de 4 caracteres del id")]
         public String idEmpleado { get; set; }
         public String nombre { get; set; }
         public String apellidopat { get; set; }
         public String apellidomat { get; set; }
         public String genero { get; set; }
         public String dni { get; set; }
         public String telefono { get; set; }
         public String idPais { get; set; }
         public String idCiudad { get; set; }
         public String direccion { get; set; }
         public String idcargo { get; set; }
         [Required(ErrorMessage = "Ingrese clave del usuario")]
         [StringLength(10, ErrorMessage = "el campo no debe tener mas de 10 caracteres de la clave")]
         public String clave { get; set; }
         public DateTime fechareg { get; set; }
    }
}