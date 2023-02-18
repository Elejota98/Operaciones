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
    public class RepositorioEstacionamiento
    {
        public DataTable ListarEstacionamiento(Estacionamiento estacionamiento)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("Select IdEstacionamiento, Nombre From T_Estacionamientos where IdEstacionamiento=" + estacionamiento.IdEstacionamiento + "");
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
    }
}
