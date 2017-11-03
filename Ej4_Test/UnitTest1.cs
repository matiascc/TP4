using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Ej4;

namespace Ej4_Test
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
            Diccionario dic = new Diccionario();
            dic.Agregar(user);
            String resultado = dic.ObtenerPorCodigo("af4785g").NombreCompleto;

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

            Diccionario dic = new Diccionario();
            dic.Agregar(user);
            dic.Agregar(user1);
            List<Usuario> list = new List<Usuario>();
            list.Add(user);
            list.Add(user1);
            Assert.ReferenceEquals(dic.ObtenerTodos(), list);
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

            Diccionario dic = new Diccionario();
            dic.Agregar(user);
            dic.Actualizar(user1);
            Assert.AreEqual(dic.ObtenerPorCodigo(user.Codigo),user1);
        }

        [TestMethod]
        public void TestEliminar()
        {
            Usuario user = new Usuario();
            user.Codigo = "af4785g";
            user.CorreoElectronico = "algo@algomas.com";
            user.NombreCompleto = "Yoque Se";

            Diccionario dic = new Diccionario();
            dic.Agregar(user);
            Diccionario dic1 = new Diccionario();
            dic.Eliminar(user.Codigo);
            Assert.ReferenceEquals(dic,dic1);
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

            Diccionario dic = new Diccionario();
            dic.Agregar(user);
            OrdenPorCodigo codigo = new OrdenPorCodigo();            
            List<Usuario> list = new List<Usuario>();
            list.Add(user);
            list.Add(user1);
            list.Sort(codigo);
            Assert.ReferenceEquals(list,dic.ObtenerOrdenadosPor(codigo));
        }
    }
}
