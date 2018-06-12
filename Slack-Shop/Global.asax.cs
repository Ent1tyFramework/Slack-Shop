using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using Slack_Shop.Infrastructure;
using Slack_Shop.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Slack_Shop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //dependency injection
            var webModule = new WebModule();
            var serviceModule = new ServiceModule();

            var kernel = new StandardKernel(webModule, serviceModule);
            kernel.Unbind<ModelValidatorProvider>();

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
