using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaDominio
    {
        //Crea un objeto de la capa persistencia y realiza la operacion ejecutar.
        public void Ejecutar()
        {
            CapaPersistencia capa = new CapaPersistencia();
            capa.Ejecutar();
        }
    }
}
