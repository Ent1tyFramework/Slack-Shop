using System.Threading.Tasks;
using System.Web.Mvc;

namespace Slack_Shop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public async Task<ActionResult> Main()
        {
            return View();
        }
    }
}