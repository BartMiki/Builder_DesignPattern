using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonFactory personFactory = new PersonFactory();
            List<Person> persons = new List<Person>();
            persons.Add(personFactory.CreatePerson("Adam"));
            persons.Add(personFactory.CreatePerson("Basia"));
            persons.Add(personFactory.CreatePerson("Cyryl"));

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Id}: {person.Name}");
            }
        }
    }
}
