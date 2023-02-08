using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
        public class Conexion
        {
            private static Conexion con = null;
            public SqlConnection CrearConexion()
            {
                SqlConnection cadena = new SqlConnection(ConfigurationManager.ConnectionStrings["AutorizadosApp.Properties.Settings.ConnectionString"].ConnectionString);
                return cadena;
            }
            public static Conexion getInstancia()
            {
                if (con == null)
                {
                    con = new Conexion();
                }
                return con;

            }



        }
    }

