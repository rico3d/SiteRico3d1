using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using BrightstarDB.Client;
using Mosaicos.LojaVirtual.Dominio.Repositorio;
using VDS.RDF.Storage;
using WebSiteRico3d2.Models;

namespace WebSiteRico3d2.Controllers
{
    public class HomeController : Controller
    {
        private LojaMosaicosContext _loja;
        
        public ActionResult Index()
        {
            TempData["path"] = HttpContext.Server.MapPath("~/App_Data/");
            TempData.Keep("path");

            return View();
        }

        public ActionResult About(int pagina = 1)
        {
            ViewBag.Message = "Your application description page.";
            //var path = (string) TempData["path"];

            //var connectionString = ; "type=embedded;storesdirectory=" + path + "brightstar;storename=test5";
            _loja = new LojaMosaicosContext(WebApiConfig.StrConnectionString);
           
            
             
            

            int mosaicosPorPagina = 3;

            //var mosaicos = ;
                //.OrderBy(p => p.Item);
                //.Skip((pagina - 1)*mosaicosPorPagina)
                //.Take(mosaicosPorPagina);



            var model = new MosaicosViewModel();

            var mosaicos = _loja.Mosaicos.Cast<Mosaico>().ToList()
                .OrderBy(p => p.Item)
                .Skip((pagina - 1) * mosaicosPorPagina)
                .Take(mosaicosPorPagina)
                .ToList();

            model.Mosaicos = mosaicos;
            model.Paginacao = new Paginacao()
            {
                PaginaAtual = pagina,
                ItensPorPagina = mosaicosPorPagina,
                ItensTotal = _loja.Mosaicos.Cast<Mosaico>().ToList().Count
            };
           

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste()
        {
            
            return View();
        }


        public ActionResult Saibamais()
        {

            return View();
        }

        
        // GET: Produtos
        

    }
}