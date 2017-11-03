using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class AcreditarDebitarException : Exception
    {
        public AcreditarDebitarException(string message) : base(message)
        {

        }

        public AcreditarDebitarException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
