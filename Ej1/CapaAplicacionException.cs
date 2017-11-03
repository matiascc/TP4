using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    //Excepcion que hereda de ApplicationException, la cual hereda su constructor de la clase padre.
    class CapaAplicacionException : ApplicationException
    {
        public CapaAplicacionException(string message) : base(message)
        {

        }
        public CapaAplicacionException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
