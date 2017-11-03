using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5 //Esta clase representa usuarios
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

        public override bool Equals(object obj)
        {
            Usuario user = obj as Usuario;

            return user.Codigo == this.Codigo;
        }

        public override int GetHashCode()
        { 
            return this.Codigo.GetHashCode();
        }
    }
}
