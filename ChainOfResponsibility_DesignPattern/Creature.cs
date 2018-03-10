namespace ChainOfResponsibility_DesignPattern
{
    partial class Program
    {
        public abstract class Creature
        {
            public abstract int Attack { get; set; }
            public abstract int Defense { get; set; }
        }
    }
}
