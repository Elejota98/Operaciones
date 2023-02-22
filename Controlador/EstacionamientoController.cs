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
    public class EstacionamientoController
    {
        public static DataTable ListarEstacionamiento(Estacionamiento estacionamiento)
        {
            RepositorioEstacionamiento Datos = new RepositorioEstacionamiento();
            return Datos.ListarEstacionamiento(estacionamiento);
        }
        public static DataTable ListarEstacionamientos()
        {
            RepositorioEstacionamiento Datos = new RepositorioEstacionamiento();
            return Datos.ListarEstacionamientos();
        }

    }
}
