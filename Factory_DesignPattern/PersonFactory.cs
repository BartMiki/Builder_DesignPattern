using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
    public class PersonFactory
    {
        private int _numberOfPersons;

        public PersonFactory()
        {
            _numberOfPersons = 0;
        }

        public Person CreatePerson(string name)
        {
            var newPerson = new Person {Id = _numberOfPersons, Name = name};
            _numberOfPersons++;
            return newPerson;
        }
    }
}
