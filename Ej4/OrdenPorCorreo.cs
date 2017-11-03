using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4 //Se establece un orden por correo electronico
{
    class OrdenPorCorreo: IComparer<Usuario>
    {
        public int Compare(Usuario u1, Usuario u2)
        {
            int result = u1.CorreoElectronico.CompareTo(u2.CorreoElectronico);
            return result;
        }
    }
}
