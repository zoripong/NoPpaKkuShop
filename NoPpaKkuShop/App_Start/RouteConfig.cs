using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using NoPpaKkuShop.Models;

namespace NoPpaKkuShop
{
    public class RouteConfig
    {
        // 김윤영 
        public static void RegisterRoutes(RouteCollection routes)
        {
            CInstance.Initialize();
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
