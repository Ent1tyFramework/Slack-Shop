using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Slack_Shop.Domain.Entities;
using System.Web;
using Microsoft.Owin;
using Slack_Shop.Identity.Contexts;
using Microsoft.AspNet.Identity.Owin;

namespace Slack_Shop.Identity.Managers
{
    public class AuthUserManager : UserManager<AuthUser>
    {
        public AuthUserManager(UserStore<AuthUser> userStore) : base(userStore) { }

        public static AuthUserManager Create(IdentityFactoryOptions<AuthUserManager> options,
            IOwinContext owinContext)
        {
            return new AuthUserManager(new UserStore<AuthUser>(owinContext.Get<AuthDbContext>()));
        }
    }
}
