using System.Collections.Generic;

namespace ChainOfResponsibility_DesignPattern
{
    partial class Program
    {
        public class Game
        {
            public IList<Creature> Creatures;
            public Game() => Creatures = new List<Creature>();
        }
    }
}
