using System;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mosaicos.LojaVirtual.Dominio.Repositorio;
using WebSiteRico3d2.DominioMosaico;

namespace Mosaicos.LojaVirtual.UnitTest
{
    [TestClass]
    public class TesteCarrinhoCompras
    {
        [TestMethod]
        public void AdiconarItensCarrinho()
        {
            
            //Arrange - criação dos produtos
            const string caminho = @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\";
            const string connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var loja = new LojaMosaicosContext(connectionString1);

            var produto1 = loja.Mosaicos.Create();
            produto1.Nome = "Teste1";

            var produto2 = loja.Mosaicos.Create();
            produto2.Nome = "Teste2";

            var produto3 = loja.Mosaicos.Create();
            produto2.Nome = "Teste3";

            var carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1,1);
            carrinho.AdicionarItem(produto2,1);
            carrinho.AdicionarItem(produto3, 3);

            //Act
            var itens = carrinho.ItensCarrinho.ToArray();

            //Assert
            Assert.AreEqual(itens.Length,3);
            Assert.AreEqual(itens[0].Produto,produto1);
            Assert.AreEqual(itens[1].Produto,produto2);

        }


        [TestMethod]
        public void AdicionarProdutoExistenteParaCarrinho()
        {
            //Arrange - criação dos produtos
            const string caminho = @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\";
            const string connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var loja = new LojaMosaicosContext(connectionString1);

            var produto1 = loja.Mosaicos.Create();
            produto1.Nome = "Teste1";

            var produto2 = loja.Mosaicos.Create();
            produto2.Nome = "Teste2";

            

            var carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);
            carrinho.AdicionarItem(produto1, 10);

            //Act
            var resultado = carrinho.ItensCarrinho.OrderBy(c => c.Produto.Nome).ToArray();

            //Arrange
            Assert.AreEqual(resultado.Length, 2);
            
            Assert.AreEqual(resultado[0].Quantidade,11);

            Assert.AreEqual(resultado[1].Quantidade, 1);

        }

        [TestMethod]
        public void RemoverItensCarrinho()
        {
            //Arrange - criação dos produtos
            const string caminho = @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\";
            const string connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var loja = new LojaMosaicosContext(connectionString1);

            var produto1 = loja.Mosaicos.Create();
            produto1.Nome = "Teste1";

            var produto2 = loja.Mosaicos.Create();
            produto2.Nome = "Teste2";

            var produto3 = loja.Mosaicos.Create();
            produto2.Nome = "Teste3";

            var carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 3);
            carrinho.AdicionarItem(produto3, 5);
            carrinho.AdicionarItem(produto2, 1);

            //Act
            carrinho.RemoverItem(produto2);

            //Assert
            Assert.AreEqual(carrinho.ItensCarrinho.Count(c => c.Produto == produto2), 0);

            Assert.AreEqual(carrinho.ItensCarrinho.Count(),2);

        }

        [TestMethod]
        public void CalcularValorTotal()
        {
            //Arrange - criação dos produtos
            const string caminho = @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\";
            const string connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var loja = new LojaMosaicosContext(connectionString1);

            var produto1 = loja.Mosaicos.Create();
            produto1.Nome = "Teste1";
            produto1.Preco = 100;

            var produto2 = loja.Mosaicos.Create();
            produto2.Nome = "Teste2";
            produto2.Preco = 50;

            var carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);
            carrinho.AdicionarItem(produto1, 3);

            //Act
            decimal resultado = carrinho.ObterValorTotal();

            //Assert
            Assert.AreEqual(resultado,450);

        }

        [TestMethod]
        public void LimparItensCarrinho()
        {
            //Arrange - criação dos produtos
            const string caminho = @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\";
            const string connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var loja = new LojaMosaicosContext(connectionString1);

            var produto1 = loja.Mosaicos.Create();
            produto1.Nome = "Teste1";
            produto1.Preco = 100;

            var produto2 = loja.Mosaicos.Create();
            produto2.Nome = "Teste2";
            produto2.Preco = 50;

            var carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);

            //Act
            carrinho.Limparcarrinho();
            

            //Assert
            Assert.AreEqual(carrinho.ItensCarrinho.Count(),0);


        }

    }
}
