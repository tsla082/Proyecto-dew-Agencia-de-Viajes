using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaDeViajes.Models
{
    public class Paquete
    {

   String idPaquete{get;set;}
   String idTipopaquete{get;set;}
   String nombPaquete{get;set;}
   String idPais{get;set;}
   String idCiudad{get;set;}
   DateTime iniciodisponibilidad{get;set;}
   DateTime findisponibilidad{get;set;}
   String idProgVuelo{get;set;}
   String servIncluidos{get;set;}
   String servAdicional{get;set;}
   String infoPaquete{get;set;}
   decimal precioPaqueteAdulto{get;set;}
   decimal precioPaqueteNiño { get; set; }
    
    }
}