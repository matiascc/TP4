using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ej6;

namespace Ej6_Test
{
    [TestClass]
    public class PruebasSolicitudes
    {
        [TestMethod]
        public void SolicitudNoClienteCorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"), 
                                TipoCliente.NoCliente, 5000, 8);        //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsTrue(iResultado);                              //La prueba es exitosa si el resultado es verdadero.
        }

        [TestMethod]
        public void SolicitudNoClienteIncorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"),
                                TipoCliente.NoCliente, 25000, 8);       //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsFalse(iResultado);                             //La prueba es exitosa si el resultado es falso.
        }

        [TestMethod]
        public void SolicitudClienteCorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"),
                                TipoCliente.Cliente, 80000, 25);        //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsTrue(iResultado);                              //La prueba es exitosa si el resultado es verdadero.
        }

        [TestMethod]
        public void SolicitudClienteIncorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"),
                                TipoCliente.Cliente, 80000, 50);        //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsFalse(iResultado);                             //La prueba es exitosa si el resultado es falso.
        }

        [TestMethod]
        public void SolicitudClienteGoldCorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"),
                                TipoCliente.ClienteGold, 80000, 50);        //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsTrue(iResultado);                                  //La prueba es exitosa si el resultado es verdadero.
        }

        [TestMethod]
        public void SolicitudClienteGoldIncorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"),
                                TipoCliente.ClienteGold, 180000, 25);       //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsFalse(iResultado);                                 //La prueba es exitosa si el resultado es falso.
        }

        [TestMethod]
        public void SolicitudClientePremiumCorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"),
                                TipoCliente.ClientePremium, 180000, 40);        //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsTrue(iResultado);                                      //La prueba es exitosa si el resultado es verdadero.
        }

        [TestMethod]
        public void SolicitudClientePremiumIncorrecta()
        {
            Fachada iFachada = new Fachada();
            bool iResultado = iFachada.EsValida("Raul", "Suarez", DateTime.Parse("20/07/1990"), 20000, DateTime.Parse("15/02/2017"),
                                TipoCliente.ClientePremium, 180000, 70);        //Llama a la fachada para verificar si es valida la solicitud.
            Assert.IsFalse(iResultado);                                     //La prueba es exitosa si el resultado es falso.
        }
    }
}
