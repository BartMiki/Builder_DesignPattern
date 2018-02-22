using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DesignPattern
{
    public class Square
    {
        public int Side;
    }

    public interface IRectangle
    {
        int Width { get; }
        int Height { get; }
    }

    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }

    public class SquareToRectangleAdapter : IRectangle
    {
        public int Width { get; }

        public int Height { get; }

        public SquareToRectangleAdapter(Square square)
        {
            Width = Height = square.Side;
        }
    }

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
