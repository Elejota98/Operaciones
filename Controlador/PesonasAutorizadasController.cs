using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class PersonasAutorizadasController
    {
        public static DataTable BuscarAutorizado(PersonasAutorizadas personasAutorizadas)
        {
            RepositorioAutorizados Datos = new RepositorioAutorizados();
            return Datos.BuscarAutorizado(personasAutorizadas);
        }
        public static DataTable ListarAutorizaciones()
        {
            RepositorioAutorizados Datos = new RepositorioAutorizados();
            return Datos.ListarAutorizaciones();
        }
        public static DataTable ListarAutorizacionesPorId(AutorizacionesViewModel autorizacionesViewModel)
        {
            RepositorioAutorizados Datos = new RepositorioAutorizados();
            return Datos.ListarAutorizacionesPorId(autorizacionesViewModel);
        }
    }
}
