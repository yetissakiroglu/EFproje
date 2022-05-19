using Microsoft.EntityFrameworkCore;
using proje.CORE.DataAccess.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje.CORE.DataAccess.Services
{
    internal class RepositoryService : IRepositoryService
    {
        public DbContext DbContext { get; set; }

        private readonly Factory _factory;
        protected Dictionary<Type, object> Repositories { get; private set; }

        public RepositoryService()
        {
            _factory = new Factory();
            Repositories = new Dictionary<Type, object>();
        }

        public IGenericRepositoryBase<T> GetGenericRepository<T>() where T : class
        {
            Func<DbContext, object> repositoryFactoryForEntityTypeDelegate = _factory.GetRepositoryFactoryForEntityType<T>();
            return GetCustomRepository<IGenericRepositoryBase<T>>(repositoryFactoryForEntityTypeDelegate);
        }

        public virtual T GetCustomRepository<T>(Func<DbContext, object> factory = null) where T : class
        {
            object repository;
            Repositories.TryGetValue(typeof(T), out repository);
            if (repository != null)
            {
                return (T)repository;
            }
            return CreateRepository<T>(factory, DbContext);
        }

        private T CreateRepository<T>(Func<DbContext, object> factory, DbContext dbContext)
        {
            Func<DbContext, object> repositoryFactory;
            if (factory != null)
            {
                repositoryFactory = factory;
            }
            else
            {
                repositoryFactory = _factory.GetRepositoryFactoryFromCache<T>();
            }
            if (repositoryFactory == null)
            {
                throw new NotSupportedException(typeof(T).FullName);
            }
            T repository = (T)repositoryFactory(dbContext);
            Repositories[typeof(T)] = repository;
            return repository;
        }
    }
}
