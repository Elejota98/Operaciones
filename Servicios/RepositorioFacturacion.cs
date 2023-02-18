using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioFacturacion
    {
       public DataTable ListarFacturasPorNumero(Pagos pagos)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("SELECT  IdPago as ID, NumeroFactura AS NUMERO_FACTURA, IdModulo AS MODULO, FechaPago AS FECHA," +
                    " Subtotal AS SUBTOTAL, Iva AS IVA, Total AS TOTAL, Anulada AS ANULADA  FROM T_Pagos " +
                    " WHERE    NumeroFactura=" + pagos.NumeroFactura + " AND IdEstacionamiento="+pagos.IdEstacionamiento+"");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                tabla.Load(rta);
                return tabla;
            }
            catch (Exception ex )
            {

                throw ex ;
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open) sqlCon.Close();
            }

        }

        public string AnularFactura(Pagos pagos)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("UPDATE  T_Pagos SET Anulada="+ pagos.Anulada +" WHERE IdPago=" + pagos.IdPago + "");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            
            catch (Exception ex)
            {

                throw ex;
            }
           
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rta;
        }
    }
}
