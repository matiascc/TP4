using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    public class Cliente
    {
        private String iNombre, iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente;
        private Empleo iEmpleo;

        public Cliente (String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iTipoCliente = TipoCliente.NoCliente;          //Por defecto el cliente es de tipo NoCliente.
            this.iEmpleo = pEmpleo;
        }

        public String Nombre { get { return iNombre; } }

        public String Apellido { get { return iApellido; } }

        public DateTime FechaNacimiento { get { return iFechaNacimiento; } }

        public int Edad
        {
            get {
                DateTime now = DateTime.Today;
                int age = now.Year - iFechaNacimiento.Year;                 
                if (now < iFechaNacimiento.AddYears(age)) age--;            //Resta un año si todavia no cumplio años en el año actual.
                return age;
                }
        }

        public Empleo Empleo { get { return iEmpleo; } }

        public TipoCliente TipoCliente
        {
            get { return iTipoCliente; }
            set { iTipoCliente = value; }
        }

    }
}
