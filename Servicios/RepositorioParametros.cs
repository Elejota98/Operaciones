using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RepositorioParametros
    {
        public string ObtenerValorParametrosPorNombre(string nombre, long idEstacionamiento)
        {
            string rta = string.Empty;
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cadena = ("Select valor from T_Parametros Where Codigo ='" + nombre + "' and IdEstacionamiento=" + idEstacionamiento + "");
                SqlCommand comando = new  SqlCommand(cadena,sqlCon);
                sqlCon.Open();
                SqlDataReader rtdo = comando.ExecuteReader();
                if (rtdo.HasRows)
                {
                    while (rtdo.Read())
                    {
                        rta= rtdo[0].ToString();
                    }
                }
                return rta;

            }
            catch (Exception ex )
            {
                throw ex;
                
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open) sqlCon.Close();
            }
        }
    }
    
}
