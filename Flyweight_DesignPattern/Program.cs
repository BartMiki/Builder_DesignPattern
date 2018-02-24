using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = new Sentence("Welcome brave new world!");
            sentence[1].Capitalize = true;
            sentence[1].Capitalize = false;
            sentence[1].Capitalize = true;
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
