using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class FacturasManuales
    {
        public string IdModulo { get; set; }
        public long IdEstacionamiento { get; set; }
        public DateTime FechaPago { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public double Iva { get; set; }
        public string Prefijo { get; set; }
        public string NumeroFactura { get; set; }
        public int IdTipoVehiculo { get; set; }
        public long DocumentoUsuario { get; set; }
        public bool Sincronizacion { get; set; }
        public string IdModuloAntes { get; set; }
        public long IdEstacionamientoAntes { get; set; }
        public DateTime FechaPagoAntes { get; set; }
        public int SubtotalAntes { get; set; }
        public int TotalAntes { get; set; }
        public int IvaAntes { get; set; }
        public string PrefijoAntes { get; set; }
        public string NumeroFacturaAntes { get; set; }
        public string IdTipoVehiculoAntes { get; set; }
        public string DocumentoUsuarioAntes { get; set; }
        public bool SincronizacionAntes { get; set; }
        public string TipoVehiculo { get; set; }
    }
}
