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
    
    public partial class TipoHabitacion
    {
        public TipoHabitacion()
        {
            this.Habitacions = new HashSet<Habitacion>();
        }
    
        public string idTipoHabitacion { get; set; }
        public string tipoHabitacion1 { get; set; }
    
        public virtual ICollection<Habitacion> Habitacions { get; set; }
    }
}
