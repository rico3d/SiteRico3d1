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
        //private string _caminho;
        private MosaicosViewModel _model = new MosaicosViewModel();
        
        
        
        //string _connectionString = "type=embedded;storesdirectory=" + @"c:\users\ricardo\documents\visual studio 2013\Projects\WebSiteRico3d2\WebSiteRico3d2\App_Data\" + "brightstar;storename=test5";

        

        // GET: Vitrine
        public ActionResult ListaMosaicos(string nomecategoria, int pagina = 1)
        {
            int mosaicosPorPagina = 3;
            //if (_caminho == null)
            //{
                //_caminho = HttpContext.Server.MapPath("~/App_Data/");//(string)TempData["path"]; 
            //}
            
            //string connectionString1 = "type=embedded;storesdirectory=" + _caminho + "brightstar;storename=test5";
            _loja = new LojaMosaicosContext(WebApiConfig.StrConnectionString);//connectionString1);

            //////////////////////////////////
            //var pesado = new Categoria()
            //{
            //    Nome = "Pesado"
            //};

            //var leve = new Categoria()
            //{
            //    Nome = "Leve"
            //};
          
            

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 1,
            //    Nome = "Mesa-1",
            //    Descricao = "Mesinha decorativa de mosaico de pastilhas e azulejos sobre carretel de madeira. Patinada, envernizadae com pés de rodízios.",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "60 cm de diâmetro X 40 cm de altura.",
            //    Imagem = "imagem",
            //    Categoria = pesado
                
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 2,
            //    Nome = "Mesa-2",
            //    Descricao = "Mesinha decorativa de mosaico de azulejos sobre carretel de madeira. Patinada, envernizada e com pés de rodízios.",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "60 cm de diâmetro X 40 cm de altura",
            //    Imagem = "imagem",
            //    Categoria = pesado
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 3,
            //    Nome = "Porta Lápis",
            //    Descricao = "Conjunto de porta-lápis pra escritório.",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "2 peças",
            //    Imagem = "imagem",
            //    Categoria = pesado
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 4,
            //    Nome = "Girassóis",
            //    Descricao = "Quadro  em mosaico picassiete ( feito com louças recicladas e azulejos antigos) em moldura envelhecida.",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "50 cm X 36 cm",
            //    Imagem = "imagem",
            //    Categoria = pesado
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 5,
            //    Nome = "Janela com Flores",
            //    Descricao = "Quadro  em mosaico picassiete  feito com louças recicladas, pastilhas de vidro e azulejos antigos)sobre placa de mdf",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "65 cm X 39 cm",
            //    Imagem = "imagem",
            //    Categoria = pesado
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 6,
            //    Nome = "Jarro de Flores",
            //    Descricao = "Quadro em mosaico picassiete  feito com louças recicladas e pastilhas de vidro) em moldura de madeira de demolição. ",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "49cm X 40 cm",
            //    Imagem = "imagem",
            //    Categoria = pesado
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 7,
            //    Nome = "Margaridas",
            //    Descricao = "Quadro em mosaico picassiete (feito com louças recicladas e pastilhas de vidro) em moldura de madeira de demolição",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "43 cm X 43 cm",
            //    Imagem = "imagem",
            //    Categoria = leve
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 8,
            //    Nome = "Orquídea",
            //    Descricao = "Quadro em mosaico picassiete ( feito com louças recicladas e pastilhas de vidro) em moldura de madeira envelhecida. ",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "50 cm X 36 cm",
            //    Imagem = "imagem",
            //    Categoria = leve
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 9,
            //    Nome = "Xícara de Amores-perfeitos",
            //    Descricao = "Quadro  em mosaico picassiete ( feito com louças recicladas e pastilhas de vidro) em moldura de madeira envelhecida. ",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "50 cm X 36 cm",
            //    Imagem = "imagem",
            //    Categoria = leve
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 10,
            //    Nome = "Hortênsias",
            //    Descricao = "Quadro em mosaico picassiete ( feito com louças recicladas, azulejos antigos e pastilhas de vidro) em moldura de madeira de demolição. ",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "50 cm X 40 cm",
            //    Imagem = "imagem",
            //    Categoria = leve
            //});

            //_loja.Mosaicos.Add(new Mosaico()
            //{
            //    Item = 11,
            //    Nome = "Tulipas azuis",
            //    Descricao = "Quadro em mosaico picassiete ( feito com louças recicladas, pastilhas e azulejos) em moldura de madeira de demolição. ",
            //    Preco = 420,
            //    Peso = 0,
            //    Dimensao = "47 cm X 37 cm",
            //    Imagem = "imagem",
            //    Categoria = leve
            //});



            //_loja.SaveChanges();




            ////////////////////////////////////
            
            
            _model.Paginacao = new Paginacao()
            {
                PaginaAtual = pagina,
                ItensPorPagina = mosaicosPorPagina,
                ItensTotal = _loja.Mosaicos.Cast<Mosaico>().ToList().Count
            };

            _model.CategoriaAtual = nomecategoria;

            var mosaicos = _loja.Mosaicos.Cast<Mosaico>().ToList()
               .Where(p => nomecategoria == null || p.Categoria.Nome == nomecategoria)
               .OrderBy(p => p.Item)
               .Skip((pagina - 1) * mosaicosPorPagina)
               .Take(mosaicosPorPagina)
               .ToList();

            _model.Mosaicos = mosaicos;
            

            return View(_model);
        }
    }
}