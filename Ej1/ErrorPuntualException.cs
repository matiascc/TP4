using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    //Excepcion que hereda de ApplicationException, la cual hereda su constructor de la clase padre.
    class ErrorPuntualException : ApplicationException //
    {
        public ErrorPuntualException(string message) : base(message)
        {

        }
        public ErrorPuntualException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
