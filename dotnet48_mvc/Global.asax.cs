﻿using System.Web.Mvc;
using System.Web.Routing;

namespace dotnet48_mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "JsonTest" }
            );
        }
    }
}
