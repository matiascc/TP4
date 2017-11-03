using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4 //Se establece un orden por nombre completo
{
    class OrdenPorNombre: IComparer<Usuario>
    {
        public int Compare(Usuario u1, Usuario u2)
        {
            int result = u1.NombreCompleto.CompareTo(u2.NombreCompleto);
            return result;
        }
    }
}