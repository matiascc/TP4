using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class DivisionPorCeroException : Exception
    {
        //El constructor invoca al constructor de la clase Exception.
        public DivisionPorCeroException(string message) : base(message) {}
    }
}
