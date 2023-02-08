using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public  class PersonasAutorizadas
    {
        public string Documento { get; set; }
        public long IdAutorizado { get; set; }
        public long IdEstacionamiento { get; set; }
        public string NombreApellidos { get; set; }
        public string IdTarjeta { get; set; }
        public string NombreEmpresa { get; set; }
        public string Nit { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long DocumentoUsuarioCreacion { get; set; }
        public bool Estado { get; set; }
        public bool Sincronizacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Placa1 { get; set; }
        public string Placa2 { get; set; }
        public string Placa3 { get; set; }
        public string Placa4 { get; set; }
        public string Placa5 { get; set; }
        public long ValorBolsa { get; set; }
    }
}
