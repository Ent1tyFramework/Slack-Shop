using Slack_Shop.Data.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using Slack_Shop.Domain.Interfaces;

namespace Slack_Shop.Data.Entities
{
    public class GenericRepository<TEntity>
        : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private Slack_Shop.Data.Contexts.DbContext dbContext;

        public GenericRepository(Contexts.DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public TEntity First(Func<TEntity, bool> func)
        {
            using (dbContext = dbContext.GetContext())
            {
                return dbContext.Set<TEntity>().FirstOrDefault(func);
            }
        }

        public async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> expression)
        {
            using (dbContext = dbContext.GetContext())
            {
                return await dbContext.Set<TEntity>().FirstOrDefaultAsync(expression);
            }
        }

        public async Task AddAsync(TEntity entity)
        {
            using (dbContext = dbContext.GetContext())
            {
                dbContext.Set<TEntity>().Add(entity);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
