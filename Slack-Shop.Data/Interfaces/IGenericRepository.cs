using Slack_Shop.Domain.Interfaces;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Slack_Shop.Data.Interfaces
{
    public interface IGenericRepository<TEntity> : IRepository
         where TEntity : class, IEntity
    {
        TEntity First(Func<TEntity, bool> func);

        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> expression);

        Task AddAsync(TEntity entity);
    }
}
