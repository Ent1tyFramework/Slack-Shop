using Slack_Shop.Data.Interfaces;
using Slack_Shop.Domain.Interfaces;
using Slack_Shop.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Slack_Shop.Services
{
    public class DataService<TEntity> : IDataService<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IRepositoryManager repositoryManager;

        public DataService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            if (entity == null)
                return false;
            try
            {
                await repositoryManager.GetGenRepository<TEntity>().AddAsync(entity);

                return true;
            }
            catch(Exception ex)
            { return false; }
        }
    }
}
