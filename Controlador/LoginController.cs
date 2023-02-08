using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class LoginController
    {
        public static DataTable Login(Login login)
        {
            RepositorioLogin Datos = new RepositorioLogin();
            return Datos.Login(login);
        }
        public static DataTable Estacionamiento()
        {
            RepositorioLogin Datos = new RepositorioLogin();
            return Datos.ListarEstacionamiento();
        }
    }
}
