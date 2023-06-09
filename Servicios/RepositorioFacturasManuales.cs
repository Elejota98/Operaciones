﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.Common;

namespace Servicios
{
    public class RepositorioFacturasManuales
    {
        public DataTable ListarFacManuales(int idEstacionamiento, string fechadesde, string fechahasta)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("SELECT        dbo.T_FacturasManuales.IdModulo, dbo.T_FacturasManuales.IdEstacionamiento, dbo.T_FacturasManuales.FechaPago, dbo.T_FacturasManuales.Subtotal," +
                         " dbo.T_FacturasManuales.Iva, dbo.T_FacturasManuales.Total, dbo.T_FacturasManuales.Prefijo, dbo.T_FacturasManuales.NumeroFactura, dbo.T_TipoVehiculo.TipoVehiculo, dbo.T_Usuarios.Documento," +
                         " dbo.T_FacturasManuales.Sincronizacion" +
                         " FROM            dbo.T_TipoVehiculo INNER JOIN" +
                         " dbo.T_FacturasManuales ON dbo.T_TipoVehiculo.IdTipoVehiculo = dbo.T_FacturasManuales.IdTipoVehiculo INNER JOIN" +
                         " dbo.T_Usuarios ON dbo.T_FacturasManuales.DocumentoUsuario = dbo.T_Usuarios.Documento where FechaPago between '" + fechadesde + "' and '" + fechahasta + "'  and IdEstacionamiento ='" + idEstacionamiento + "' order by fechapago desc");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
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
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
        public DataTable ListarCarril()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("SELECT * from T_TipoModulo where TipoModulo!='ENTRADA' and TipoModulo!='SALIDA'");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
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
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }
        public DataTable ListarUusarios()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("select Documento, Nombres, Apellidos from T_Usuarios");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
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
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }
        public DataTable ListarUusariosPorDocumento(FacturasManuales facturasManuales)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("select Documento, Nombres from T_Usuarios where Documento='"+facturasManuales.DocumentoUsuario+"'");
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
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
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }

        public DataTable ListarTipoCobro()
        {

            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = "select IdTipoVehiculo,TipoVehiculo from t_tipovehiculo";
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                Tabla.Load(rta);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }
        public DataTable ListarTipoCobroPorNombre(FacturasManuales facturasManuales)
        {

            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = "SELECT * FROM T_TipoVehiculo WHERE TipoVehiculo='"+facturasManuales.TipoVehiculo+"'";
                SqlCommand comando = new SqlCommand(cadena, sqlcon);
                sqlcon.Open();
                SqlDataReader rta = comando.ExecuteReader();
                Tabla.Load(rta);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }
        public string InsertarFactura(FacturasManuales facturasManuales)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            string fechaPago = string.Empty;
            string fechaPagoAntes = string.Empty;
            fechaPago = facturasManuales.FechaPago.Year + "-" + facturasManuales.FechaPago.Month + "-" + facturasManuales.FechaPago.Day + " " + facturasManuales.FechaPago.Hour + ":" +
                facturasManuales.FechaPago.Minute + ":" + facturasManuales.FechaPago.Second;

           fechaPagoAntes= facturasManuales.FechaPago.Year + "-" + facturasManuales.FechaPago.Month + "-" + facturasManuales.FechaPago.Day + " " + facturasManuales.FechaPago.Hour + ":" +
                facturasManuales.FechaPago.Minute + ":" + facturasManuales.FechaPago.Second;
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("insert into T_FacturasManuales(IdModulo,IdEstacionamiento,FechaPago,Subtotal,Iva,Total,Prefijo,NumeroFactura,IdTipovehiculo,DocumentoUsuario,Sincronizacion) " +
                "Values('" + facturasManuales.IdModulo + "','" + facturasManuales.IdEstacionamiento + "', '" + fechaPago+ "', '" + facturasManuales.Subtotal + "', " +
                "'" + facturasManuales.Iva + "', '" + facturasManuales.Total + "', '" + facturasManuales.Prefijo + "', '" + facturasManuales.NumeroFactura + "', '" + facturasManuales.IdTipoVehiculo + 
                "', '" + facturasManuales.DocumentoUsuario + "', '" + 1 + "')");
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

        public string ModificarFactura(FacturasManuales facturasManuales)
        {
            string Rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            string fechaPago = string.Empty;
            string fechaPagoAntes = string.Empty;
            fechaPago = facturasManuales.FechaPago.Year + "-" + facturasManuales.FechaPago.Month + "-" + facturasManuales.FechaPago.Day + " " + facturasManuales.FechaPago.Hour + ":" +
                facturasManuales.FechaPago.Minute + ":" + facturasManuales.FechaPago.Second;

            fechaPagoAntes = facturasManuales.FechaPago.Year + "-" + facturasManuales.FechaPago.Month + "-" + facturasManuales.FechaPago.Day + " " + facturasManuales.FechaPago.Hour + ":" +
                 facturasManuales.FechaPago.Minute + ":" + facturasManuales.FechaPago.Second;
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                string cadena = ("UPDATE T_FacturasManuales SET IdModulo='"+facturasManuales.IdModulo+"', FechaPago='"+ fechaPago+ "', Subtotal='"+ facturasManuales.Subtotal+ "', " +
                    "IVA ='"+ facturasManuales.Iva+ "', Total='"+ facturasManuales.Total+ "', Prefijo='"+ facturasManuales.Prefijo+ "', NumeroFactura='"+ facturasManuales.NumeroFactura+ "', IdTipoVehiculo='"+ facturasManuales.IdTipoVehiculo+ "', " +
                    "DocumentoUsuario='"+facturasManuales.DocumentoUsuario+"', Sincronizacion=1 WHERE IdModulo='" + facturasManuales.IdModuloAntes + "' AND IdEstacionamiento='"+facturasManuales.IdEstacionamientoAntes+ "' AND FechaPago='"+ fechaPagoAntes+ "'"+
                    "AND Total='"+facturasManuales.TotalAntes+"' AND Prefijo='"+facturasManuales.PrefijoAntes+"' " +
                    "AND NumeroFactura='"+facturasManuales.NumeroFacturaAntes +"' AND DocumentoUsuario='"+facturasManuales.DocumentoUsuarioAntes+"' ");
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
