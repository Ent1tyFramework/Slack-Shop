using Slack_Shop.Domain.Entities;
using System.Data.Entity;

namespace Slack_Shop.Data.Contexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("ShopDb") { }

        public DbSet<Product> Products { get; set; }

        public override DbContext GetContext()
        {
            return new ShopDbContext();
        }
    }
}
