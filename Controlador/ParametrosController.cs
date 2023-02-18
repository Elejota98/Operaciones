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
    public class ParametrosController
    {
        public static string ObtenerValorParametrosPorNombre(string nombre, long idEstacionamiento)
        {
            RepositorioParametros Datos = new RepositorioParametros();
             return Datos.ObtenerValorParametrosPorNombre(nombre,idEstacionamiento);

        }
    }
}
