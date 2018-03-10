namespace ChainOfResponsibility_DesignPattern
{
    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game)
        {
            Attack = 3;
            Defense = 3;
        }
    }

}
