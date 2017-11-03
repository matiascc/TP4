using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class Matematica
    {
        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivisionPorCeroException("El segundo numero no puede ser cero");          //Lanza la excepcion DivisionPorCeroException.
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
