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
    public class RepositorioTarjetas
    {
        public string InsertarTarjetaInventario(Tarjetas tarjetas)
        {
            string rta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("INSERT INTO T_Tarjetas(IdEstacionamiento, IdTarjeta, FechaRegistro, DocumentoUsuarioRegistro, Estado)" +
                    "VALUES('" + tarjetas.IdEstacionamiento + "','" + tarjetas.IdTarjeta + "',GETDATE(),'" + tarjetas.DocumentoUsuarioRegistro + "','" + tarjetas.Estado + "')");
                SqlCommand comando = new SqlCommand(cadena, sqlCon);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                rta = "OK";

            }
            catch (Exception ex )
            {

                throw ex ;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rta;
        }
    }
}
