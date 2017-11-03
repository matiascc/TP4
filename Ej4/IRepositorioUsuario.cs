using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    interface IRepositorioUsuario //Implementa lo necesario para hacer uso del patron repository para trabajar con usuarios.  
    {
        void Agregar(Usuario pUsuario);
        void Actualizar(Usuario pUsuario);
        void Eliminar(String pCodigo);
        IList<Usuario> ObtenerTodos();
        Usuario ObtenerPorCodigo(String pCodigo);
        IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
        
    }
}
