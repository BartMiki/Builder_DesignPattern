namespace Bridge_DesignPattern
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) => Name = "Square";
    }
}