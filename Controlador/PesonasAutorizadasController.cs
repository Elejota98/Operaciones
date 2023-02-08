using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public static string InsertarAutorizados(PersonasAutorizadas personasAutorizadas)
        {
            RepositorioAutorizados Datos = new RepositorioAutorizados();
            if(personasAutorizadas.Documento == string.Empty)
            {
                return "Error al guardar el registro";
            }
            else
            {
                return Datos.InsertarAutorizado(personasAutorizadas);
            }

        }
    }
}
