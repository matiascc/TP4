using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente, iCajaAhorro;

        public Cuentas(Cliente pCliente)
        {
            this.iCliente = pCliente;
        }

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
            set { this.iCuentaCorriente = value; }
        }

        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
            set { this.iCajaAhorro = value; }
        }

        public Cliente Cliente
        {
            get { return this.iCliente; }
        }
    }
}
