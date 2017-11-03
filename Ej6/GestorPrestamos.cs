using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class GestorPrestamos
    {
        private IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamos ()
        {
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();        //Crea un diccionario correspondiendo a cada tipo de cliente un Evaluador Compuesto.

            this.iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, this.CrearEvaluadoresNoCliente());
            
            this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, this.CrearEvaluadoresCliente());

            this.iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, this.CrearEvaluadoresClienteGold());

            this.iEvaluadoresPorCliente.Add(TipoCliente.ClientePremium, this.CrearEvaluadoresClientePremium());
        }

        private IEvaluador CrearEvaluadoresNoCliente()              //Crea un evaluador compuesto para un NoCliente.
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();
            
            evaluadorCompuesto.AgregarEvaluador(new EvaluadorCantidadCuotas(12));
            
            evaluadorCompuesto.AgregarEvaluador(new EvaluadorMonto(20000));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorEdad(18,75));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorSueldo(5000));

            return evaluadorCompuesto;
        }

        private IEvaluador CrearEvaluadoresCliente()            //Crea un evaluador compuesto para un Cliente.
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorCantidadCuotas(32));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorMonto(100000));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorEdad(18, 75));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorSueldo(5000));

            return evaluadorCompuesto;
        }

        private IEvaluador CrearEvaluadoresClienteGold()          //Crea un evaluador compuesto para un Cliente Gold.
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorMonto(150000));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorEdad(18, 75));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorSueldo(5000));

            return evaluadorCompuesto;
        }

        private IEvaluador CrearEvaluadoresClientePremium()         //Crea un evaluador compuesto para un Cliente Premium.
        {
            EvaluadorCompuesto evaluadorCompuesto = new EvaluadorCompuesto();

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorMonto(200000));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorEdad(18, 75));

            evaluadorCompuesto.AgregarEvaluador(new EvaluadorSueldo(5000));

            return evaluadorCompuesto;
        }

        public Boolean EsValida(SolicitudPrestamo pSolicitud)           //Implementacion del metodo de la interface IEvaluador.
        {
            IEvaluador evaluador = this.iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente];     //Selecciona el evaluador correspondiente al tipo de cliente de la solicitud.

            return evaluador.EsValida(pSolicitud);              //Verifica si es valida la solicitud, con respecto a ese evaluador.
        }
    }
}
