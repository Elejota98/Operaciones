using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioResoluciones
    {

        public string ActualizarResolucion(Resolucion resolucion)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("update T_Facturacion set IdModulo='"+resolucion.IdModulo+"', FacturaInicial='" + resolucion.FacturaInicial + "', FacturaFinal='" + resolucion.FacturaFinal + "'," +
                    "NumeroResolucion='" + resolucion.NumeroResolucion + "', FechaResolucion='" + resolucion.FechaResolucion + "', FechaFinResolucion='" + resolucion.FechaFinResolucion + "' " +
                    "where IdFacturacion='" + resolucion.IdFacturacion + "' and Prefijo='" + resolucion.Prefijo + "' and IdEstacionamiento=" + resolucion.IdEstacionamiento + "");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";     
            }
            catch (Exception ex )
            {

                throw ex;
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open) sqlCon.Close();
            }
            return rta;
        }

        public DataTable ListarResoluciones( Resolucion resolucion)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("Select * from T_Facturacion where IdEstacionamiento="+resolucion.IdEstacionamiento+"");
                sqlCon.Open();
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                SqlDataReader rta = comando.ExecuteReader();
                tabla.Load(rta);
                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

        }
    }
}
