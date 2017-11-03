using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class Fachada
    {
        public bool EsValida(String pNombre, String pApellido, DateTime pFechaNac, double pSueldo, DateTime pFechaIngreso,
            TipoCliente pTipoCliente, double pMonto, int pCantCuotas)
        {
            GestorPrestamos gestor = new GestorPrestamos();     //Crea un gestor de prestamos.

            Empleo iEmpleo = new Empleo(pSueldo, pFechaIngreso);                //Crea un empleo.
            Cliente cli = new Cliente(pNombre, pApellido, pFechaNac, iEmpleo);          //Crea un Cliente.
            cli.TipoCliente = pTipoCliente;

            SolicitudPrestamo sol = new SolicitudPrestamo(cli, pMonto, pCantCuotas);    //Crea una solicitud.

            return gestor.EsValida(sol);            //Valida la solicitud.
        }


    }
}
