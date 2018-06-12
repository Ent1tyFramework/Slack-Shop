using Microsoft.AspNet.Identity;
using Slack_Shop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Shop.Services.Interfaces
{
    public interface IServiceManager
    {
    }

    public interface IDataServiceManager : IServiceManager
    {
        IDataService<TEntity> GetGenService<TEntity>()
          where TEntity : class, IEntity;
    }

    public interface IIdentityServiceManager : IServiceManager
    {
        IIdentityService IdentityService { get; }
    }
}
