using Microsoft.EntityFrameworkCore;
using proje.CORE.DataAccess.RepositoryBase;
using proje.CORE.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace proje.CORE.DataAccess.UnitOfWork
{
    internal class OsUnitOfWork : IOsUnitOfWork
    {
        private readonly DbContext _dbContext;
        private readonly IRepositoryService _repositoryService;

        public OsUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;

            if (_repositoryService == null)
            {
                _repositoryService = new RepositoryService();
            }

            _repositoryService.DbContext = _dbContext;
        }

        int IOsUnitOfWork.Save()
        {
            return _dbContext.SaveChanges();
        }

        Task<int> IOsUnitOfWork.SaveAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        void IDisposable.Dispose()
        {
            _dbContext.Dispose();
        }

        IGenericRepositoryBase<T> IOsUnitOfWork.GetRepository<T>()
        {
            return _repositoryService.GetGenericRepository<T>();
        }
    }
}
