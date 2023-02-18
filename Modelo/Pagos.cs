using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pagos
    {
        public long IdPago { get; set; }
        public string IdTransaccion { get; set; }
        public long IdAutorizado { get; set; }
        public long IdEstacionamiento { get; set; }
        public string IdModulo { get; set; }
        public long IdFacturacion { get; set; }
        public long IdTipoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public string NumeroFactura { get; set; }
        public bool Sincronizacion { get; set; }
        public bool PagoMensual { get; set; }
        public int Anulada { get; set; }
        public bool Estado { get; set; }
    }
}
