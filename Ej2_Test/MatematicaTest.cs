using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ej2;

namespace Ej2_Test
{
    [TestClass]
    public class MatematicaTest
    {
        [TestMethod]
        public void TestDividir1()
        {
            double mDividendo = 50;
            double mDivisor = 10;
            double mResultadoEsperado = 5;
            double mResultado;

            Matematica mat = new Matematica();
            mResultado = mat.Dividir(mDividendo, mDivisor);

            Assert.AreEqual(mResultadoEsperado, mResultado);        //Si los resultados son iguales, el test es exitoso.
        }

        [TestMethod]
        public void TestDividir2()
        {
            double mDividendo = 5;
            double mDivisor = 2;
            double mResultadoEsperado = 2.5;
            double mResultado;

            Ej2.Matematica mat = new Ej2.Matematica();
            mResultado = mat.Dividir(mDividendo, mDivisor);

            Assert.AreEqual(mResultadoEsperado, mResultado);        //Si los resultados son iguales, el test es exitoso.
        }

        [TestMethod]
        public void TestDividir3()
        {
            double mDividendo = 10;
            double mDivisor = 20;
            double mResultadoEsperado = 0.5;
            double mResultado;

            Ej2.Matematica mat = new Ej2.Matematica();
            mResultado = mat.Dividir(mDividendo, mDivisor);

            Assert.AreEqual(mResultadoEsperado, mResultado);        //Si los resultados son iguales, el test es exitoso.
        }

        [TestMethod]
        [ExpectedException(typeof(DivisionPorCeroException))]            //Se espera una excepcion de la clase DivisionPorCeroException.
        public void TestDividir4()
        {
            double mDividendo = 5;
            double mDivisor = 0;

            Ej2.Matematica mat = new Ej2.Matematica();
            mat.Dividir(mDividendo, mDivisor);
        }

    }
}
