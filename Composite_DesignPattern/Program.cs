using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleValue sv = new SingleValue() {Value = 5};
            ManyValues mv = new ManyValues()
            {
                5,
                5
            };

            var list = new List<IValueContainer>()
            {
                sv,
                mv
            };

            Console.WriteLine($"Sum is: {list.Sum()}");
            Console.ReadLine();
        }
    }
}