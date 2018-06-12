using Slack_Shop.Domain.Entities;
using Slack_Shop.Domain.Enums;
using Slack_Shop.Services.Interfaces;
using System.Threading.Tasks;
using System.Web.Mvc;
using System;

namespace Slack_Shop.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public async Task<ActionResult> Main()
        {

            return View("Main");
        }
    }
}