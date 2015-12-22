using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mosaicos.LojaVirtual.Dominio.Repositorio;

namespace WebSiteRico3d2.Controllers
{
    public class HomeController : Controller
    {
        private LojaMosaicosContext _loja;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            _loja = new LojaMosaicosContext();
            var mosaicos = _loja.Mosaicos;
            return View(mosaicos);
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