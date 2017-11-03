using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadCuotasMaximas;

        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            this.iCantidadCuotasMaximas = pCantidadMaxima;
        }

        public Boolean EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.CantidadCuotas <= this.iCantidadCuotasMaximas;        //Si la cantidad de cuotas de la solicitud es menor a la cantidad de cuotas maximas.
        }
    }
}
