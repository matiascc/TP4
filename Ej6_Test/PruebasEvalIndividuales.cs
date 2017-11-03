using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ej6;

namespace Ej6_Test
{
    [TestClass]
    public class PruebasEvalIndividuales
    {
        [TestMethod]
        public void EvalAntiguedadLaboral()
        {
            Empleo iEmpleo= new Empleo(20000, DateTime.Parse("15/02/2017"));
            Cliente iCliente = new Cliente("Raul", "Suarez", DateTime.Parse("20/07/1990"), iEmpleo);
            SolicitudPrestamo iSolicitud = new SolicitudPrestamo(iCliente, 5000, 8);            //Crea una solciitud.

            EvaluadorAntiguedadLaboral iEvaluador = new Ej6.EvaluadorAntiguedadLaboral(6);          //Crea un Evaluador.
            bool iResultado = iEvaluador.EsValida(iSolicitud);                  //Evalua la solicitud con el evaluador creado.
            
            Assert.IsTrue(iResultado);
        }

        [TestMethod]
        public void EvalMonto()
        {
            Empleo iEmpleo = new Empleo(20000, DateTime.Parse("15/02/2017"));
            Cliente iCliente = new Cliente("Raul", "Suarez", DateTime.Parse("20/07/1990"), iEmpleo);
            SolicitudPrestamo iSolicitud = new SolicitudPrestamo(iCliente, 15000, 8);           //Crea una solciitud.

            EvaluadorMonto iEvaluador = new Ej6.EvaluadorMonto(20000);              //Crea un Evaluador.
            bool iResultado = iEvaluador.EsValida(iSolicitud);                  //Evalua la solicitud con el evaluador creado.

            Assert.IsTrue(iResultado);
        }

        [TestMethod]
        public void EvalEdad()
        {
            Empleo iEmpleo = new Empleo(20000, DateTime.Parse("15/02/2017"));
            Cliente iCliente = new Cliente("Raul", "Suarez", DateTime.Parse("20/07/1990"), iEmpleo);
            SolicitudPrestamo iSolicitud = new SolicitudPrestamo(iCliente, 5000, 8);            //Crea una solciitud.

            EvaluadorEdad iEvaluador = new Ej6.EvaluadorEdad(18, 75);               //Crea un Evaluador.
            bool iResultado = iEvaluador.EsValida(iSolicitud);                  //Evalua la solicitud con el evaluador creado.

            Assert.IsTrue(iResultado);
        }

        [TestMethod]
        public void EvalSueldo()
        {
            Empleo iEmpleo = new Empleo(20000, DateTime.Parse("15/02/2017"));
            Cliente iCliente = new Cliente("Raul", "Suarez", DateTime.Parse("20/07/1990"), iEmpleo);
            SolicitudPrestamo iSolicitud = new SolicitudPrestamo(iCliente, 5000, 8);        //Crea una solciitud.

            EvaluadorSueldo iEvaluador = new Ej6.EvaluadorSueldo(5000);             //Crea un Evaluador.
            bool iResultado = iEvaluador.EsValida(iSolicitud);                  //Evalua la solicitud con el evaluador creado.

            Assert.IsTrue(iResultado);
        }

        [TestMethod]
        public void EvalCantCuotas()
        {
            Empleo iEmpleo = new Empleo(20000, DateTime.Parse("15/02/2017"));
            Cliente iCliente = new Cliente("Raul", "Suarez", DateTime.Parse("20/07/1990"), iEmpleo);
            SolicitudPrestamo iSolicitud = new SolicitudPrestamo(iCliente, 8000, 30);           //Crea una solciitud.

            EvaluadorCantidadCuotas iEvaluador = new Ej6.EvaluadorCantidadCuotas(60);           //Crea un Evaluador.
            bool iResultado = iEvaluador.EsValida(iSolicitud);                      //Evalua la solicitud con el evaluador creado.

            Assert.IsTrue(iResultado);
        }
    }
}
