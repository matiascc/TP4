using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class Diccionario //Esta clase almacena las instancias del repositorio en un diccionario.
    {
        private IDictionary<String, Usuario> iUsuarios;

        public Diccionario()
        {
            this.iUsuarios = new Dictionary<String,Usuario>();
        }
        
        public void Actualizar(Usuario pUsuario)
        {
            iUsuarios[pUsuario.Codigo] = pUsuario;

        }              

        public void Agregar(Usuario pUsuario)
        {
            iUsuarios.Add(pUsuario.Codigo, pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            iUsuarios.Remove(pCodigo);
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> ListaUsuarios = new List<Usuario>(iUsuarios.Values);
            ListaUsuarios.Sort(pComparador);
            return ListaUsuarios;

        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {            
            return iUsuarios[pCodigo];
        }

        public IList<Usuario> ObtenerTodos()
        {
            List<Usuario> aux = new List<Usuario>();
            foreach (Usuario Valor in iUsuarios.Values)
            {
                aux.Add(Valor);
            }
            return aux;
        }
    }
}
