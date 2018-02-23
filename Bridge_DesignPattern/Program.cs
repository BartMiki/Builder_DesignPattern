using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPattern
{
    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public abstract class Shape
    {
        public string Name { get; set; }

        public IRenderer Renderer { get; }

        public Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public override string ToString() => Renderer.WhatToRenderAs.Replace("{Name}", Name);
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) => Name = "Triangle";
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) => Name = "Square";
    }

    public class VectorRenderer : IRenderer
    {
        public VectorRenderer()
        {
            WhatToRenderAs = "Drawing {Name} as lines";
        }
        public string WhatToRenderAs { get; }
    }

    public class RasterRenderer : IRenderer
    {
        public RasterRenderer()
        {
            WhatToRenderAs = "Drawing {Name} as pixels";
        }
        public string WhatToRenderAs { get; }
    }

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
