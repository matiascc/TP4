using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Fachada fachada = new Fachada();

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            try
            {
                Console.WriteLine(fachada.Dividir(num1, num2));                 //Intenta dividir los 2 nº.
            }
            catch(DivisionPorCeroException exc)
            {
                Console.WriteLine("No se puede dividir por cero. \n {0}", exc);     //Si se detecta la excepcion DivisionPorCeroException se escribe un msj y se incluye los datos de la excepcion.
            }

            Console.ReadLine();
        }
    }
}
