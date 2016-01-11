using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BrightstarDB;

namespace WebSiteRico3d2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var caminho = HttpContext.Current.Server.MapPath("~/App_Data/");
            StrConnectionString = "type=embedded;storesdirectory=" + caminho + "brightstar;storename=test5";
        }

        public static string StrConnectionString { get; private set; }
    }
}