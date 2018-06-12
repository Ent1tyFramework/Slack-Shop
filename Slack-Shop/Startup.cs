using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Slack_Shop.Identity.Contexts;
using Slack_Shop.Identity.Managers;

[assembly: OwinStartup(typeof(Slack_Shop.Startup))]

namespace Slack_Shop
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(AuthDbContext.Create);
            app.CreatePerOwinContext<AuthUserManager>(AuthUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/login"),
            });
        }
    }
}
