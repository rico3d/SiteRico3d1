using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mosaicos.LojaVirtual.Dominio.Repositorio;

namespace WebSiteRico3d2.DominioMosaico
{
    public class ItemCarrinho
    {

        public IMosaico Produto { get; set; }

        public int Quantidade { get; set; }

    }
}