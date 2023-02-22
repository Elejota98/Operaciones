using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
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
        public static string ActualizarAutorizados(PersonasAutorizadas personasAutorizadas)
        {
            RepositorioAutorizados Datos = new RepositorioAutorizados();
            if(personasAutorizadas.NombreApellidos == string.Empty)
            {
                return "No se puede realizar el registro, es necesario que ingrese un nombre";
            }
            else if (personasAutorizadas.IdAutorizado == null)
            {
                return "Por favor selecciones al menos una autorización";
            }
            else
            {
                return Datos.ActualizarAutoizado(personasAutorizadas);
            }
        }
        public static string ActualizaTarjetaAutorizado(PersonasAutorizadas personasAutorizadas)
        {
            RepositorioAutorizados Datos = new RepositorioAutorizados();
            if(personasAutorizadas.IdTarjeta == string.Empty)
            {
                return "No se encontró el Id de la tarjeta";

            }
            else
            {
                return Datos.ActualizaTarjetaAutorizado(personasAutorizadas);

            }
        }
    }
}
