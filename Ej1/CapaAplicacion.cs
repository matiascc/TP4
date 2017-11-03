using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaAplicacion
    {
        public void Ejecutar()
        {
            //Intenta crear un objeto de la capa dominio y realiza la operacion ejecutar.
            try
            {
                CapaDominio capa = new CapaDominio();
                capa.Ejecutar();
            }
            //Si falla el try, encontrando la Excepcion ErrorPuntalException Lanza la Excepcion CapaAplicacionException 
            //agregandole un mensaje y sumando el mensaje de la excepcion..
            catch (ErrorPuntualException ex)
            {
                throw new CapaAplicacionException("Mensaje capa aplicacion: \n", ex);
            }
        }
    }
}
