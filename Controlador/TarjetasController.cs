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

        public static CardResponse LimpiarReposicion(string password)
        {
            CardResponse oCardResponse = new CardResponse();
            if (password == string.Empty)
            {
                oCardResponse.error = true;
            }
            else
            {
                oCardResponse.error = false;
            }
            return oCardResponse;
        }
        public static CardResponse CrearTarjetaAutorizadoSinReposicion(string password)
        {
            ServiciosTarjetas serviciosTarjetas = new ServiciosTarjetas();
            CardResponse oCardResponse = new CardResponse();
            if (password == string.Empty)
            {
                oCardResponse.error = true;
            }
            else
            {
                if (!oCardResponse.error)
                {
                     oCardResponse= serviciosTarjetas.CreateAuthCardRepo(password);
                    if (oCardResponse.error)
                    {
                        oCardResponse.error = true;
                    }
                    
                }
                

            }
            return oCardResponse;
        }
    }
}
