using proje.CORE.DataAccess.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace proje.CORE.DataAccess.UnitOfWork
{
    internal interface IOsUnitOfWork : IDisposable
    {
        IGenericRepositoryBase<T> GetRepository<T>() where T : class;

        int Save();

        Task<int> SaveAsync();
    }
}
