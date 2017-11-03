using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4 //Esta clase representa usuarios
{
    public class Usuario : IComparable
    {
        private String iCodigo, iNombreCompleto, iCorreoElectronico;

        public String Codigo
        {
            get => iCodigo;
            set => iCodigo = value;
        }

        public String NombreCompleto
        {
            get => iNombreCompleto;
            set => iNombreCompleto = value;
        }

        public String CorreoElectronico
        {
            get => iCorreoElectronico;
            set => iCorreoElectronico = value;
        }

        public int CompareTo(object obj)
        {
            return iCodigo.CompareTo(obj);
        }
    }
}
