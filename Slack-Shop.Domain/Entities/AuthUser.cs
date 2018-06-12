using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Slack_Shop.Domain.Interfaces;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Slack_Shop.Domain.Entities
{
    public class AuthUser : IdentityUser
    {
    }
}
