using System.Collections.Generic;

namespace ChainOfResponsibility_DesignPattern
{
    public class Game
    {
        public IList<Creature> Creatures;
        public Game() => Creatures = new List<Creature>();
    }
}
