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

            //default
            routes.MapRoute(
                name: "Default", 
                url: "{controller}/{action}/{id}", 
                defaults: new { controller = "Home", 
                  action = "Index", 
                  id = UrlParameter.Optional });
          
            //1-Inicio Mosaicos
            routes.MapRoute(
                name: null,
                url: "{controller}/{action}", 
                defaults: new
                {
                    controller = "Vitrine", 
                    action = "ListaMosaicos",
                    categoria = (string)null,
                    pagina = 1
                });

            //2
            routes.MapRoute(
                name: null,
                url: "{controller}/{action}/Pagina{pagina}", 
                defaults: new
                 {
                     controller = "Vitrine", 
                     action = "ListaMosaicos", 
                     categoria = (string)null}, 
                     constraints: new { pagina = @"\d+" });

            //3
            routes.MapRoute(
                name: null,
                url: "{controller}/{action}/{categoria}", 
                defaults: new
              {
                  controller = "Vitrine",
                  action = "ListaMosaicos",
                  pagina = 1
              });

            //4

            routes.MapRoute(
                name: null,
                url: "{controller}/{action}/{categoria}/Pagina{pagina}", 
                defaults: new
                 {
                     controller = "Vitrine",
                     action = "ListaMosaicos"
                 }, 
                 constraints: new { pagina = @"\d+" });

            
            

            
        }
    }
}
