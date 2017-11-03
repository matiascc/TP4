using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime now = DateTime.Today;
            int cantMeses = (((now.Year - pSolicitud.Cliente.Empleo.FechaIngreso.Year) * 12) + now.Month - pSolicitud.Cliente.Empleo.FechaIngreso.Month);      //Calcula cantidad de años desde la fecha de ingreso al empleo y lo multiplica por 2 para conseguir los meses de antiguedad.
            return cantMeses >= this.iAntiguedadMinima;                         //Si la cant de meses de antiguedad es mayor a la antiguedad minima.
        }
    }
}
