using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Fachada
    {
        private Controlador control = new Controlador();

        internal TipoDocumento ElegirTipoDocumento(int opcion)              //Asigna Tipo de Doc segun opcion y por defecto el DNI.
        {
            switch (opcion)
            {
                case 1:
                    return (TipoDocumento.DNI);
                case 2:
                    return (TipoDocumento.CUIT);
                case 3:
                    return (TipoDocumento.CUIL);
                case 4:
                    return (TipoDocumento.LE);
                case 5:
                    return (TipoDocumento.LC);
                default:
                    Console.WriteLine("nro ingresado es incorrecto, se ha asignado DNI");
                    return (TipoDocumento.DNI);
            }
        }

        internal void DebitarCuentaCorriente(double pSaldo, String pNroDoc)     //Utiliza el metodo de la clase Cuenta que resta un saldo para la cuenta corriente
        {
            control.BuscarCuentasPorDoc(pNroDoc).CuentaCorriente.DebitarSaldo(pSaldo);
        }

        internal void DebitarCajaAhorro(double pSaldo, String pNroDoc)      //Utiliza el metodo de la clase Cuenta que resta un saldo para la caja de ahorro
        {
            control.BuscarCuentasPorDoc(pNroDoc).CajaAhorro.DebitarSaldo(pSaldo);
        }

        internal void AcreditarCuentaCorriente(double pSaldo, String pNroDoc)   //Utiliza el metodo de la clase Cuenta que suma un saldo para la cuenta corriente
        {
            control.BuscarCuentasPorDoc(pNroDoc).CuentaCorriente.AcreditarSaldo(pSaldo);
        }

        internal void AcreditarCajaAhorro(double pSaldo, String pNroDoc)    //Utiliza el metodo de la clase Cuenta que suma un saldo para la caja de ahorro
        {
            control.BuscarCuentasPorDoc(pNroDoc).CajaAhorro.AcreditarSaldo(pSaldo);
        }

        internal void AgregarCliente(TipoDocumento pTipoDocumento, String pNroDocumento, String pNombre)
        {
            control.AgregarCliente(pTipoDocumento, pNroDocumento, pNombre);
        }

        internal Cuentas BuscarCuentasPorDoc(String pNroDoc)
        {
            return control.BuscarCuentasPorDoc(pNroDoc);
        }
        
        internal Boolean ExisteCliente(String pNroDoc)
        {
            return control.ExisteCliente(pNroDoc);
        }

        internal Cliente BuscarClientePorDoc(String pNroDoc)
        {
            return control.BuscarClientePorDoc(pNroDoc);
        }
    }
}
