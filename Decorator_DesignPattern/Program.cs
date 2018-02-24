using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    public class Bird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }

    public class Lizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }

    public class Dragon // no need for interfaces
    {
        private Lizard _lizard = new Lizard();
        private Bird _bird = new Bird();

        public int Age
        {
            get { return _bird.Age; }
            set
            {
                _bird.Age = value;
                _lizard.Age = value;
            }
        }

        public string Fly()
        {
            return _bird.Fly();
        }

        public string Crawl()
        {
            return _lizard.Crawl();
        }
    }

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
