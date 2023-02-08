using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioAutorizados
    {
        public DataTable BuscarAutorizado(PersonasAutorizadas personasAutorizadas)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("SELECT dbo.T_PersonasAutorizadas.Documento, dbo.T_Autorizaciones.NombreAutorizacion, dbo.T_PersonasAutorizadas.IdEstacionamiento, dbo.T_PersonasAutorizadas.NombreApellidos, dbo.T_PersonasAutorizadas.IdTarjeta," +
                  "dbo.T_PersonasAutorizadas.NombreEmpresa, dbo.T_PersonasAutorizadas.Nit, dbo.T_PersonasAutorizadas.FechaCreacion, dbo.T_PersonasAutorizadas.DocumentoUsuarioCreacion, dbo.T_PersonasAutorizadas.Estado, " +
                  "dbo.T_PersonasAutorizadas.Sincronizacion, dbo.T_PersonasAutorizadas.FechaInicio, dbo.T_PersonasAutorizadas.FechaFin, dbo.T_PersonasAutorizadas.Telefono, dbo.T_PersonasAutorizadas.Email, dbo.T_PersonasAutorizadas.Placa1, " +
                  "dbo.T_PersonasAutorizadas.Placa2, dbo.T_PersonasAutorizadas.Placa3, dbo.T_PersonasAutorizadas.Placa4, dbo.T_PersonasAutorizadas.Placa5, dbo.T_PersonasAutorizadas.ValorBolsa " +
                  " FROM     dbo.T_Autorizaciones INNER JOIN " +
                  "dbo.T_PersonasAutorizadas ON dbo.T_Autorizaciones.IdEstacionamiento = dbo.T_PersonasAutorizadas.IdEstacionamiento AND dbo.T_Autorizaciones.IdAutorizacion = dbo.T_PersonasAutorizadas.IdAutorizacion where documento like '%" + personasAutorizadas.Documento + "%' and Placa1 like '%" + personasAutorizadas.Placa1 + "%' and Placa2 like '%" + personasAutorizadas.Placa2 + "%'");
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

        public DataTable ListarAutorizaciones()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("Select IdAutorizacion,NombreAutorizacion from T_Autorizaciones");
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

        public DataTable ListarAutorizacionesPorId(AutorizacionesViewModel autorizacionesViewModel)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("Select IdAutorizacion,NombreAutorizacion from T_Autorizaciones Where IdAutorizacion='" + autorizacionesViewModel.IdAutorizacion + "'");
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

        public string InsertarAutorizado(PersonasAutorizadas personasAutorizadas) 
        {
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("insert into T_PersonasAutorizadas (Documento, IdAutorizacion, IdEstacionamiento, NombreApellidos, IdTarjeta, NombreEmpresa," +
                "Nit, FechaCreacion, DocumentoUsuarioCreacion, Estado, Sincronizacion, FechaInicio, FechaFin, Telefono, Email, Placa1, Placa2," +
                "Placa3, Placa4, Placa5, ValorBolsa) Values('" + personasAutorizadas.Documento + "','" + personasAutorizadas.IdAutorizado + "', '" + personasAutorizadas.IdEstacionamiento + "'," +
                "'" + personasAutorizadas.NombreApellidos + "', '" + personasAutorizadas.Documento + "', '" + personasAutorizadas.NombreEmpresa + "', '" + personasAutorizadas.Nit + "',getDate(), " +
                "'" + personasAutorizadas.DocumentoUsuarioCreacion + "', '1', '1', '','','" + personasAutorizadas.Telefono + "', '" + personasAutorizadas.Email + "', '" + personasAutorizadas.Placa1 + "'," +
                "'" + personasAutorizadas.Placa2 + "','','','',0)");
                SqlCommand comando = new SqlCommand(cadena,sqlCon);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";

            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open) sqlCon.Close();
            }
            return rta;
            
        }
        public string ActualizarAutoizado(PersonasAutorizadas personasAutorizadas)
        {
            string rta = "";
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                string fechaInicio;
                string fechaFin;
                fechaInicio = personasAutorizadas.FechaInicio.Year + "-" + personasAutorizadas.FechaInicio.Day + "-" + personasAutorizadas.FechaInicio.Month + " 23:59:59";
                fechaFin = personasAutorizadas.FechaFin.Year + "-" + personasAutorizadas.FechaFin.Day + "-" + personasAutorizadas.FechaFin.Month + " 23:59:59";
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("UPDATE T_PersonasAutorizadas SET IdAutorizacion='" + personasAutorizadas.IdAutorizado + "', " +
                    "NombreApellidos='" + personasAutorizadas.NombreApellidos + "', IdTarjeta='" + personasAutorizadas.IdTarjeta + "', " + 
                    "NombreEmpresa='" + personasAutorizadas.NombreEmpresa + "', Nit='" + personasAutorizadas.Nit + "',Estado='" + personasAutorizadas.Estado + 
                    "', FechaInicio='" + fechaInicio + "', " + 
                    "FechaFin='" + fechaFin + "'," + " Telefono='" + personasAutorizadas.Telefono + 
                    "', Email='" + personasAutorizadas.Email + "', Placa1='" + personasAutorizadas.Placa1 + "', Placa2='" + personasAutorizadas.Placa2 + "'," + 
                    " Placa3='" + personasAutorizadas.Placa3+"', Placa4='"+personasAutorizadas.Placa4+"', Placa5='"+personasAutorizadas.Placa5+"' " +
                    "WHERE Documento='"+personasAutorizadas.Documento+"' AND IdEstacionamiento='"+personasAutorizadas.IdEstacionamiento+"'");
                SqlCommand comando = new SqlCommand(cadena,sqlCon); 
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";
            }
            catch (Exception ex)
            {
                throw ex ;
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open) sqlCon.Close();
            }
            return rta;
        }


    }
}
