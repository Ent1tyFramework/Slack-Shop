using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Shop.Data.Contexts
{
    public abstract class DbContext : System.Data.Entity.DbContext
    {
        public DbContext(string connectionString)
            : base(connectionString) { }

        public abstract DbContext GetContext();
    }
}
