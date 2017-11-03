using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima, iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return (pSolicitud.Cliente.Edad >= this.iEdadMinima && pSolicitud.Cliente.Edad <= this.iEdadMaxima);           //Si la edad del cliente correspondiente a la solicitud se encuentra entre la edad minima y maxima.
        }
    }
}
