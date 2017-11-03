using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Cuenta
    {
        private double iSaldo, iAcuerdo;

        public Cuenta(double pAcuerdo)
        {
            iSaldo = 0;
            iAcuerdo = pAcuerdo;
        }

        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            iSaldo = pSaldoInicial;
            iAcuerdo = pAcuerdo;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            if (pSaldo <= 1000000)
            {
                this.iSaldo += pSaldo;
            }
            else
            {
                throw new AcreditarDebitarException("Para cuentas normales no se permite acreditar montos mayores a 1 millon de pesos");
            }
        }

        public void DebitarSaldo(double pSaldo)
        {
            if (this.iSaldo + this.iAcuerdo >= pSaldo)      //Si el monto pedido no sobrepasa el saldo mas el acuerdo se realiza el debito.
            {
                this.iSaldo -= pSaldo;
            }
            else
            {
                throw new AcreditarDebitarException("El monto ingresado es mayor al saldo disponible mas el acuerdo de descubierto");
            }

        }
    }
}
