using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaPersistencia
    {
        //Lanza excepcion ErrorPuntualException con un mensaje y le agrega la fecha actual.
        public void Ejecutar()
        {
            throw new ErrorPuntualException("Mensaje capa persistencia. " + DateTime.Now.ToString());         
        }
    }
}
