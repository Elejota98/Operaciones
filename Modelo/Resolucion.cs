using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public  class Resolucion
    {
        public long IdFacturacion { get; set; }
        public string IdModulo { get; set; }
        public long IdEstacionamiento { get; set; }
        public string Prefijo { get; set; }
        public string FacturaInicial { get; set; }
        public string FacturaFinal { get; set; }
        public string FacturaActual { get; set; }
        public string NumeroResolucion { get; set; }
        public string FechaResolucion { get; set; }
        public Boolean Estado { get; set; }
        public string FechaFinResolucion { get; set; }
    }
}
