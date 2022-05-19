using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje.ENTITES
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Thing> Things { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
