using System;
using System.Linq;
using System.Security.Cryptography;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSiteRico3d2.HtmlHelpers;
using WebSiteRico3d2.Models;

namespace Mosaicos.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Take()
        {
            int[] numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var resultado = from num in numeros.Take(5) select num;
            int[] teste = {5, 4, 1, 3, 9};
            CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }


        [TestMethod]
        public void Skip()
        {
            int[] numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var resultado = from num in numeros.Take(5).Skip(2) select num;
            int[] teste = {1, 3, 9};
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        [TestMethod]
        public void TestarPaginacaoCorreta()
        {
            //Arrange
            HtmlHelper ohtml = null;
            var paginacao = new Paginacao()
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };
            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act
            var resultado = ohtml.PageLinks(paginacao, paginaUrl);

            //Assert

            Assert.AreEqual(
               @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
               + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
               + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
               );







        }
    }
}
