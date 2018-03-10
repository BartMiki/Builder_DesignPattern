using System.Linq;

namespace ChainOfResponsibility_DesignPattern
{
    public class Goblin : Creature
    {
        protected int attack;
        protected int defense;
        protected Game game;

        public override int Attack
        {
            get
            {
                int modifier = game.Creatures.Count(c => c is GoblinKing && c != this);
                return attack + modifier;
            }
            set => attack = value;
        }

        public override int Defense
        {
            get
            {
                int modifier = game.Creatures.Count(c => c is Goblin && c != this);
                return defense + modifier;
            }
            set => defense = value;
        }

        public Goblin(Game game)
        {
            attack = 1;
            defense = 1;
            this.game = game;
        }
    }
}
