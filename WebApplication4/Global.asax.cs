using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IContainer Container { get; set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            ContainerBuilder builder = new ContainerBuilder();
            //builder.Register(c=> new server("sectionName")).As<Iserver>();
            builder.RegisterType<server>().As<Iserver>();

            Container= builder.Build();

        }
    }
}
