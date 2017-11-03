using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public interface IEvaluador
    {
        bool EsValida(SolicitudPrestamo pSolicitud);        //Interface para el metodo EsValido a implementar en cada Evaluador.
    }
}
