using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Mosaicos.LojaVirtual.Dominio.Repositorio;
using WebSiteRico3d2.DominioMosaico;
using WebSiteRico3d2.Models;

namespace WebSiteRico3d2.Controllers
{


    public class CarrinhoController : Controller
    {
        // GET: Carrinho
        public RedirectToRouteResult Adicionar(string Id, string returnUrl)
        {
            //var caminho = HttpContext.Server.MapPath("~/App_Data/");
            //var connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var repositorio = new LojaMosaicosContext(WebApiConfig.StrConnectionString);

            var mosaico = (Mosaico) repositorio.Mosaicos.FirstOrDefault(p => p.Id == Id);
            if (mosaico != null)
            {
                ObterCarrinho().AdicionarItem(mosaico, 1);
            }

            return RedirectToAction("Indice", new {returnUrl});

        }

        private Carrinho ObterCarrinho()
        {
            var carrinho = (Carrinho) Session["Carrinho"];

            if (carrinho == null)
            {
                carrinho = new Carrinho();
                Session["Carrinho"] = carrinho;
            }

            return carrinho;
        }

        public RedirectToRouteResult Remover(string Id, string returnUrl)
        {
            
            //var caminho = HttpContext.Server.MapPath("~/App_Data/");
            //var connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var repositorio = new LojaMosaicosContext(WebApiConfig.StrConnectionString);

            var mosaico = (Mosaico)repositorio.Mosaicos.FirstOrDefault(p => p.Id == Id);

            if (mosaico != null)
            {
                ObterCarrinho().RemoverItem(mosaico);
            }

            return RedirectToAction("Indice", new {returnUrl});

        }

        public ViewResult Indice(string returnUrl)
        {
            return View(new CarrinhoViewModel()
            {
                Carrinho = ObterCarrinho(),
                ReturnUrl = returnUrl
            });
        }

        public PartialViewResult Resumo()
        {
            var carrinho = ObterCarrinho();
            return PartialView(carrinho);
        }

        public ViewResult FecharPedido()
        {
            return View(new Pedido());
        }


    }
}