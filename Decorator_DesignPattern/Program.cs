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
        private Lizard lizard = new Lizard();
        private Bird bird = new Bird();

        public int Age
        {
            // todo :)
        }

        public string Fly()
        {
            // todo
        }

        public string Crawl()
        {
            // todo
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
