using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class OrdenPorCodigo : IComparer<Usuario> //Se establece un orden por codigo
    {
        public int Compare(Usuario u1, Usuario u2)        {
            
            int result = u1.Codigo.CompareTo(u2.Codigo);
            return result;
        }   
    }
}
