using Microsoft.EntityFrameworkCore;
using proje.BUSINESS.Abstract;
using proje.DATAACCESS.Abstract;
using proje.DATAACCESS.Concrete;
using proje.ENTITES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proje.BUSINESS.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonManager(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> ListPerson()
        {
            return _personRepository.GetAll(predicate: x => x.Name == "John Doe", source => source.Include(y => y.Things), orderBy: q => q.OrderBy(d => d.Name)).ToList();
        }

        public List<Person> ListPersonNo()
        {
            throw new NotImplementedException();
        }
    }
}
