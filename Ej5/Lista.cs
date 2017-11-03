using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class Lista : IRepositorioUsuario //Esta clase almacena las instancias del repositorio en una lista.
    {
        private List<Usuario> iUsuarios;

        public Lista()
        {
            this.iUsuarios = new List<Usuario>();
        }

        public void Actualizar(Usuario pUsuario)
        {
            if (iUsuarios.Contains(pUsuario))
            {
                Eliminar(pUsuario.Codigo);
                Agregar(pUsuario);
            }
        }

        public void Agregar(Usuario pUsuario)
        {
            iUsuarios.Add(pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            Usuario usuario = new Usuario();
            foreach (Usuario user in iUsuarios)
            {
                if (pCodigo==user.Codigo)
                {
                    usuario = user;
                }
            }
            iUsuarios.Remove(usuario);
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {          
            iUsuarios.Sort(pComparador);
            return iUsuarios;

        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            foreach (Usuario user in iUsuarios)
            {
                if (pCodigo == user.Codigo)
                {
                    return user;
                }
            }
            return null;
        }

        public IList<Usuario> ObtenerTodos()
        {            
            return iUsuarios;

        }

        public IList<Usuario> BusquedaPorAproximacion(string nombre)
        {
            List<Usuario> usuarios= new List<Usuario>();
            foreach(Usuario user in iUsuarios)
            {
                if (user.NombreCompleto.Contains(nombre))
                {
                    usuarios.Add(user);
                } 
            }
            return usuarios;
        }
    }
}
