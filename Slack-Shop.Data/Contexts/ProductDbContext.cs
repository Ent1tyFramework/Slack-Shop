using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Shop.Data.Contexts
{
    internal class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("ProductDb") { }

        public DbSet<Product> Products { get; set; }

        public override DbContext GetContext()
        {
            return new ProductDbContext();
        }
    }
}
