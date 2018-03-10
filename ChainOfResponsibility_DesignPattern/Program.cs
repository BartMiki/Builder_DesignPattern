using System;

namespace ChainOfResponsibility_DesignPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var goblin1 = new Goblin(game);
            game.Creatures.Add(goblin1);
            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);
            var goblin3 = new Goblin(game);
            game.Creatures.Add(goblin3);
            var goblinKing = new GoblinKing(game);
            game.Creatures.Add(goblinKing);

            foreach (var creature in game.Creatures)
            {
                Console.WriteLine($"{creature.GetType()}'s attack is {creature.Attack}, defence is: {creature.Defense}.");
            }

            Console.ReadLine();
        }
    }
}
