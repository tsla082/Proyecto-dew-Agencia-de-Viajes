//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaDeViajes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aeropuerto
    {
        public Aeropuerto()
        {
            this.ProgVueloes = new HashSet<ProgVuelo>();
            this.ProgVueloes1 = new HashSet<ProgVuelo>();
            this.ProgVueloes2 = new HashSet<ProgVuelo>();
        }
    
        public string idAeropuerto { get; set; }
        public string nombAeropuerto { get; set; }
        public string idPais { get; set; }
        public string idCiudad { get; set; }
        public string direcAeropuerto { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual Pai Pai { get; set; }
        public virtual ICollection<ProgVuelo> ProgVueloes { get; set; }
        public virtual ICollection<ProgVuelo> ProgVueloes1 { get; set; }
        public virtual ICollection<ProgVuelo> ProgVueloes2 { get; set; }
    }
}
