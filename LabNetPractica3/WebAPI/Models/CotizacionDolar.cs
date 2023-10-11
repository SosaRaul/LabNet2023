using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class CotizacionDolar
    {
        public double Compra { get; set; }
        public double Venta { get; set; }
        public string Casa { get; set; }
        public string Nombre {  get; set; }
        public string FechaActualizacion { get; set; }
    }
}
