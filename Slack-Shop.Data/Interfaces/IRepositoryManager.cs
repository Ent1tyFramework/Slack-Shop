using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Shop.Data.Interfaces
{
    public interface IRepositoryManager
    {
        IGenericRepository<TEntity> GenericRepository<TEntity>()
            where TEntity : class, IGenericRepository<TEntity>;
    }
}
