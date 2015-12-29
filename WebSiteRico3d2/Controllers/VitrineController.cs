using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mosaicos.LojaVirtual.Dominio.Repositorio;
using WebSiteRico3d2.Models;

namespace WebSiteRico3d2.Controllers
{
    public class VitrineController : Controller
    {

        private LojaMosaicosContext _loja;
        private string _caminho;
        
        
        
        
        //string _connectionString = "type=embedded;storesdirectory=" + @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\" + "brightstar;storename=test5";

        

        // GET: Vitrine
        public ActionResult ListaMosaicos(int pagina = 1)
        {
            int mosaicosPorPagina = 3;
            //if (_caminho == null)
            //{
                _caminho = HttpContext.Server.MapPath("~/App_Data/");//(string)TempData["path"]; 
            //}
            
            string connectionString1 = "type=embedded;storesdirectory=" + _caminho + "brightstar;storename=test5";
            _loja = new LojaMosaicosContext(connectionString1);

            var mosaicos = _loja.Mosaicos.Cast<Mosaico>().ToList()
               .OrderBy(p => p.Item)
               .Skip((pagina - 1) * mosaicosPorPagina)
               .Take(mosaicosPorPagina)
               .ToList();

            var model = new MosaicosViewModel();
            model.Mosaicos = mosaicos;
            model.Paginacao = new Paginacao()
            {
                PaginaAtual = pagina,
                ItensPorPagina = mosaicosPorPagina,
                ItensTotal = _loja.Mosaicos.Cast<Mosaico>().ToList().Count
            };

            return View(model);
        }
    }
}