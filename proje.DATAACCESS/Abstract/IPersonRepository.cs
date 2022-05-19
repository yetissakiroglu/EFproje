using proje.CORE.DataAccess.RepositoryContext;
using proje.ENTITES;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje.DATAACCESS.Abstract
{
    public interface IPersonRepository : IGenericRepositoryContext<Person>
    {
        void MyNewFunction(int id);
    }
}
