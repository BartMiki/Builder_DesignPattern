using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Age = 14;
            ResponsiblePerson rp = new ResponsiblePerson(p);
            Console.WriteLine(rp.Drink());
            Console.WriteLine(rp.Drive());
            Console.WriteLine(rp.DrinkAndDrive());
            Console.ReadLine();
        }
    }
}
