using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mosaicos.LojaVirtual.Dominio.Repositorio;

namespace WebSiteRico3d2.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public PartialViewResult Menu(string categoriaNome= (string)null)
        {

            ViewBag.CategoriaSelecionada = categoriaNome;
            //string caminho = HttpContext.Server.MapPath("~/App_Data/");
            //string connectionString1 = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
            var repositorio = new LojaMosaicosContext(WebApiConfig.StrConnectionString);
            var categorias = repositorio.Categorias.Select(c => c.Nome).ToList().Distinct().OrderBy(c => c).ToList();


            return PartialView(categorias);
        }
    }
}