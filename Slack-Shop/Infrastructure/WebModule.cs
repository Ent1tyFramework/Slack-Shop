using Microsoft.Owin;
using Ninject.Modules;
using Slack_Shop.Services.Interfaces;
using Slack_Shop.Services.Managers;
using System.Web;

namespace Slack_Shop.Infrastructure
{
    public class WebModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataServiceManager>().To<DataServiceManager>();
            Bind<IIdentityServiceManager>().To<IdentityServiceManager>()
                .WithConstructorArgument("owinContext", HttpContext.Current);
        }
    }
}