using Slack_Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Shop.Services
{
    public class GenericService<TEntity>
    {
        private readonly IRepositoryManager repositoryManager;

        public GenericService()
        {

        }
    }
}
