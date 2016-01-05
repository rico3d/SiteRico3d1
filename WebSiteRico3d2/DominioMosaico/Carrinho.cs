using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mosaicos.LojaVirtual.Dominio.Repositorio;

namespace WebSiteRico3d2.DominioMosaico
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itensCarrinho = new List<ItemCarrinho>();

        //Adiconar
        public void AdicionarItem(IMosaico produto, int quantidade)
        {
            ItemCarrinho item = _itensCarrinho.FirstOrDefault(p => p.Produto.Id == produto.Id);
            if (item == null)
            {
                _itensCarrinho.Add(new ItemCarrinho()
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }
        }

        //Remover
        public void RemoverItem(IMosaico produto)
        {
            _itensCarrinho.RemoveAll(l => l.Produto.Id == produto.Id);
        }

        //Obter Valor total
        public decimal ObterValorTotal()
        {
            return _itensCarrinho.Sum(e => e.Produto.Preco*e.Quantidade);
        }

        //Limpar carrinho

        public void Limparcarrinho()
        {
            _itensCarrinho.Clear();
        }

        //Itens carrinho
        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get { return _itensCarrinho; }
        }

    }
}