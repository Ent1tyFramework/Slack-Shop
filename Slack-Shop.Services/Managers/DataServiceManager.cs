using Microsoft.AspNet.Identity;
using Slack_Shop.Data.Interfaces;
using Slack_Shop.Domain.Interfaces;
using Slack_Shop.Services.Interfaces;
using Slack_Shop.Services.Services;

namespace Slack_Shop.Services.Managers
{
    public class DataServiceManager : IDataServiceManager
    {
        private readonly IRepositoryManager repositoryManager;

        public DataServiceManager(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public IDataService<TEntity> GetGenService<TEntity>()
           where TEntity : class, IEntity
        {
            return new DataService<TEntity>(repositoryManager);
        }
    }
}
