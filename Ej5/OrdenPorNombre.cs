using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class OrdenPorNombre: IComparer<Usuario> //Se establece un orden por nombre completo
    {
        public int Compare(Usuario u1, Usuario u2)
        {
            int result = u1.NombreCompleto.CompareTo(u2.NombreCompleto);
            return result;
        }
    }
}