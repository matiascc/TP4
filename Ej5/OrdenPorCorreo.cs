using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class OrdenPorCorreo: IComparer<Usuario> //Se establece un orden por correo electronico
    {
        public int Compare(Usuario u1, Usuario u2)
        {
            int result = u1.CorreoElectronico.CompareTo(u2.CorreoElectronico);
            return result;
        }
    }
}
