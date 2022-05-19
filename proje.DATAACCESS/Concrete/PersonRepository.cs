using Microsoft.EntityFrameworkCore;
using proje.CORE.DataAccess.RepositoryContext;
using proje.DATAACCESS.Abstract;
using proje.DATAACCESS.Concrete.EntityFrameworkCore.Contexts;
using proje.ENTITES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proje.DATAACCESS.Concrete
{
    public class PersonRepository : GenericRepositoryContext<Person>, IPersonRepository
    {
        public PersonRepository(DataBaseContext dbContext)
              : base(dbContext)
        {

        }
        public void MyNewFunction(int id)
        {
            //Do Something
        }

        public override void Add(Person toAdd)
        {
            MyAdditionalAddFunction();
            base.Add(toAdd);
        }

        private void MyAdditionalAddFunction()
        {
            //Do something else...
        }

        
    }
}
