using Slack_Shop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Shop.Data.Interfaces
{
    public interface IRepositoryManager
    {
        IGenericRepository<TEntity> GetGenRepository<TEntity>()
            where TEntity : class, IEntity;
    }
}
