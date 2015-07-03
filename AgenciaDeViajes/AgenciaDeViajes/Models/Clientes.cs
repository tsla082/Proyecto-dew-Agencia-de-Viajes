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
        [Required(ErrorMessage="Ingrese el id del Cliente")]
        public  String idCliente {get;set;}

        [Required(AllowEmptyStrings=false,ErrorMessage=" Ingresar su nombre")]

        public  String nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su apellido paterno")]
        public String apellidopat { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su apellido manterno")]
        public String apellidomat { get; set; }

        [Required(ErrorMessage = " Ingresar su genero") ]
        public String genero { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su fecha de nacimiento")]
        public String fechanacimiento { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su documento de identidad")]
        public String docId { get; set; }

        [Required(ErrorMessage = " Ingresar su pais") ]
        public String idPais { get; set; }

        [Required(ErrorMessage = " Ingresar su ciudad")]
        public String idCiudad { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = " Ingresar su direccion")]
        public String direccion { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = " Ingresar su correo")]
        public String correo { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = " Ingresar su clave")]
        public String clave { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public DateTime fechreg { get; set; }

    }
}