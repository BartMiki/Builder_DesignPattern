using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Triangle(new RasterRenderer()).ToString());
            Console.WriteLine(new Square(new VectorRenderer()).ToString());
            Console.ReadLine();
        }
    }
}
