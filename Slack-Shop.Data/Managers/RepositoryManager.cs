using Slack_Shop.Data.Contexts;
using Slack_Shop.Data.Entities;
using Slack_Shop.Data.Interfaces;
using Slack_Shop.Domain.Interfaces;

namespace Slack_Shop.Data.Managers
{
    public class RepositoryManager : IRepositoryManager
    {
        public DbContext dbContext;

        public RepositoryManager(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IGenericRepository<TEntity> GetGenRepository<TEntity>()
            where TEntity : class, IEntity
        {
            return new GenericRepository<TEntity>(dbContext);
        }
    }
}
