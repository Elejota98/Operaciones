using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Consignacion
    {
        public long IdConsignacion { get; set; }
        public long IdEstacionamiento { get; set; }
        public DateTime FechaConsignacion { get; set; }
        public double Valor { get; set; }
        public string Referencia { get; set; }
        public long DocumentoUsuario { get; set; }
        public string IdTipoDeposito { get; set; }
        public bool Sincronizacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaHasta { get; set; }

    }
}
