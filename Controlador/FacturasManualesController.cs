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
    public class FacturasManualesController
    {
        public static DataTable ListarFacManuales(int idEstacionamiento, string fechadesde, string fechahasta)
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            return Datos.ListarFacManuales(idEstacionamiento, fechadesde, fechahasta);
        }
        public static DataTable ListarCarril()
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            return Datos.ListarCarril();
        }
        public static DataTable ListarUsuarios()
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            return Datos.ListarUusarios();
        }
        public static DataTable ListarUsuariosPorDocumento(FacturasManuales facturasManuales)
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            return Datos.ListarUusariosPorDocumento( facturasManuales);
        }
        public static DataTable ListarTipoCobro()
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            return Datos.ListarTipoCobro();
        }

        public static DataTable ListarTipoCobroNombre( FacturasManuales facturasManuales)
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            return Datos.ListarTipoCobroPorNombre(facturasManuales);
        }
        public static string InsertarFactura(FacturasManuales facturasManuales)
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            if (facturasManuales.NumeroFactura == string.Empty)
            {
                return "Es necesario un número de factura";
            }
            else if(facturasManuales.Total == null || facturasManuales.Iva== null || facturasManuales.Subtotal == null)
            {
                return "Es necesario ingresar el valor de la factura";
            }
            else
            {
                return Datos.InsertarFactura(facturasManuales);
            }
            
        }
        public static string ModificarFactura(FacturasManuales facturasManuales)
        {
            RepositorioFacturasManuales Datos = new RepositorioFacturasManuales();
            if (facturasManuales.NumeroFactura == string.Empty)
            {
                return "Es necesario un número de factura";
            }
            else if (facturasManuales.Total == null || facturasManuales.Iva == null || facturasManuales.Subtotal == null)
            {
                return "Es necesario ingresar el valor de la factura";
            }
            else
            {
                return Datos.ModificarFactura(facturasManuales);
            }
        }
    }
}
