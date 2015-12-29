using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebSiteRico3d2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

          
            //1-Inicio Mosaicos
            routes.MapRoute(
                null,
                "",
                new
                {
                    controller = "Vitrine", 
                    action = "ListaMosaicos",
                    categoria = (string)null,
                    pagina = 1
                });

            //2
            routes.MapRoute(
                null,
                "Pagina{pagina}",
                 new
                 {
                     controller = "Vitrine", 
                     action = "ListaMosaicos", 
                     categoria = (string)null},
                      new { pagina = @"\d+" });

            //3
            routes.MapRoute(
              null,
              "{categoria}",
              new
              {
                  controller = "Vitrine",
                  action = "ListaMosaicos",
                  pagina = 1
              });

            //4

            routes.MapRoute(
                null,
                "{categoria}Pagina{pagina}",
                 new
                 {
                     controller = "Vitrine",
                     action = "ListaMosaicos"
                 },
                 new { pagina = @"\d+" });

            //default
            routes.MapRoute(
              "Default",
              "{controller}/{action}/{id}",
              new { controller = "Home", action = "Index", id = UrlParameter.Optional });
            

            
        }
    }
}
