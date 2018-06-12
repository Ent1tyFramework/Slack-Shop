using Microsoft.AspNet.Identity.EntityFramework;
using Slack_Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Shop.Identity.Contexts
{
    public class AuthDbContext : IdentityDbContext<AuthUser>
    {
        public AuthDbContext() : base("ShopIdentityDb") { }

        public static AuthDbContext Create()
        {
            return new AuthDbContext();
        }
    }
}
