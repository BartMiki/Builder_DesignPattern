using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Side = 5 };
            var adapter = new SquareToRectangleAdapter(square);
            int area = adapter.Area();
            Console.WriteLine($"Area of IRectangle is: {area}");
        }
    }
}
