using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Slack_Shop.Domain.Entities;
using Slack_Shop.Identity.Managers;
using Slack_Shop.Models.ViewModels;
using Slack_Shop.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Slack_Shop.Controllers
{
    public class AccountController : Controller
    {
        private IIdentityServiceManager IdentitySvManager { get; }

        private UserManager<AuthUser> UserManager =>
            HttpContext.GetOwinContext().GetUserManager<AuthUserManager>();

        private IAuthenticationManager AuthManager =>
            HttpContext.GetOwinContext().Authentication; 

        public AccountController(IIdentityServiceManager identitySvManager)
        {
            this.IdentitySvManager = identitySvManager;
        }

        [Route("register")]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("register")]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindAsync(model.UserName, model.Password);

                if (user == null)
                {
                    user = new AuthUser { UserName = model.UserName };

                    var identityResult = await UserManager.CreateAsync(user, model.Password);

                    if (identityResult.Succeeded)
                        return Redirect("/login");
                    else identityResult.Errors.ToList().ForEach(e => ModelState.AddModelError("", e));
                }
                else ModelState.AddModelError("", "User already exists");
            }

            return View("Register");
        }

        [Route("login")]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;

            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("login")]
        public async Task<ActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var identityService = IdentitySvManager.IdentityService;

                var user = await UserManager.FindAsync(model.UserName, model.Password);

                if (user != null)
                {
                    bool isSigned = await identityService.SignInAsync(user, false);

                    if (isSigned)
                    {
                        if (!String.IsNullOrEmpty(returnUrl))
                            return Redirect(returnUrl);
                        else return Redirect("/home");
                    }
                    else ModelState.AddModelError("", "Something went wrong");
                }
                else ModelState.AddModelError("", "Invalid login or password");
            }

            return View("Login");
        }
    }
}