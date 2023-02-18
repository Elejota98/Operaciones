using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class FacturacionController
    {
        #region Facturas
        public static DataTable ListarFacturasPorNumero(Pagos pagos)
        {
            RepositorioFacturacion Datos = new RepositorioFacturacion();
            return Datos.ListarFacturasPorNumero(pagos);
        }
        public static string AnularFactura(Pagos pagos)
        {
            RepositorioFacturacion Datos = new RepositorioFacturacion();

            return Datos.AnularFactura(pagos);
        }
        #endregion

        #region Resoluciones
        public static string ActualizarResolucion(Resolucion resolucion)
        {
            RepositorioResoluciones Datos = new RepositorioResoluciones();
            if(resolucion.NumeroResolucion == string.Empty)
            {
                return "Es necesario un número de resolución";
            }
             else if (resolucion.Prefijo == string.Empty)
            {
                return "No se encontró el prefijo";
            }
            else
            {
                 return Datos.ActualizarResolucion(resolucion);
            }
        }

        public static DataTable ListarResoluciones(Resolucion resolucion)
        {
            RepositorioResoluciones Datos = new RepositorioResoluciones();
            return Datos.ListarResoluciones(resolucion);
        }

        #endregion
    }
}
