//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaDeViajes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public string idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidopat { get; set; }
        public string apellidomat { get; set; }
        public string genero { get; set; }
        public System.DateTime fechanacimiento { get; set; }
        public string docId { get; set; }
        public string idPais { get; set; }
        public string idCiudad { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public Nullable<System.DateTime> fechreg { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual Pais Pais { get; set; }
    }
}