using proje.ENTITES;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje.BUSINESS.Abstract
{
    public interface IPersonService
    {
        List<Person> ListPerson();
        List<Person> ListPersonNo();

    }
}
