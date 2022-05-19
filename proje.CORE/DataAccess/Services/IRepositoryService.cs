using Microsoft.EntityFrameworkCore;
using proje.CORE.DataAccess.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje.CORE.DataAccess.Services
{
    internal interface IRepositoryService
    {
        DbContext DbContext { get; set; }

        IGenericRepositoryBase<T> GetGenericRepository<T>() where T : class;

        T GetCustomRepository<T>(Func<DbContext, object> factory = null) where T : class;
    }
}
