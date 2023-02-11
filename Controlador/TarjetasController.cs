using Modelo;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class TarjetasController
    {
        public static string InsertarTarjetaInventario(Tarjetas tarjetas)
        {
            RepositorioTarjetas Datos = new RepositorioTarjetas();
            if(tarjetas.IdTarjeta == string.Empty)
            {
                return "Error al guardar la información tarjeta";
            }
            else if (tarjetas.Estado == false)
            {
                tarjetas.Estado = true;
            }
            return Datos.InsertarTarjetaInventario(tarjetas);

        }
    }
}
