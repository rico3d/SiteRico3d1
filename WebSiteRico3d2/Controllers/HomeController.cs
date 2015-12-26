using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
        }

        public ViewResult About(int pagina = 1)
        {
            ViewBag.Message = "Your application description page.";
            string path = HttpContext.Server.MapPath("~/App_Data/");

            var connectionString = "type=embedded;storesdirectory=" + path + "brightstar;storename=test4";
            _loja = new LojaMosaicosContext(connectionString);
             
            //_loja.Mosaicos.Add(new Mosaico()
            //{
               //Descricao = "NewDescricao",
               //Nome = "NewNome",
             //});

            //_loja.SaveChanges();

            var model = new MosaicosViewModel()
            {
                Mosaicos = _loja.Mosaicos.Cast<Mosaico>()
            };

            //var mosaicos = 

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