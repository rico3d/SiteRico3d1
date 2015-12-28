using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebSiteRico3d2.Models;

namespace WebSiteRico3d2.HtmlHelpers
{
    public static class  PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {

            var resultado = new StringBuilder();

            for (int i = 0; i < paginacao.TotalPaginas; i++)
            {
                var tag = new TagBuilder("a");
                tag.MergeAttribute("href",paginaUrl(i));
                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);
            }

            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}