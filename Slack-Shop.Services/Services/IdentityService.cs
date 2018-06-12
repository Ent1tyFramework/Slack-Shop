using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Slack_Shop.Domain.Entities;
using Slack_Shop.Identity.Managers;
using Slack_Shop.Services.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web;

namespace Slack_Shop.Services.Services
{
    public class IdentityService : IIdentityService
    {
        public UserManager<AuthUser> UserManager { get; }
        public IAuthenticationManager AuthenticationManager { get; }

        public IdentityService(IOwinContext owinContext)
        {
            this.UserManager = owinContext.GetUserManager<AuthUserManager>();
            this.AuthenticationManager = owinContext.Authentication;
        }

        public async Task<bool> SignInAsync(AuthUser user, bool isPersistent)
        {
            try
            {
                user = await UserManager.FindByIdAsync(user.Id);

                if (user != null)
                {
                    var claims = await UserManager.CreateIdentityAsync(user,
                        DefaultAuthenticationTypes.ApplicationCookie);

                    if (AuthenticationManager.User.Identity.IsAuthenticated)
                        AuthenticationManager.SignOut();

                    AuthenticationManager.SignIn(new AuthenticationProperties
                    { IsPersistent = isPersistent }, claims);
                }
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
    }
}
