using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class EvaluadorSueldo : IEvaluador
    {
        private double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Cliente.Empleo.Sueldo >= this.iSueldoMinimo;  //Si el sueldo del cliente correspondiente a la solicitud es mayor al sueldo minimo.
        }
    }
}
