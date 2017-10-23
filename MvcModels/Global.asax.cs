﻿using MvcModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcModels
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            ValueProviderFactories.Factories.Insert(0, new CustomValueProviderFactory());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
