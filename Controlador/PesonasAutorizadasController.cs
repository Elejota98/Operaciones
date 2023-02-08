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
            if (personasAutorizadas.Documento == string.Empty)
            {
                return "Es necesario ingresar un documento";
            }
            else if (personasAutorizadas.Placa1 == string.Empty && personasAutorizadas.Placa2==string.Empty)
            {
                return "Es necesario que el autorizado tenga por lo menos una placa";
            }            
            else
            {
                string fechaInicio = Convert.ToDateTime(personasAutorizadas.FechaInicio).ToString();
                string fechaFin = Convert.ToDateTime(personasAutorizadas.FechaFin).ToString();
                if (fechaInicio == string.Empty && fechaFin==string.Empty)
                {
                    fechaInicio = "NULL";
                    fechaFin= "NULL";
                    personasAutorizadas.FechaInicio = Convert.ToDateTime(fechaInicio);
                    personasAutorizadas.FechaFin = Convert.ToDateTime(fechaFin);
                }
                else
                {
                    return Datos.InsertarAutorizado(personasAutorizadas);
                }
                return Datos.InsertarAutorizado(personasAutorizadas);
            }

        }
    }
}
