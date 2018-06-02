using Slack_Shop.Data.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Slack_Shop.Data
{
    public class GenericRepository<TEntity>
        : IGenericRepository<TEntity> where TEntity : class
    {
        private Contexts.DbContext dbContext;

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
    }
}
