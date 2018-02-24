using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragon = new Dragon();
            for (int i = 0; i < 3; i++)
            {
                dragon.Age = 5 * i;
                Console.WriteLine($"Dragon's age:{dragon.Age}. Can fly? {dragon.Fly()}. Can crawl? {dragon.Crawl()}.");
            }

            Console.ReadLine();
        }
    }
}
