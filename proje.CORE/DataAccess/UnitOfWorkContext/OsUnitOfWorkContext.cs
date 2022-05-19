using Microsoft.EntityFrameworkCore;
using proje.CORE.DataAccess.BaseContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje.CORE.DataAccess.UnitOfWorkContext
{
    public class OsUnitOfWorkContext : ContextBase, IOsUnitOfWorkContext
    {
        public OsUnitOfWorkContext(DbContext databaseContext)
            : base(databaseContext)
        {

        }
    }
}
