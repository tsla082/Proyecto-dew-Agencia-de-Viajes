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
        [StringLength(45, ErrorMessage = "el campo no debe tener mas de 45 letras")]
        public  String idCliente {get;set;}

        [StringLength(45, ErrorMessage = "el campo no debe tener mas de 45 letras")]
        [Required(AllowEmptyStrings=false,ErrorMessage=" Ingresar su nombre")]
        public  String nombre { get; set; }

        [StringLength(45, ErrorMessage = "el campo no debe tener mas de 45 letras")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su apellido paterno")]
        public String apellidopat { get; set; }

        [StringLength(45, ErrorMessage = "el campo no debe tener mas de 45 letras")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su apellido manterno")]
        public String apellidomat { get; set; }

        [Required(ErrorMessage = " Ingresar su genero") ]
        public String genero { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su fecha de nacimiento")]
        public DateTime fechanacimiento { get; set; }

       [StringLength(8, ErrorMessage = "el dni no tiene mas de 8 numeros")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " Ingresar su documento de identidad")]
        public String docId { get; set; }

        [Required(ErrorMessage = " Ingresar su pais") ]
        public String idPais { get; set; }

        [Required(ErrorMessage = " Ingresar su ciudad")]
        public String idCiudad { get; set; }

        [StringLength(70, ErrorMessage = "el campo no debe tener mas de 70 letras")]
        [Required(AllowEmptyStrings = false,ErrorMessage = " Ingresar su direccion")]
        public String direccion { get; set; }

        [StringLength(45, ErrorMessage = "el campo no debe tener mas de 45 letras")]
        [Required(AllowEmptyStrings = false,ErrorMessage = " Ingresar su correo")]
        public String correo { get; set; }

        [StringLength(10, ErrorMessage = "el campo no debe tener mas de 10 letras")]
        [Required(AllowEmptyStrings = false,ErrorMessage = " Ingresar su clave")]
        public String clave { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat( DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime fechreg { get; set; }

    }
}