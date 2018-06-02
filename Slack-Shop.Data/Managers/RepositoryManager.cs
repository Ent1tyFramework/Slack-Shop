using Slack_Shop.Data.Contexts;
using Slack_Shop.Data.Interfaces;

namespace Slack_Shop.Data.Managers
{
    public class RepositoryManager : IRepositoryManager
    {
        public DbContext dbContext;

        public RepositoryManager(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IGenericRepository<TEntity> GenericRepository<TEntity>()
            where TEntity : class, IGenericRepository<TEntity>
        {
            return new GenericRepository<TEntity>(dbContext);
        }
    }
}
