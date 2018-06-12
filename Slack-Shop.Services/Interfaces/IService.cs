using Microsoft.Owin.Security;
using Slack_Shop.Domain.Entities;
using Slack_Shop.Domain.Interfaces;
using System.Threading.Tasks;

namespace Slack_Shop.Services.Interfaces
{
    public interface IService
    { }

    public interface IDataService<TEntity> : IService 
        where TEntity : class, IEntity
    {
        Task<bool> AddAsync(TEntity entity);
    }

    public interface IIdentityService : IService 
    {
        int GetAuthManagerHasCode();
        int GetUserManagerHasCode();
        Task<bool> SignInAsync(AuthUser user, bool isPersistent);
    }
}
