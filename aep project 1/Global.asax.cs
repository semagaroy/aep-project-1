﻿using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using aep_project_1.App_Start;

namespace aep_project_1
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}