using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Servicios
{
    public  class RepositorioConsignacion
    {   
        public DataTable BuscarConsignacion(Consignacion consignacion)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            string fechaInicio = consignacion.FechaInicio.Year + "-" + consignacion.FechaInicio.Month + "-" + consignacion.FechaInicio.Day + " " +
                consignacion.FechaInicio.Hour + ":" + consignacion.FechaInicio.Minute + ":" + consignacion.FechaInicio.Second;
            string fechaHasta = consignacion.FechaHasta.Year + "-" + consignacion.FechaHasta.Month + "-" + consignacion.FechaHasta.Day + " " +
                consignacion.FechaHasta.Hour + ":" + consignacion.FechaHasta.Minute + ":" + consignacion.FechaHasta.Second;
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("select * from T_Consignacion where dbo.T_Consignacion.FechaConsignacion between '" + fechaInicio + "' AND '" + fechaHasta+ "' " +
                    "AND dbo.T_Consignacion.IdEstacionamiento='" + consignacion.IdEstacionamiento + "' " +
                    "ORDER BY dbo.T_Consignacion.FechaConsignacion DESC");
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
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable ListarTipoDeposito()
        {
            DataTable tabla = new DataTable ();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("SELECT IdDeposito, Consignacion FROM T_TipoConsignacion");
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

        public DataTable ListarTipoDepositoPorId(Consignacion consignacion)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("SELECT IdDeposito, Consignacion FROM T_TipoConsignacion WHERE IdDeposito="+consignacion.IdTipoDeposito+"");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
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
        public string ModificarConsignacion(Consignacion consignacion)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("UPDATE T_Consignacion SET Valor='"+consignacion.Valor+"', Referencia='"+consignacion.Referencia+"', DocumentoUsuario='"+consignacion.DocumentoUsuario+"'," +
                    " IdTipoDeposito='"+consignacion.IdTipoDeposito+"' WHERE IdConsignacion='"+consignacion.IdConsignacion+"' AND IdEstacionamiento='"+consignacion.IdEstacionamiento+"'");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                comando.ExecuteNonQuery();
                Rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rta;
        }

        public string EliminarConsignacion(Consignacion consignacion)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("Delete from T_Consignacion where IdConsignacion='"+consignacion.IdConsignacion+"' and IdEstacionamiento='"+consignacion.IdEstacionamiento+"'");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                comando.ExecuteNonQuery();
                Rta = "OK";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rta;
        }
    }
}
