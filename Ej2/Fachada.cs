using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Fachada
    {
        //Metodo que divide 2 numeros.
        internal double Dividir(double num1, double num2)
        {
            Matematica mat = new Matematica();
            return mat.Dividir(num1, num2);
        }
    }
}
