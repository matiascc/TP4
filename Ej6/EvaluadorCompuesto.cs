using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class EvaluadorCompuesto : IEvaluador
    {
        private IList<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {
            this.iEvaluadores = new List<IEvaluador>();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)          //Comprueba para cada evaluador si es valida la solicitud.
        {
            bool esValida = true;           //Se toma como que es valida hasta que alguno de los evaluadores diga lo contrario.

            IEnumerator<IEvaluador> enumerador = iEvaluadores.GetEnumerator();

            while (esValida && enumerador.MoveNext())           //Mientras sea valida sigue comprobando en otros evaluadores.
            {
                esValida = enumerador.Current.EsValida(pSolicitud);
            }

            return esValida;
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);              //Agrega un evaluador a la lista de evaluadores.
        }
    }
}
