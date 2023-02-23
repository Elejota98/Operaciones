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
    public  class ConsignacionController
    {
        public static DataTable BuscarConsignacion(Consignacion consignacion)
        {
            RepositorioConsignacion Datos = new RepositorioConsignacion();
             return Datos.BuscarConsignacion(consignacion);
        }
        public static DataTable ListarTipoDeposito()
        {
            RepositorioConsignacion Datos = new RepositorioConsignacion();
            return Datos.ListarTipoDeposito();
        }
        public static DataTable ListarTipoDepositoPorId(Consignacion consignacion)
        {
            RepositorioConsignacion Datos = new RepositorioConsignacion();
            return Datos.ListarTipoDepositoPorId(consignacion);
        }
        public static string ModificarConsignacion(Consignacion consignacion)
        {
            RepositorioConsignacion Datos = new RepositorioConsignacion();
            if (consignacion.Valor == null)
            {
                return "El valor ingresado no es válido";
            }
            else if (consignacion.IdTipoDeposito == null)
            {
                return "El tipo de consignación no es válido";
            }
            else
            {
                return Datos.ModificarConsignacion(consignacion);
            }


        }

        public static string EliminarConsignacion(Consignacion consignacion)
        {
            RepositorioConsignacion Datos = new RepositorioConsignacion();
            if (consignacion.IdConsignacion == null)
            {
                return "El valor ingresado no es válido";
            }
            else if (consignacion.IdTipoDeposito == null)
            {
                return "El tipo de consignación no es válido";
            }
            else
            {
                return Datos.EliminarConsignacion(consignacion);
            }


        }
    }
}
