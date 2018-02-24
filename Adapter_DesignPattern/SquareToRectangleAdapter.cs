namespace Adapter_DesignPattern
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public int Width { get; }

        public int Height { get; }

        public SquareToRectangleAdapter(Square square)
        {
            Width = Height = square.Side;
        }
    }
}