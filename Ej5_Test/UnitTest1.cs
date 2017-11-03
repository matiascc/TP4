using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Ej5;

namespace Ej5_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAgregarYObtener()
        {
            Usuario user = new Usuario();
            user.Codigo = "af4785g";
            user.CorreoElectronico = "algo@algomas.com";
            user.NombreCompleto = "NombreYApellido";
            Lista list = new Lista();
            list.Agregar(user);
            String resultado = list.ObtenerPorCodigo("af4785g").NombreCompleto;

            Assert.AreEqual(resultado, "NombreYApellido");
        }

        [TestMethod]
        public void TestObtenerTodos()
        {
            Usuario user = new Usuario();
            user.Codigo = "af4785g";
            user.CorreoElectronico = "algo@algomas.com";
            user.NombreCompleto = "Yoque Se";

            Usuario user1 = new Usuario();
            user1.Codigo = "af4785p";
            user1.CorreoElectronico = "alg@algomas.com";
            user1.NombreCompleto = "Algo Mas";

            Lista list = new Lista();
            list.Agregar(user);
            list.Agregar(user1);
            List<Usuario> listP = new List<Usuario>();
            listP.Add(user);
            listP.Add(user1);
            Assert.ReferenceEquals(list.ObtenerTodos(), list);
        }

        [TestMethod]
        public void TestActualizar()
        {
            Usuario user = new Usuario();
            user.Codigo = "af4785g";
            user.CorreoElectronico = "algo@algomas.com";
            user.NombreCompleto = "Yoque Se";

            Usuario user1 = new Usuario();
            user1.Codigo = "af4785g";
            user1.CorreoElectronico = "alg@algomas.com";
            user1.NombreCompleto = "Algo Mas";

            Lista list = new Lista();
            list.Agregar(user);
            list.Actualizar(user1);
            Assert.AreEqual(list.ObtenerPorCodigo(user.Codigo), user1);
        }

        [TestMethod]
        public void TestEliminar()
        {
            Usuario user = new Usuario();
            user.Codigo = "af4785g";
            user.CorreoElectronico = "algo@algomas.com";
            user.NombreCompleto = "Yoque Se";

            Lista list = new Lista();
            list.Agregar(user);
            List<Usuario> list1 = new List<Usuario>();
            list.Eliminar(user.Codigo);
            Assert.ReferenceEquals(list, list1);
        }

        [TestMethod]
        public void TestObtenerOrdenadosPor()
        {
            Usuario user = new Usuario();
            user.Codigo = "af4785g";
            user.CorreoElectronico = "algo@algomas.com";
            user.NombreCompleto = "Yoque Se";

            Usuario user1 = new Usuario();
            user1.Codigo = "af4785p";
            user1.CorreoElectronico = "alg@algomas.com";
            user1.NombreCompleto = "Algo Mas";

            Lista list = new Lista();
            list.Agregar(user);
            OrdenPorCodigo codigo = new OrdenPorCodigo();
            List<Usuario> listP = new List<Usuario>();
            listP.Add(user);
            listP.Add(user1);
            listP.Sort(codigo);
            Assert.ReferenceEquals(listP, list.ObtenerOrdenadosPor(codigo));
        }
    }
}
