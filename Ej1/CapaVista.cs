using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaVista
    {
        public void Ejecutar()
        {
            //Intenta crear un objeto de la capa controlador y realiza la operacion ejecutar.
            try
            {
                CapaControlador capa = new CapaControlador();
                capa.Ejecutar();
            }
            //Si falla el try, encontrando la Excepcion CapaAplicacionException, escribe por consola un mensaje 
            //y suma el mensaje de la excepcion.
            catch (CapaAplicacionException ex)
            {
                Console.WriteLine("Mensaje capa vista: \n {0} \n", ex);
            }
        }
    }
}
