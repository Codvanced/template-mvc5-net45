﻿using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace NAME_REPLACE.WebMvcApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            IoCFrameworkConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}
