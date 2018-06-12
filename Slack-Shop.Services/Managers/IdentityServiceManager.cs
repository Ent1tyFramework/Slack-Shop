using Microsoft.Owin;
using Slack_Shop.Services.Interfaces;
using Slack_Shop.Services.Services;
using System.Web;

namespace Slack_Shop.Services.Managers
{
    public class IdentityServiceManager : IIdentityServiceManager
    {
        private HttpContext httpContext;

        public IdentityServiceManager(HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }

        public IIdentityService IdentityService
            => new IdentityService(httpContext.GetOwinContext());    
    }
}
