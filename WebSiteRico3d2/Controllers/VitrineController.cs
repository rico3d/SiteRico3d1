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
        
        int _mosaicosPorPagina = 3;
        string _connectionString = "type=embedded;storesdirectory=" + @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\" + "brightstar;storename=test5";

        

        // GET: Vitrine
        public ActionResult ListaMosaicos(int pagina = 1)
        {


            _loja = new LojaMosaicosContext(_connectionString);

            var mosaicos = _loja.Mosaicos.Cast<Mosaico>().ToList()
               .OrderBy(p => p.Item)
               .Skip((pagina - 1) * _mosaicosPorPagina)
               .Take(_mosaicosPorPagina)
               .ToList();

            var model = new MosaicosViewModel();
            model.Mosaicos = mosaicos;

            return View(model);
        }
    }
}