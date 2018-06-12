using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Ninject.Modules;
using Slack_Shop.Data.Contexts;
using Slack_Shop.Data.Interfaces;
using Slack_Shop.Data.Managers;
using Slack_Shop.Domain.Entities;
using Slack_Shop.Domain.Interfaces;
using Slack_Shop.Identity.Contexts;
using Slack_Shop.Identity.Managers;

namespace Slack_Shop.Services.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepositoryManager>().To<RepositoryManager>()
                .WithConstructorArgument("dbContext", new ShopDbContext());
        }
    }
}
